using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
using System.Data;

namespace AccesoDatosAgencia
{
    public class AccesoHerramientas
    {
        Base b = new Base("Localhost", "root", "", "agenciauto", 3306);

        public void Borrar(dynamic Entidad)
        {
            b.comando(String.Format("call deleteHerramienta({0})",
                Entidad.codigoherramienta));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("call insertHerramienta(" +
              "'{0}',{1},'{2}','{3}',{4})", Entidad.Nombre,
                  Entidad.Medida, Entidad.Marca, Entidad.Descripcion, Entidad.Codigoherramienta));
        }
        public void Actuailizar(dynamic Entidad)
        {
            b.comando(string.Format("call updateHerramienta(" +
              "'{0}',{1},'{2}','{3}',{4})", Entidad.Nombre,
                  Entidad.Medida, Entidad.Marca, Entidad.Descripcion, Entidad.Codigoherramienta));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
              (string.Format("call showHerramienta('%{0}%')",
                  filtro), "Herramientas");
        }
    }
}
