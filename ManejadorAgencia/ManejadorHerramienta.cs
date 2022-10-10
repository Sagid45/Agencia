using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud;
using AccesoDatosAgencia;
using System.Windows.Forms;
using System.Drawing;

namespace ManejadorAgencia
{
    public class ManejadorHerramienta : IManejador
    {
        AccesoHerramientas ah = new AccesoHerramientas();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format("¿Está seguro de borrar {0}",
                Entidad.Nombre),
                "!Atención", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                ah.Borrar(Entidad);
        }

        public void Exportar(DataGridView tabla)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            ah.Guardar(Entidad);
            g.Mensaje("Herramienta Agregada con exito", "!Atención",
            MessageBoxIcon.Information);
        }
        public void Actualizar(dynamic Entidad)
        {
            ah.Actuailizar(Entidad);
            g.Mensaje("Herramienta Actualizada con exito", "!Atención",
            MessageBoxIcon.Information);
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource =
                ah.Mostrar(filtro).Tables["herramientas"];
            tabla.Columns.Insert(5, g.Boton(
                "Editar", Color.Green));
            tabla.Columns.Insert(6, g.Boton(
                "Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
        
    }
}
