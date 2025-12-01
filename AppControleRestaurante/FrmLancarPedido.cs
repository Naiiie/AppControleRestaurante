using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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

                    // *** GERAR A NOTA EM HTML ***
                    GerarNotaHTML(idPedido, total);

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
        private void GerarNotaHTML(int idPedido, decimal total)
        {
            try
            {
                string html = $@"
<!DOCTYPE html>
<html>
<head>
    <meta charset='UTF-8'>
    <title>Pedido {idPedido}</title>
    <style>
        body {{ 
            font-family: Arial, sans-serif; 
            margin: 40px; 
            background-color: #f5f5f5;
        }}
        .container {{
            background-color: white;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
            max-width: 800px;
            margin: 0 auto;
        }}
        h1 {{ 
            text-align: center; 
            color: #333;
            border-bottom: 3px solid #4CAF50;
            padding-bottom: 10px;
        }}
        .info {{
            margin: 20px 0;
            line-height: 1.8;
        }}
        .info p {{
            margin: 5px 0;
        }}
        table {{ 
            width: 100%; 
            border-collapse: collapse; 
            margin-top: 20px; 
        }}
        th, td {{ 
            border: 1px solid #ddd; 
            padding: 12px; 
            text-align: left; 
        }}
        th {{ 
            background-color: #4CAF50; 
            color: white;
            font-weight: bold;
        }}
        tr:nth-child(even) {{
            background-color: #f9f9f9;
        }}
        tr:hover {{
            background-color: #f1f1f1;
        }}
        .total {{ 
            text-align: right; 
            font-size: 24px; 
            font-weight: bold; 
            margin-top: 30px;
            color: #4CAF50;
            border-top: 2px solid #333;
            padding-top: 15px;
        }}
        .footer {{
            text-align: center;
            margin-top: 40px;
            color: #777;
            font-size: 12px;
        }}
        @media print {{
            body {{ margin: 0; background-color: white; }}
            .container {{ box-shadow: none; }}
            .no-print {{ display: none; }}
        }}
        .btn-print {{
            background-color: #4CAF50;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 16px;
            margin: 20px 0;
        }}
        .btn-print:hover {{
            background-color: #45a049;
        }}
    </style>
</head>
<body>
    <div class='container'>
        <h1>NOTA DE PEDIDO</h1>
        
        <div class='info'>
            <p><strong>Pedido Nº:</strong> {idPedido}</p>
            <p><strong>Data:</strong> {DateTime.Now:dd/MM/yyyy}</p>
            <p><strong>Hora:</strong> {DateTime.Now:HH:mm:ss}</p>
            <p><strong>Empresa ID:</strong> {empresaId}</p>
        </div>

        <table>
            <thead>
                <tr>
                    <th>Produto</th>
                    <th style='text-align: center;'>Quantidade</th>
                    <th style='text-align: right;'>Preço Unit.</th>
                    <th style='text-align: right;'>Subtotal</th>
                </tr>
            </thead>
            <tbody>";

                // Adicionar itens do pedido
                foreach (DataGridViewRow row in dgvItens.Rows)
                {
                    string produto = row.Cells["NomeItem"].Value.ToString();
                    string quantidade = row.Cells["Quantidade"].Value.ToString();
                    decimal precoUnit = Convert.ToDecimal(row.Cells["PrecoUnitario"].Value);
                    decimal subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);

                    html += $@"
                <tr>
                    <td>{produto}</td>
                    <td style='text-align: center;'>{quantidade}</td>
                    <td style='text-align: right;'>R$ {precoUnit:N2}</td>
                    <td style='text-align: right;'>R$ {subtotal:N2}</td>
                </tr>";
                }

                html += $@"
            </tbody>
        </table>

        <div class='total'>
            TOTAL: R$ {total:N2}
        </div>

        <div class='no-print' style='text-align: center;'>
            <button class='btn-print' onclick='window.print()'>🖨️ Imprimir / Salvar como PDF</button>
        </div>

        <div class='footer'>
            <p>Obrigado pela preferência!</p>
            <p>Documento gerado em {DateTime.Now:dd/MM/yyyy HH:mm:ss}</p>
        </div>
    </div>
</body>
</html>";

                // Salvar arquivo HTML
                string pasta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Pedidos");
                if (!Directory.Exists(pasta))
                    Directory.CreateDirectory(pasta);

                string nomeArquivo = $"Pedido_{idPedido}_{DateTime.Now:yyyyMMdd_HHmmss}.html";
                string caminhoCompleto = Path.Combine(pasta, nomeArquivo);

                File.WriteAllText(caminhoCompleto, html, System.Text.Encoding.UTF8);

                // Abrir no navegador padrão
                System.Diagnostics.Process.Start(caminhoCompleto);

                MessageBox.Show($"Nota gerada com sucesso!\n\nArquivo salvo em:\n{caminhoCompleto}",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar nota: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
