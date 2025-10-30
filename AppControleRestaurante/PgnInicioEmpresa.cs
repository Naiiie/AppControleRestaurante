
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

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            Catalogo product = new Catalogo();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void btnFinanças_Click(object sender, EventArgs e)
        {
            Financas product = new Financas();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Adicione aqui a lógica para o evento de mudança de texto
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            // Adicione aqui a lógica para abrir o formulário de funcionários
            // Exemplo:
            // PgnFuncionarios funcionarios = new PgnFuncionarios();
            // this.Visible = false;
            // funcionarios.ShowDialog();
            // this.Visible = true;
        }
    }
}