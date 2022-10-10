using AccesoDatosAgencia;
using Crud;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorAgencia
{
    public class ManejadorProductos
    {
        AccesoProductos ap = new AccesoProductos();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format("¿Está seguro de borrar el producto {0}",
                Entidad.Nombre),
                "!Atención", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                ap.Borrar(Entidad);
        }

        public void Exportar(DataGridView tabla)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            ap.Guardar(Entidad);
            g.Mensaje("Producto Guardado con exito", "!Atención",
            MessageBoxIcon.Information);
        }
        public void Actualizar(dynamic Entidad)
        {
            ap.Actuailizar(Entidad);
            g.Mensaje("Producto Actualizado con exito", "!Atención",
            MessageBoxIcon.Information);
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource =
                ap.Mostrar(filtro).Tables["producto"];
            tabla.Columns.Insert(4, g.Boton(
                "Editar", Color.Green));
            tabla.Columns.Insert(5, g.Boton(
                "Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
        
    }
}
