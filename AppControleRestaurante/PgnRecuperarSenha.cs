using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using BCrypt.Net; // precisa do pacote BCrypt.Net-Next

namespace AppControleRestaurante
{
    public partial class PgnRecuperarSenha : Form
    {
        public PgnRecuperarSenha()
        {
            InitializeComponent();
        }

        // 🔹 Botão "Enviar código de redefinição"
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string usuario = txbUsuarioRec.Text.Trim();
            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Digite o nome de usuário para recuperar a senha.", "Aviso");
                return;
            }

            string conexao = "Server=sqlexpress;Database=CJ3027473PR2;User Id=aluno;Password=aluno";
            string emailDestino = null;

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                // Busca e-mail do usuário em ambas as tabelas
                string sql = @"
                    SELECT Email FROM Empresas WHERE Usuario = @Usuario
                    UNION
                    SELECT EmailFuncionario FROM Funcionarios WHERE UsuarioF = @Usuario";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        emailDestino = result.ToString();
                }

                if (emailDestino == null)
                {
                    MessageBox.Show("Usuário não encontrado.", "Erro");
                    return;
                }

                // Gera token e salva no banco
                Guid token = Guid.NewGuid();
                DateTime expira = DateTime.Now.AddMinutes(30);

                string insertSql = "INSERT INTO RecuperacaoSenha (Usuario, Token, DataExpiracao, Usado) VALUES (@Usuario, @Token, @Expira, 0)";
                using (SqlCommand cmd = new SqlCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Token", token);
                    cmd.Parameters.AddWithValue("@Expira", expira);
                    cmd.ExecuteNonQuery();
                }

                // Envia o e-mail com o token
                try
                {
                    EnviarEmailRecuperacao(emailDestino, usuario, token);
                    MessageBox.Show($"Um código de redefinição foi enviado para:\n{emailDestino}", "Sucesso");

                    // Mostra o painel para redefinir senha
                    pnlRedefinirSenha.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar o e-mail: " + ex.Message + "\n\nDetalhes: " + ex.InnerException?.Message, "Erro");
                }
            }
        }

        // 🔹 Envia o e-mail com o token
        private void EnviarEmailRecuperacao(string destinatario, string usuario, Guid token)
        {
            // Lê as credenciais do App.config (mais seguro)
            string remetente = ConfigurationManager.AppSettings["EmailRemetente"] ?? "controlerestaurante1@gmail.com";
            string senhaApp = ConfigurationManager.AppSettings["EmailSenhaApp"] ?? "xqeiaexwrnndgvaw";

            // ⚠️ Se não usar App.config, substitua diretamente aqui:
            // string remetente = "seuemail@gmail.com";
            // string senhaApp = "abcd efgh ijkl mnop"; // Senha de app de 16 dígitos

            string corpo = $@"
Olá {usuario},

Recebemos uma solicitação para redefinir sua senha.

Use o seguinte token de recuperação dentro de 30 minutos:
{token}

Se você não solicitou isso, ignore esta mensagem.

---
Sistema de Controle de Restaurante";

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(remetente, "Sistema de Empresas");
                mail.To.Add(destinatario);
                mail.Subject = "Recuperação de Senha";
                mail.Body = corpo;
                mail.IsBodyHtml = false;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(remetente, senhaApp);
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Timeout = 20000; // 20 segundos
                    smtp.Send(mail);
                }
            }
        }

        // 🔹 Botão "Redefinir senha" dentro do painel
        private void btnRedefinir_Click_1(object sender, EventArgs e)
        {
            string tokenTexto = txbToken.Text.Trim();
            string novaSenha = txbNovaSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(tokenTexto) || string.IsNullOrWhiteSpace(novaSenha))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso");
                return;
            }

            if (!Guid.TryParse(tokenTexto, out Guid token))
            {
                MessageBox.Show("Token inválido.", "Erro");
                return;
            }

            string conexao = "Server=sqlexpress;Database=CJ3027473PR2;User Id=aluno;Password=aluno";
            string usuario = null;

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                // Verifica se o token é válido
                string sql = "SELECT Usuario FROM RecuperacaoSenha WHERE Token=@Token AND Usado=0 AND DataExpiracao > GETDATE()";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Token", token);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        usuario = result.ToString();
                }

                if (usuario == null)
                {
                    MessageBox.Show("Token inválido ou expirado.", "Erro");
                    return;
                }

                // Atualiza senha nas tabelas
                string novaHash = BCrypt.Net.BCrypt.HashPassword(novaSenha);
                string updateSql = @"
                    UPDATE Empresas SET SenhaHash=@Senha WHERE Usuario=@Usuario;
                    UPDATE Funcionarios SET SenhaHashF=@Senha WHERE UsuarioF=@Usuario;";

                using (SqlCommand cmd = new SqlCommand(updateSql, conn))
                {
                    cmd.Parameters.AddWithValue("@Senha", novaHash);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.ExecuteNonQuery();
                }

                // Marca o token como usado
                string updateToken = "UPDATE RecuperacaoSenha SET Usado=1 WHERE Token=@Token";
                using (SqlCommand cmd = new SqlCommand(updateToken, conn))
                {
                    cmd.Parameters.AddWithValue("@Token", token);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Senha redefinida com sucesso!", "Sucesso");
                pnlRedefinirSenha.Visible = false;
                txbToken.Text = "";
                txbNovaSenha.Text = "";
            }
            PgnLogin product = new PgnLogin();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }


        private void pnlRedefinirSenha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbUsuarioRec_TextChanged(object sender, EventArgs e)
        {

        }

        private void PgnRecuperarSenha_Load(object sender, EventArgs e)
        {

        }
    }
    }
