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
    public partial class sessao : Form
    {
        public sessao()
        {
            InitializeComponent();
        }

        private void sessao_Load(object sender, EventArgs e)
        {

        }
    }
    public static class Sessao
    {
        public static int EmpresaId { get; set; } = 0;
        public static string TipoUsuario { get; set; } = "";
        public static string NomeEmpresa { get; set; } = "";
    }
    public static class Sessao1
    {
        public static int EmpresaId { get; set; }
        public static string NomeEmpresa { get; set; }
        public static string Usuario { get; set; }
    }

}
