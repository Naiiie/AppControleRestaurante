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
            Catalogo product = new Catalogo();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
    }

