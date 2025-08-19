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
    public partial class PgnInicial : Form
    {
        public PgnInicial()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PgnLoginExterno product = new PgnLoginExterno();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCadEmpresa_Click(object sender, EventArgs e)
        {
            PgnLoginEmpresa product = new PgnLoginEmpresa();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
