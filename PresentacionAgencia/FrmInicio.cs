using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionAgencia
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmRefacciones refa = new FrmRefacciones();
            refa.ShowDialog();
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            FrmTaller tall = new FrmTaller();
            tall.ShowDialog();
        }
    }
}
