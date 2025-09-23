using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // TODO: esta linha de código carrega dados na tabela 'cJ3027473PR2DataSet.Catalogo'. Você pode movê-la ou removê-la conforme necessário.
            this.catalogoTableAdapter.Fill(this.cJ3027473PR2DataSet.Catalogo);

        }

        private void btnPesquisarP_Click(object sender, EventArgs e)
        {
            
        {
            string filtro = txbPesquisa.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["NomeItem"].Value != null)
                {
                    string nomeProduto = row.Cells["NomeItem"].Value.ToString().ToLower();
                    row.Visible = nomeProduto.Contains(filtro);
                }
            }
        }

    }
}
}
