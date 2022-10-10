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
    public class ManejadorPermisosp
    {
        AccesoPermisosp app = new AccesoPermisosp();
        AccesoUsuarios au = new AccesoUsuarios();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format("¿Está seguro de borrar los permisos {0}",
                Entidad.Idpermisoh),
                "!Atención", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                app.Borrar(Entidad);
        }

        public void Exportar(DataGridView tabla)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            app.Guardar(Entidad);
            g.Mensaje("Permisos de Productos Guardados con exito", "!Atención",
            MessageBoxIcon.Information);
        }
        public void Actualizar(dynamic Entidad)
        {
            app.Actuailizar(Entidad);
            g.Mensaje("Permisos de Productos Actualizados con exito", "!Atención",
            MessageBoxIcon.Information);
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource =
                app.Mostrar(filtro).Tables["permisosp"];
            tabla.Columns.Insert(3, g.Boton(
                "Editar", Color.Green));
            tabla.Columns.Insert(4, g.Boton(
                "Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
        public void ExtaerUsuario(ComboBox caja)
        {
            caja.DataSource = au.Mostrar("").Tables["usuarios"];
            caja.DisplayMember = "Nombre";
            caja.ValueMember = "Fkidusuario";
        }
    }
}
