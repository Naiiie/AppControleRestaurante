using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppControleRestaurante
{
    public partial class Financas : Form
    {
        private readonly string connectionString = "Server=.\\sqlexpress;Database=RestauranteDB;User Id=aluno;Password=aluno";

        public Financas ()
        {
            InitializeComponent();
            // define datas padrão
            dtInicio.Value = DateTime.Today.AddDays(-30);
            dtFim.Value = DateTime.Today;
        }

        // Evento do botão Filtrar / Atualizar
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarRelatorio();
        }

        private void CarregarRelatorio()
        {
            int empresaId = Sessao.EmpresaId; // ajuste se necessário
            DateTime inicio = dtInicio.Value.Date;
            DateTime fim = dtFim.Value.Date.AddDays(1).AddTicks(-1);

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                    SELECT Id AS IdPedido, DataPedido, Total
                    FROM Pedidos
                    WHERE EmpresaId = @EmpresaId
                      AND DataPedido BETWEEN @Inicio AND @Fim
                    ORDER BY DataPedido DESC";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpresaId", empresaId);
                    cmd.Parameters.AddWithValue("@Inicio", inicio);
                    cmd.Parameters.AddWithValue("@Fim", fim);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            dgvVendas.DataSource = dt;

            // Calcula total período
            decimal totalPeriodo = 0m;
            foreach (DataRow r in dt.Rows)
            {
                if (r["Total"] != DBNull.Value)
                    totalPeriodo += Convert.ToDecimal(r["Total"]);
            }

            lblTotalPeriodo.Text = $"Total no período: R$ {totalPeriodo:N2}";
        }
    }
}
