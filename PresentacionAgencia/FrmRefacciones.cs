using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadorAgencia;
using EntidadAgencia;

namespace PresentacionAgencia
{
    public partial class FrmRefacciones : Form
    {
        ManejadorProductos mp;
        public static Productos productos = new Productos(0, "", "", "");
        public static string prod = "";
        int fila = 0, col = 0;
        public FrmRefacciones()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productos.Codigobarras = int.Parse(dtgProductos.Rows[fila].
               Cells[0].Value.ToString());
            productos.Nombre = dtgProductos.Rows[fila].
                Cells[1].Value.ToString();
            productos.Descripcion = dtgProductos.Rows[fila].
                Cells[2].Value.ToString();
            productos.Marca = dtgProductos.Rows[fila].
                Cells[3].Value.ToString();
            prod = dtgProductos.Rows[fila].Cells[5].Value.ToString();
            switch (col)
            {
                case 6:
                    {
                        FrmAddRefacciones addrefa = new FrmAddRefacciones();
                        addrefa.ShowDialog();
                        Actualizar();
                    }
                    break;
                case 7:
                    {
                        mp.Borrar(productos);
                        Actualizar();
                    }
                    break;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmAddRefacciones addrefa = new FrmAddRefacciones();
            addrefa.ShowDialog();
        }
       

        private void dtgProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }
       

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        void Actualizar()
        {
            mp.Mostrar(dtgProductos, txtProducto.Text);
        }
    }
}
