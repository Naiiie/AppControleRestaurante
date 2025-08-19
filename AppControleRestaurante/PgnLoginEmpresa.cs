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
    public partial class PgnLoginEmpresa : Form
    {
        public PgnLoginEmpresa()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string Nome = TextNome.Text;
            string ID_Empresa = TextAutor.Text;
            string CNPJ = TextSinopse.Text;
            string preco = TextPreço.Text;//MUDAR  PARA OS COMPOENTE DA MINHA TABELA 
            string genero = TextGênero.Text;
            string paginas = TextPaginas.Text;
            string acabamento = TextAcabamento.Text;

            string conexao = "Server=sqlexpress;Database=CJ3027422PR2;User Id=aluno;Password=aluno";
            string sql = "INSERT INTO Livros2 (Nome, Autor, Sinopse, Preco, Genero, Paginas, Acabamento) VALUES (@Nome ,@Autor ,@Sinopse ,@Preco ,@Genero, @Paginas, @Acabamento)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Autor", autor);
                    cmd.Parameters.AddWithValue("@Sinopse", sinopse);
                    cmd.Parameters.AddWithValue("@Preco", preco);
                    cmd.Parameters.AddWithValue("@Genero", genero);
                    cmd.Parameters.AddWithValue("@Paginas", paginas);
                    cmd.Parameters.AddWithValue("@Acabamento", acabamento);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Dados salvos com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar: " + ex.Message);
                    }
                }
    }
}
