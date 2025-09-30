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
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        private void CadProduto_Click(object sender, EventArgs e)
        {
            {
                CadCatalogo product = new CadCatalogo();
                this.Visible = false;
                product.ShowDialog();
                this.Visible = true;
            }
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            int empresaId = Sessao.EmpresaId;

            string conexao = "Server=sqlexpress;Database=CJ3027473PR2;User Id=aluno;Password=aluno";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                string query = "SELECT NomeItem, Descricao, Preco, Categoria, Ativo, Custo " +
                "FROM Catalogo " +
                "WHERE EmpresaId = @EmpresaId";
               

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmpresaId", empresaId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }



        private void btnPesquisarP_Click(object sender, EventArgs e)
        {
            string filtro = txbPesquisa.Text.Trim();
            int empresaId = Sessao.EmpresaId;

            string conexao = "Server=sqlexpress;Database=RestauranteDB;User Id=aluno;Password=aluno";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                string query = "SELECT NomeItem, Descricao, Preco, Estoque " +
                               "FROM Catalogo " +
                               "WHERE EmpresaId = @EmpresaId AND NomeItem LIKE @Pesquisa";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmpresaId", empresaId);
                cmd.Parameters.AddWithValue("@Pesquisa", "%" + filtro + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int empresaId = Sessao.EmpresaId; // pega o ID da empresa logada

                string conexao = "Server=sqlexpress;Database=RestauranteDB;User Id=aluno;Password=aluno";
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    conn.Open();
                    string query = "SELECT NomeItem, Descricao, Preco, Estoque FROM Produtos WHERE EmpresaId = @EmpresaId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmpresaId", empresaId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
