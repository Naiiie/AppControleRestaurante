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
    public partial class PgnLogin : Form
    {
        public PgnLogin()
        {
            InitializeComponent();
        }

        private void PgnLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txbLogUsuario.Text;
            string senha = txbLogSenha.Text;

            string conexao = "Server=sqlexpress;Database=CJ3027473PR2;User Id=aluno;Password=aluno";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                // 1️⃣ Verifica login de EMPRESA (usuário master)
                string sql = "SELECT ID_Empresa, Nome, SenhaHash FROM Empresas WHERE Usuario=@Usuario";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int empresaId = reader.GetInt32(0);
                            string nomeEmpresa = reader.GetString(1);
                            string senhaHash = reader.GetString(2);

                            // 🧠 Verifica a senha digitada com o hash salvo
                            if (BCrypt.Net.BCrypt.Verify(senha, senhaHash))
                            {
                                // ✅ Login OK
                                Sessao.EmpresaId = empresaId;
                                Sessao.NomeEmpresa = nomeEmpresa;
                                Sessao.TipoUsuario = "Empresa";

                                MessageBox.Show($"Login master da empresa '{nomeEmpresa}' realizado com sucesso!", "Sucesso");

                                reader.Close();

                                PgnInicioEmpresa tela = new PgnInicioEmpresa();
                                this.Visible = false;
                                tela.ShowDialog();
                                this.Visible = true;
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Senha incorreta!", "Erro");
                                return;
                            }
                        }
                    }
                }

                // 2️⃣ Verifica login de FUNCIONÁRIO
                string sqle = "SELECT ID_Empresa, NomeFuncionario, SenhaHashF FROM Funcionarios WHERE UsuarioF=@UsuarioF";
                using (SqlCommand cmd = new SqlCommand(sqle, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioF", usuario);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int empresaId = reader.GetInt32(0);
                            string nomeFuncionario = reader.GetString(1);
                            string senhaHashF = reader.GetString(2);

                            if (BCrypt.Net.BCrypt.Verify(senha, senhaHashF))
                            {
                                // ✅ Login OK
                                Sessao.EmpresaId = empresaId;
                                Sessao.NomeEmpresa = nomeFuncionario;
                                Sessao.TipoUsuario = "Externo";

                                MessageBox.Show($"Login de usuário externo '{nomeFuncionario}' realizado com sucesso!", "Sucesso");

                                reader.Close();

                                PgnInicioExterno tela = new PgnInicioExterno();
                                this.Visible = false;
                                tela.ShowDialog();
                                this.Visible = true;
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Senha incorreta!", "Erro");
                                return;
                            }
                        }
                    }
                }

                // 3️⃣ Se chegou aqui → nenhum login funcionou
                MessageBox.Show("Usuário ou senha inválidos!", "Erro");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txbLogSenha_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnEsqueciSenha_Click_1(object sender, EventArgs e)
        {
            // Abre a tela de recuperação de senha
            PgnRecuperarSenha recuperarSenha = new PgnRecuperarSenha();
            recuperarSenha.ShowDialog();
            this.Hide();
        }

    }
}