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

        public object TextNome { get; private set; }
        //salva os dados no banco e no lugar correto
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string Nome = TxbNome.Text;
            //string ID_Empresa = TxbID_Empresa.Text;  
            string CNPJ = TxbCNPJ.Text;
            string Email = TxbEmail.Text;
            string Contato = TxbContato.Text;
            string Usuario = TxbUsuario.Text;
            string Senha = TxbSenha.Text;



            string conexao = "Server=sqlexpress;Database=CJ3027473PR2;User Id=aluno;Password=aluno";
            string sql = "INSERT INTO EMPRESAS (Nome, CNPJ, Email, Contato, Usuario,Senha) VALUES (@Nome ,@CNPJ ,@Email,@Contato, @Usuario, @Senha)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@CNPJ", CNPJ);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Contato", Contato);
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    cmd.Parameters.AddWithValue("@Senha", Senha);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Dados salvos com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar: " + ex.Message);

                    }
                }
            }
            PgnInicioEmpresa product = new PgnInicioEmpresa();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;


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


        private void btnGeradorID1_Click(object sender, EventArgs e)
        {
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




