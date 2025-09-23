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
    public partial class PgnInicioEmpresa : Form
    {
        public PgnInicioEmpresa()
        {
            InitializeComponent();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

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

