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
    public class ManejadorUsuarios
    {
        AccesoUsuarios au = new AccesoUsuarios();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format("¿Está seguro de borrar el Usuario {0}",
                Entidad.Nombre),
                "!Atención", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                au.Borrar(Entidad);
        }

        public void Exportar(DataGridView tabla)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            au.Guardar(Entidad);
            g.Mensaje("Usuario Guardado con exito", "!Atención",
            MessageBoxIcon.Information);
        }
        public void Actualizar(dynamic Entidad)
        {
            au.Actuailizar(Entidad);
            g.Mensaje("Usuario Actualizado con exito", "!Atención",
            MessageBoxIcon.Information);
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource =
                au.Mostrar(filtro).Tables["usuarios"];
            tabla.Columns.Insert(6, g.Boton(
                "Editar", Color.Green));
            tabla.Columns.Insert(7, g.Boton(
                "Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
    }
}
