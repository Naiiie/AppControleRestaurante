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
    public partial class PgnInicioExterno : Form
    {
        public PgnInicioExterno()
        {
            InitializeComponent();
        }

        private void btncatalogo_Click(object sender, EventArgs e)
        {
            Catalogo catalogo = new Catalogo;
            catalogo.Show();
            this.Hide(); // Esconde o form atual (opcional)
        }
        

        private void btnMensagens_Click(object sender, EventArgs e)
        {

        }

        private void btnLancaPedido_Click(object sender, EventArgs e)
        {

            FrmLancarPedido product = new FrmLancarPedido();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void btnSair3_Click(object sender, EventArgs e)
        {
            {
                DialogResult resultado = MessageBox.Show(
                    "Deseja realmente sair?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            }
            PgnInicial tela = new PgnInicial();
            this.Hide();
            tela.ShowDialog();
            this.Close();


        }
    }
    }

