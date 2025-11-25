using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace AppControleRestaurante
{
    public partial class Financas : Form
    {
        private readonly string connectionString = "Server=sqlexpress;Database=CJ3027473PR2;User Id=aluno;Password=aluno";

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
            int empresaId = Sessao.EmpresaId;
            if (empresaId <= 0)
            {
                MessageBox.Show("ERRO: EmpresaId não carregado.");
                return;
            }

            DateTime inicio = dtInicio.Value.Date;
            DateTime fim = dtFim.Value.Date.AddDays(1).AddTicks(-1);

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"
            SELECT IdPedido, DataPedido, Total
            FROM Pedidos
            WHERE EmpresaId = @EmpresaId
              AND DataPedido BETWEEN @Inicio AND @Fim
            ORDER BY DataPedido DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmpresaId", empresaId);
                cmd.Parameters.AddWithValue("@Inicio", inicio);
                cmd.Parameters.AddWithValue("@Fim", fim);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            dgvItens.DataSource = dt;

            decimal totalPeriodo = dt.AsEnumerable()
                                     .Where(r => r["Total"] != DBNull.Value)
                                     .Sum(r => Convert.ToDecimal(r["Total"]));

            lblTotalPeriodo.Text = $"Total no período: R$ {totalPeriodo:N2}";
        }


        private void Financas_Load(object sender, EventArgs e)
        {

        }

        private void dgvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
