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

                // 1. Verifica usuário master
                string sql = "SELECT Id FROM Empresas WHERE Usuario=@Usuario AND Senha=@Senha";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int empresaId = Convert.ToInt32(result);
                        MessageBox.Show("Login master da empresa realizado com sucesso!");
                        return;
                    }
                }

                // 2. Verifica usuários externos
                string sqle = "SELECT EmpresaId FROM funcionarios WHERE Usuario=@Usuario AND Senha=@Senha";
                using (SqlCommand cmd = new SqlCommand(sqle, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int empresaId = Convert.ToInt32(result);
                        MessageBox.Show("Login de usuário externo realizado com sucesso!");
                        return;
                    }
                }

                // Se chegou aqui, login inválido
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }

    }

}

