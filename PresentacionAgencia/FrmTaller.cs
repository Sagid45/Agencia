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
    public partial class FrmTaller : Form
    {
        public FrmTaller()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarHerramienta_Click(object sender, EventArgs e)
        {
            FrmAddTaller addtall = new FrmAddTaller();
            addtall.ShowDialog();
        }
    }
}
