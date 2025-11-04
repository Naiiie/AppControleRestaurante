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
            PgnCadExterno product = new PgnCadExterno();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCadEmpresa_Click(object sender, EventArgs e)
        {
            PgnCadEmpresa product = new PgnCadEmpresa();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PgnInicial_Load(object sender, EventArgs e)
        {

        }

      

        private void BtnCadExterno_Click(object sender, EventArgs e)
        {
            PgnCadExterno product = new PgnCadExterno();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            PgnLogin product = new PgnLogin();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
            this.Hide();
        }
    }
}

