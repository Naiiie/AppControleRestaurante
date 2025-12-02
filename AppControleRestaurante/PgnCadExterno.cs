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
    public partial class PgnCadExterno : Form
    {
        public PgnCadExterno()
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
            // Validação dos campos
            if (string.IsNullOrWhiteSpace(txbNomeFuncionario.Text) ||
                string.IsNullOrWhiteSpace(txbEmailFuncionario.Text) ||
                string.IsNullOrWhiteSpace(txbID.Text) ||
                string.IsNullOrWhiteSpace(txbSenha2.Text) ||
                string.IsNullOrWhiteSpace(txbUsuario2.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção");
                return;
            }

            // Validação básica de e-mail
            if (!txbEmailFuncionario.Text.Contains("@") || !txbEmailFuncionario.Text.Contains("."))
            {
                MessageBox.Show("E-mail inválido!", "Erro");
                return;
            }

            // Validação de senha (mínimo 6 caracteres)
            if (txbSenha2.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres!", "Erro");
                return;
            }

            // Validação do ID da empresa (deve ser numérico)
            if (!int.TryParse(txbID.Text.Trim(), out int idEmpresa))
            {
                MessageBox.Show("ID da empresa inválido!", "Erro");
                return;
            }

            string NomeFuncionario = txbNomeFuncionario.Text.Trim();
            string EmailFuncionario = txbEmailFuncionario.Text.Trim();
            string UsuarioF = txbUsuario2.Text.Trim();
            string SenhaF = txbSenha2.Text;

            // 🔐 Gera o hash da senha usando BCrypt
            string senhaHashF = BCrypt.Net.BCrypt.HashPassword(SenhaF);

            string conexao = "Server=sqlexpress;Database=CJ3027473PR2;User Id=aluno;Password=aluno";

            // ⚠️ IMPORTANTE: A coluna no banco deve ser SenhaHashF (não SenhaF)
            string sql = @"INSERT INTO Funcionarios (NomeFuncionario, EmailFuncionario, ID_Empresa, SenhaHashF, UsuarioF) 
                   VALUES (@NomeFuncionario, @EmailFuncionario, @ID_Empresa, @SenhaHashF, @UsuarioF)";

            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    // Verifica se a empresa existe antes de cadastrar
                    string sqlVerifica = "SELECT COUNT(*) FROM Empresas WHERE ID_Empresa = @ID_Empresa";
                    using (SqlCommand cmdVerifica = new SqlCommand(sqlVerifica, conn))
                    {
                        cmdVerifica.Parameters.AddWithValue("@ID_Empresa", idEmpresa);
                        conn.Open();

                        int empresaExiste = (int)cmdVerifica.ExecuteScalar();

                        if (empresaExiste == 0)
                        {
                            MessageBox.Show("ID da empresa não encontrado no sistema!", "Erro");
                            conn.Close();
                            return;
                        }
                    }

                    // Cadastra o funcionário
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@NomeFuncionario", NomeFuncionario);
                        cmd.Parameters.AddWithValue("@EmailFuncionario", EmailFuncionario);
                        cmd.Parameters.AddWithValue("@ID_Empresa", idEmpresa);
                        cmd.Parameters.AddWithValue("@SenhaHashF", senhaHashF); // 🔐 Hash da senha
                        cmd.Parameters.AddWithValue("@UsuarioF", UsuarioF);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso");

                        // Limpa os campos após salvar
                        txbNomeFuncionario.Clear();
                        txbEmailFuncionario.Clear();
                        txbSenha2.Clear();
                        txbUsuario2.Clear();

                        conn.Close();

                        // Abre a tela de login
                        PgnInicioExterno product = new PgnInicioExterno();
                        this.Hide();
                        product.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Erro de chave duplicada
                {
                    MessageBox.Show("Usuário ou e-mail já cadastrado! Escolha outro.", "Erro");
                }
                else if (ex.Number == 547) // Erro de foreign key
                {
                    MessageBox.Show("ID da empresa não existe no sistema!", "Erro");
                }
                else
                {
                    MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro");
            }
        }

        private void BtnEntrar2_Click(object sender, EventArgs e)
        {

        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar3_Click(object sender, EventArgs e)
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

