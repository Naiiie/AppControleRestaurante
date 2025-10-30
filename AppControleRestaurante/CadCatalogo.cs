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
    public partial class CadCatalogo : Form
    {
        public CadCatalogo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAtividadeP_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarP_Click(object sender, EventArgs e)
        {
            string NomeItem = txbNomeP.Text;
            string descricao = txbDescricaoP.Text;
            string custo = txbCustoP.Text;
            string preco = txbValorP.Text;

            // Conversão e validação dos campos numéricos
            decimal custoDecimal;
            decimal precoDecimal;

            if (!decimal.TryParse(custo, out custoDecimal))
            {
                MessageBox.Show("Digite um valor numérico válido para Custo.");
                return;
            }

            if (!decimal.TryParse(preco, out precoDecimal))
            {
                MessageBox.Show("Digite um valor numérico válido para Preço.");
                return;
            }

            // Verifica se há uma empresa logada
            if (Sessao.EmpresaId <= 0)
            {
                MessageBox.Show("Nenhuma empresa logada! Faça login novamente.");
                return;
            }

            // ✅ ADICIONE ESTA VALIDAÇÃO PARA CATEGORIA
            if (cmbCategoriaP.Text == null) // ou cmbCategoria.Text se for ComboBox simples
            {
                MessageBox.Show("Selecione uma categoria!");
                return;
            }

            string conexao = "Server=sqlexpress;Database=CJ3027473PR2;User Id=aluno;Password=aluno";

            // ✅ ADICIONE "Categoria" NA QUERY
            string sql = "INSERT INTO CATALOGO (NomeItem, Descricao, Custo, Preco, Categoria, EmpresaId) " +
                         "VALUES (@NomeItem, @Descricao, @Custo, @Preco, @Categoria, @EmpresaId)";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NomeItem", NomeItem);
                    cmd.Parameters.AddWithValue("@Descricao", descricao);
                    cmd.Parameters.AddWithValue("@Custo", custoDecimal);
                    cmd.Parameters.AddWithValue("@Preco", precoDecimal);

                    // ✅ ADICIONE O PARÂMETRO DE CATEGORIA
                    // Use SelectedValue se o ComboBox tiver ValueMember configurado
                    // Ou use Text se for apenas texto
                    cmd.Parameters.AddWithValue("@Categoria", cmbCategoriaP.Text);
                    // OU
                    // cmd.Parameters.AddWithValue("@Categoria", cmbCategoria.Text);

                    cmd.Parameters.AddWithValue("@EmpresaId", Sessao.EmpresaId);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produto salvo com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar: " + ex.Message);
                    }
                }
            }


            Catalogo product = new Catalogo();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CmbAtividadeP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}