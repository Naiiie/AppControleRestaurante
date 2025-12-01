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
            string NomeItem = txbNomeP.Text.Trim();
            string descricao = txbDescricaoP.Text.Trim();
            string custo = txbCustoP.Text.Trim();
            string preco = txbValorP.Text.Trim();
            string categoria = cmbCategoriaP.Text.Trim();
            string estoqueTexto = txbEstoqueP.Text.Trim(); // novo campo de estoque (TextBox)

            // 🔹 Validações básicas
            if (string.IsNullOrWhiteSpace(NomeItem) ||
                string.IsNullOrWhiteSpace(descricao) ||
                string.IsNullOrWhiteSpace(custo) ||
                string.IsNullOrWhiteSpace(preco) ||
                string.IsNullOrWhiteSpace(categoria) ||
                string.IsNullOrWhiteSpace(estoqueTexto))
            {
                MessageBox.Show("Preencha todos os campos antes de salvar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔹 Conversão e validação dos campos numéricos
            if (!decimal.TryParse(custo, out decimal custoDecimal))
            {
                MessageBox.Show("Digite um valor numérico válido para Custo.");
                return;
            }

            if (!decimal.TryParse(preco, out decimal precoDecimal))
            {
                MessageBox.Show("Digite um valor numérico válido para Preço.");
                return;
            }

            if (!int.TryParse(estoqueTexto, out int estoqueInt))
            {
                MessageBox.Show("Digite um valor numérico válido para Estoque (apenas números inteiros).");
                return;
            }

         
            // 🔹 String de conexão
            string conexao = "Server=sqlexpress;Database=CJ3027473PR2;User Id=aluno;Password=aluno";

            // 🔹 Query SQL com Estoque incluído
            string sql = @"
        INSERT INTO CATALOGO 
            (NomeItem, Descricao, Custo, Preco, Categoria, EmpresaId, Estoque, Ativo)
        VALUES 
            (@NomeItem, @Descricao, @Custo, @Preco, @Categoria, @EmpresaId, @Estoque, 1)";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NomeItem", NomeItem);
                    cmd.Parameters.AddWithValue("@Descricao", descricao);
                    cmd.Parameters.AddWithValue("@Custo", custoDecimal);
                    cmd.Parameters.AddWithValue("@Preco", precoDecimal);
                    cmd.Parameters.AddWithValue("@Categoria", categoria);
                    cmd.Parameters.AddWithValue("@EmpresaId", Sessao.EmpresaId);
                    cmd.Parameters.AddWithValue("@Estoque", estoqueInt);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("✅ Produto salvo com sucesso!");

                        // 🔄 Limpa os campos após salvar
                        txbNomeP.Clear();
                        txbDescricaoP.Clear();
                        txbCustoP.Clear();
                        txbValorP.Clear();
                        txbEstoqueP.Clear();
                        cmbCategoriaP.SelectedIndex = -1;
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

        private void lblEstoque_Click(object sender, EventArgs e)
        {

        }
    }
}