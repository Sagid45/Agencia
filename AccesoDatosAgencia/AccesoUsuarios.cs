using ConectarBd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosAgencia
{
    public class AccesoUsuarios
    {
        Base b = new Base("Localhost", "root", "", "agenciauto", 3306);

        public void Borrar(dynamic Entidad)
        {
            b.comando(String.Format("call deleteUsuarios({0})",
                Entidad.IdUsuario));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("call insertProducto(" +
              "'{0}','{1}','{2}','{3}','{4}',{5},'{6}')", Entidad.Nombre,
                  Entidad.ApellidoP, Entidad.ApellidoM, Entidad.FechaNacimiento,Entidad.RFC,Entidad.Contraseña, Entidad.IdUsuario));
        }
        public void Actuailizar(dynamic Entidad)
        {
            b.comando(string.Format("call updateUsuarios(" +
               "'{0}','{1}','{2}','{3}','{4}',{5},'{6}')", Entidad.Nombre,
                   Entidad.ApellidoP, Entidad.ApellidoM, Entidad.FechaNacimiento, Entidad.RFC, Entidad.Contraseña, Entidad.IdUsuario));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
              (string.Format("call showUsuarios('%{0}%')",
                  filtro), "Usuarios");
        }
    }
}
