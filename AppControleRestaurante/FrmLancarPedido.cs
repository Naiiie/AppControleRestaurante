using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppControleRestaurante
{
    public partial class FrmLancarPedido : Form
    {
        private readonly int idFuncionario;
        private readonly int empresaId = Sessao.EmpresaId; // sua sessão
        private readonly string connectionString = "Server=sqlexpress;Database=CJ3027473PR2 ;User Id=aluno;Password=aluno";
        public FrmLancarPedido()
        {
            InitializeComponent();
            idFuncionario = 0; // valor padrão (sem login)
        }

        private void FrmLancarPedido_Load(object sender, EventArgs e)
        {
            MontarGrid();
            CarregarCatalogo();
            AtualizarTotal();
        }

        private void MontarGrid()
        {
            dgvItens.Columns.Clear();
            dgvItens.Columns.Add("IdItem", "ID");
            dgvItens.Columns.Add("NomeItem", "Produto");
            dgvItens.Columns.Add("Quantidade", "Qtd");
            dgvItens.Columns.Add("PrecoUnitario", "Preço");
            dgvItens.Columns.Add("Subtotal", "Subtotal");

            // Ajustes visuais
            dgvItens.Columns["IdItem"].Width = 50;
            dgvItens.Columns["Quantidade"].Width = 60;
            dgvItens.Columns["PrecoUnitario"].Width = 80;
            dgvItens.Columns["Subtotal"].Width = 100;

            dgvItens.ReadOnly = true;
            dgvItens.AllowUserToAddRows = false;
        }

        private void CarregarCatalogo(string pesquisa = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT IdItem, NomeItem, Preco, Estoque
                                 FROM Catalogo
                                 WHERE EmpresaId = @EmpresaId AND Ativo = 1
                                 AND (@pesq = '' OR NomeItem LIKE @pesq)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmpresaId", empresaId);
                cmd.Parameters.AddWithValue("@pesq", "%" + pesquisa + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbProduto.DataSource = dt;
                cmbProduto.DisplayMember = "NomeItem";
                cmbProduto.ValueMember = "IdItem";
            }
        }

        // Se você tem botão de pesquisa no catálogo, ligue a este evento
        private void btnPesquisarP_Click(object sender, EventArgs e)
        {
            CarregarCatalogo(txbPesquisaCatalogo.Text.Trim());
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            if (cmbProduto.SelectedValue == null) { MessageBox.Show("Selecione um produto."); return; }

            int idItem = Convert.ToInt32(cmbProduto.SelectedValue);
            int qtd = (int)numQuantidade.Value;
            if (qtd <= 0) { MessageBox.Show("Quantidade inválida."); return; }

            // Busca preço e estoque atuais
            (decimal preco, int estoque) = ObterPrecoEEstoque(idItem);

            if (estoque >= 0 && qtd > estoque)
            {
                MessageBox.Show($"Estoque insuficiente. Estoque atual: {estoque}");
                return;
            }

            decimal subtotal = preco * qtd;

            // Adiciona na grid
            dgvItens.Rows.Add(idItem, cmbProduto.Text, qtd, preco, subtotal);
            AtualizarTotal();
        }

        private (decimal preco, int estoque) ObterPrecoEEstoque(int idItem)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string q = "SELECT Preco, ISNULL(Estoque, -1) FROM Catalogo WHERE IdItem = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", idItem);
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        decimal p = r.IsDBNull(0) ? 0 : r.GetDecimal(0);
                        int e = r.IsDBNull(1) ? -1 : r.GetInt32(1); // -1 = sem controle de estoque
                        return (p, e);
                    }
                }
            }
            return (0m, -1);
        }

        private void AtualizarTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvItens.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }
            lblTotal.Text = $"Total: R$ {total:N2}";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (dgvItens.Rows.Count == 0) { MessageBox.Show("Adicione itens antes de finalizar."); return; }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction tx = conn.BeginTransaction();

                try
                {
                    // Calcula total
                    decimal total = 0;
                    foreach (DataGridViewRow row in dgvItens.Rows)
                        total += Convert.ToDecimal(row.Cells["Subtotal"].Value);

                    // Inserir pedido
                    string insPedido = "INSERT INTO Pedidos (IdFuncionario, EmpresaId, Total) OUTPUT INSERTED.IdPedido VALUES (@IdFunc, @EmpresaId, @Total)";
                    SqlCommand cmdPedido = new SqlCommand(insPedido, conn, tx);
                    cmdPedido.Parameters.AddWithValue("@IdFunc", idFuncionario);
                    cmdPedido.Parameters.AddWithValue("@EmpresaId", empresaId);
                    cmdPedido.Parameters.AddWithValue("@Total", total);
                    int idPedido = (int)cmdPedido.ExecuteScalar();

                    // Inserir itens e atualizar estoque
                    foreach (DataGridViewRow row in dgvItens.Rows)
                    {
                        int idProduto = Convert.ToInt32(row.Cells["IdItem"].Value);
                        int qtd = Convert.ToInt32(row.Cells["Quantidade"].Value);
                        decimal preco = Convert.ToDecimal(row.Cells["PrecoUnitario"].Value);

                        // Inserir item
                        string insItem = @"INSERT INTO ItensPedido (IdPedido, IdProduto, Quantidade, PrecoUnitario)
                                           VALUES (@IdPedido, @IdProduto, @Qtd, @Preco)";
                        SqlCommand cmdItem = new SqlCommand(insItem, conn, tx);
                        cmdItem.Parameters.AddWithValue("@IdPedido", idPedido);
                        cmdItem.Parameters.AddWithValue("@IdProduto", idProduto);
                        cmdItem.Parameters.AddWithValue("@Qtd", qtd);
                        cmdItem.Parameters.AddWithValue("@Preco", preco);
                        cmdItem.ExecuteNonQuery();

                        // Atualizar estoque se coluna Estoque existir e for não nula
                        string updEstoque = @"UPDATE Catalogo
                                              SET Estoque = CASE WHEN Estoque IS NULL THEN NULL ELSE Estoque - @Qtd END
                                              WHERE IdItem = @IdItem AND EmpresaId = @EmpresaId";
                        SqlCommand cmdUpd = new SqlCommand(updEstoque, conn, tx);
                        cmdUpd.Parameters.AddWithValue("@Qtd", qtd);
                        cmdUpd.Parameters.AddWithValue("@IdItem", idProduto);
                        cmdUpd.Parameters.AddWithValue("@EmpresaId", empresaId);
                        cmdUpd.ExecuteNonQuery();
                    }

                    tx.Commit();
                    MessageBox.Show("Pedido finalizado com sucesso!");
                    dgvItens.Rows.Clear();
                    AtualizarTotal();
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    MessageBox.Show("Erro ao finalizar pedido: " + ex.Message);
                }
            }
        }

        // Caso queira remover item selecionado (opcional)
        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            if (dgvItens.CurrentRow != null)
            {
                dgvItens.Rows.RemoveAt(dgvItens.CurrentRow.Index);
                AtualizarTotal();
            }
        }
    }
}
