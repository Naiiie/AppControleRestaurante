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
    public partial class PgnLoginEmpresa : Form
    {
        public PgnLoginEmpresa()
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
            

            string conexao = "Server=sqlexpress;Database=CJ3027473PR2;User Id=aluno;Password=aluno";
            string sql = "INSERT INTO EMPRESAS (Nome, CNPJ, Email, Contato, Usuario) VALUES (@Nome ,@CNPJ ,@Email,@Contato, @Usuario)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@CNPJ", CNPJ);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Contato", Contato);
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    
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
        }

        private void btnGeradorID1_Click(object sender, EventArgs e)
        {
        }

        private void TxbNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



