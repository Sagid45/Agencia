using ConectarBd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosAgencia
{
    public class AccesoPermisosp
    {
        Base b = new Base("Localhost", "root", "", "agenciauto", 3306);

        public void Borrar(dynamic Entidad)
        {
            b.comando(String.Format("call deletePermisosp({0})",
                Entidad.Idpermisop));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("call insertPermisosp(" +
              "{0},'{1}',{2})", Entidad.Fkidusuario,
                  Entidad.Permisos, Entidad.Idpermisop));
        }
        public void Actuailizar(dynamic Entidad)
        {
            b.comando(string.Format("call updatePermisosp(" +
              "{0},'{1}',{2})", Entidad.Fkidusuario,
                  Entidad.Permisos, Entidad.Idpermisop));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
              (string.Format("call showPermisosp({0})",
                  filtro), "Permisos de Productos");
        }
    }
}
