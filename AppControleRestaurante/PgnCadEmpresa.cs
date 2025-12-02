using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppControleRestaurante
{
    public partial class PgnCadEmpresa : Form
    {
        public PgnCadEmpresa()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeEmpresa = TxbNome.Text.Trim();
            string usuario = TxbUsuario.Text.Trim();
            string senha = TxbSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(nomeEmpresa) ||
                string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gera o hash seguro da senha
            string senhaHash = BCrypt.Net.BCrypt.HashPassword(senha);

            string conexao = "Server=sqlexpress;Database=CJ3027473PR2;User Id=aluno;Password=aluno";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                // ⚠️ Certifique-se de ter a coluna "SenhaHash" no SQL!
                // Caso sua tabela ainda use "Senha", troque o nome no INSERT.
                string sql = "INSERT INTO Empresas (Nome, Usuario, SenhaHash) VALUES (@Nome, @Usuario, @SenhaHash)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nomeEmpresa);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@SenhaHash", senhaHash);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Empresa cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Erro ao salvar empresa:\n{ex.Message}", "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void TxbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbSenha_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TxbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureLog1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
  {
            // Validação dos campos obrigatórios
            if (string.IsNullOrWhiteSpace(TxbNome.Text) ||
                string.IsNullOrWhiteSpace(TxbCNPJ.Text) ||
                string.IsNullOrWhiteSpace(TxbEmail.Text) ||
                string.IsNullOrWhiteSpace(TxbUsuario.Text) ||
                string.IsNullOrWhiteSpace(TxbSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios!", "Atenção");
                return;
            }

            // Validação básica de CNPJ (14 dígitos)
            string cnpj = TxbCNPJ.Text.Trim().Replace(".", "").Replace("/", "").Replace("-", "");
            if (cnpj.Length != 14 || !cnpj.All(char.IsDigit))
            {
                MessageBox.Show("CNPJ inválido! Deve conter 14 dígitos.", "Erro");
                return;
            }

                // Validação básica de e-mail
                if (!TxbEmail.Text.Contains("@") || !TxbEmail.Text.Contains("."))
                {
                    MessageBox.Show("E-mail inválido!", "Erro");
                    return;
                }
                // Validação de senha (mínimo 6 caracteres)
                if (TxbSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres!", "Erro");
                return;
            }

            string nome = TxbNome.Text.Trim();
            string email = TxbEmail.Text.Trim();
            string contato = TxbContato.Text.Trim();
            string usuario = TxbUsuario.Text.Trim();
            string senha = TxbSenha.Text;
            string extensao = CmbTamEmpresa.SelectedItem?.ToString() ?? "";

            // Gera o hash da senha usando BCrypt
            string senhaHash = BCrypt.Net.BCrypt.HashPassword(senha);

            string conexao = "Server=sqlexpress;Database=CJ3027473PR2;User Id=aluno;Password=aluno";
            string sql = @"INSERT INTO Empresas (Nome, CNPJ, Email, Contato,TamanhoEmpresa, Usuario, SenhaHash) 
                   VALUES (@Nome, @CNPJ, @Email, @Contato, @TamanhoEmpresa, @Usuario, @SenhaHash);
                   SELECT CAST(SCOPE_IDENTITY() AS INT);";

            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@CNPJ", cnpj);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Contato", string.IsNullOrEmpty(contato) ? (object)DBNull.Value : contato);
                        cmd.Parameters.AddWithValue("@TamanhoEmpresa", string.IsNullOrEmpty(extensao) ? (object)DBNull.Value : extensao);
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@SenhaHash", senhaHash);

                        conn.Open();

                        // Executa o INSERT e retorna o ID gerado
                        int empresaId = (int)cmd.ExecuteScalar();

                        MessageBox.Show("Empresa cadastrada com sucesso!", "Sucesso");

                        // Define os dados da sessão
                        Sessao.EmpresaId = empresaId;
                        Sessao.NomeEmpresa = nome;
                        Sessao.TipoUsuario = "Empresa";

                        // Abre a tela principal da empresa
                        PgnInicioEmpresa tela = new PgnInicioEmpresa();
                        this.Hide();
                        tela.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Erro de chave duplicada
                {
                    MessageBox.Show("Usuário ou CNPJ já cadastrado! Escolha outro.", "Erro");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar empresa: " + ex.Message, "Erro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar empresa: " + ex.Message, "Erro");
            }
        }
    }

        private void btnvoltar1_Click(object sender, EventArgs e)
        {
            {
                {
                    DialogResult resultado = MessageBox.Show(
                        "Deseja voltar a pagina inicial?",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                }
                }
                PgnInicial tela = new PgnInicial();
                this.Hide();
                tela.ShowDialog();
                this.Close();

            }
        }
}



namespace AppControleRestaurante
{
    public partial class PgnCadEmpresa : Form
    {
        private void TxbNome_TextChange(object sender, EventArgs e)
        {

        }

        private void TxbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
       
        {
            string Usuario = TxbUsuario.Text;
            string Senha = TxbSenha.Text;

            string conexao = "Server=sqlexpress;Database=CJ3027473PR2;User Id=aluno;Password=aluno";
            string sql = "SELECT COUNT(*) FROM EMPRESAS WHERE Usuario=@Usuario AND Senha=@Senha";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    cmd.Parameters.AddWithValue("@Senha", Senha);

                    try
                    {
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login realizado com sucesso!");

                            // abre a tela principal
                            PgnInicioEmpresa inicio = new PgnInicioEmpresa();
                            this.Hide();
                            inicio.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }

    }
}




