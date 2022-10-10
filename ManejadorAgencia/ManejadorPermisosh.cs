using Crud;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosAgencia;

namespace ManejadorAgencia
{
    public class ManejadorPermisosh
    {
        AccesoPermisosh aph = new AccesoPermisosh();
        AccesoUsuarios au = new AccesoUsuarios();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format("¿Está seguro de borrar los permisos {0}",
                Entidad.Idpermisop),
                "!Atención", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                aph.Borrar(Entidad);
        }

        public void Exportar(DataGridView tabla)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            aph.Guardar(Entidad);
            g.Mensaje("Permisos de Productos Guardados con exito", "!Atención",
            MessageBoxIcon.Information);
        }
        public void Actualizar(dynamic Entidad)
        {
            aph.Actuailizar(Entidad);
            g.Mensaje("Permisos para Herramientas Actualizados con exito", "!Atención",
            MessageBoxIcon.Information);
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource =
                aph.Mostrar(filtro).Tables["permisosh"];
            tabla.Columns.Insert(3, g.Boton(
                "Editar", Color.Green));
            tabla.Columns.Insert(4, g.Boton(
                "Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
        public void ExtaerUsuario(ComboBox caja)
        {
            caja.DataSource = au.Mostrar("").Tables["usuarios"];
            caja.DisplayMember = "Usuario";
            caja.ValueMember = "fkidusuario";
        }
    }
}
