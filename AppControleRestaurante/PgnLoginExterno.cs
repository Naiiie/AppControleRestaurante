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
    public partial class PgnLoginExterno : Form
    {
        public PgnLoginExterno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void txbID_Click(object sender, EventArgs e)
        {
            txbID.Clear();
        }

        private void btnSalvar2_Click(object sender, EventArgs e)
        {

            string NomeFuncionario = txbNomeFuncionario.Text;
            string EmailFuncionario = txbEmailFuncionario.Text;
            string ID_Empresa = txbID.Text;

            string conexao = "Server=sqlexpress;Database=CJ3027473PR2;User Id=aluno;Password=aluno";
            string sql = "INSERT INTO Funcionarios (NomeFuncionario, EmailFuncionario, ID_Empresa) VALUES (@NomeFuncionario ,@EmailFuncionario, @ID_Empresa)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NomeFuncionario", NomeFuncionario);
                    cmd.Parameters.AddWithValue("@EmailFuncionario", EmailFuncionario);
                    cmd.Parameters.AddWithValue("@ID_Empresa", ID_Empresa);

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
            PgnInicioExterno product = new PgnInicioExterno();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
        }
    }

