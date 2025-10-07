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
            string nomeEmpresa = TxbNome.Text;
            string usuario = TxbUsuario.Text;
            string senha = TxbSenha.Text;

            if (string.IsNullOrWhiteSpace(nomeEmpresa) ||
                string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro");
                return;
            }

            // Gera o hash da senha
            string senhaHash = BCrypt.Net.BCrypt.HashPassword(senha);

            string conexao = "Server=sqlexpress;Database=CJ3027473PR2;User Id=aluno;Password=aluno";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                string sql = "INSERT INTO Empresas (Nome, Usuario, SenhaHash) VALUES (@Nome, @Usuario, @SenhaHash)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nomeEmpresa);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@SenhaHash", senhaHash);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Empresa cadastrada com sucesso!", "Sucesso");
            this.Close();
        }
    }
}


        private void TxbNome_TextChanged(object sender, EventArgs e)
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




