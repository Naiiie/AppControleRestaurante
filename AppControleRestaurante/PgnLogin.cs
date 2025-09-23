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

                // 1. Verifica usuário master (empresa)
                string sql = "SELECT ID_Empresa, Nome FROM Empresas WHERE Usuario=@Usuario AND Senha=@Senha";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int empresaId = reader.GetInt32(0);
                            string nomeEmpresa = reader.GetString(1);

                            // 🔹 Salva dados na Sessao
                            Sessao.EmpresaId = empresaId;
                            Sessao.NomeEmpresa = nomeEmpresa;
                            Sessao.TipoUsuario = "Empresa";

                            MessageBox.Show($"Login master da empresa '{nomeEmpresa}' realizado com sucesso!");

                            reader.Close();

                            PgnInicioEmpresa product = new PgnInicioEmpresa();
                            this.Visible = false;
                            product.ShowDialog();
                            this.Visible = true;

                            return;
                        }
                    }
                }

                // 2. Verifica usuários externos
                string sqle = "SELECT ID_Empresa, NomeFuncionario FROM Funcionarios WHERE UsuarioF=@UsuarioF AND SenhaF=@SenhaF";
                using (SqlCommand cmd = new SqlCommand(sqle, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioF", usuario);
                    cmd.Parameters.AddWithValue("@SenhaF", senha);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int empresaId = reader.GetInt32(0);
                            string nomeFuncionario = reader.GetString(1);

                            // 🔹 Salva dados na Sessao
                            Sessao.EmpresaId = empresaId;
                            Sessao.NomeEmpresa = nomeFuncionario; // ou puxar nome da empresa se preferir
                            Sessao.TipoUsuario = "Externo";

                            MessageBox.Show($"Login de usuário externo '{nomeFuncionario}' realizado com sucesso!");

                            reader.Close();

                            PgnInicioExterno product = new PgnInicioExterno();
                            this.Visible = false;
                            product.ShowDialog();
                            this.Visible = true;

                            return;
                        }
                    }
                }

                // 👉 Se chegou aqui, nenhum login foi válido
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }
    }
}