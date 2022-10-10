using ConectarBd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosAgencia
{
    public class AccesoPermisosh
    {
        Base b = new Base("Localhost", "root", "", "agenciauto", 3306);

        public void Borrar(dynamic Entidad)
        {
            b.comando(String.Format("call deletePermisosh({0})",
                Entidad.Idpermisoh));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("call insertPermisosh(" +
              "{0},'{1}',{2})", Entidad.Fkidusuario,
                  Entidad.Permisos, Entidad.Idpermisoh));
        }
        public void Actuailizar(dynamic Entidad)
        {
            b.comando(string.Format("call updatePermisosh(" +
              "{0},'{1}',{2})", Entidad.Fkidusuario,
                  Entidad.Permisos, Entidad.Idpermisoh));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
              (string.Format("call showPermisosh({0})",
                  filtro), "Permisos de Herramientas");
        }
    }
}
