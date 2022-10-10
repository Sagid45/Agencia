using ConectarBd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosAgencia
{
    public class AccesoProductos
    {
        Base b = new Base("Localhost", "root", "", "agenciauto", 3306);

        public void Borrar(dynamic Entidad)
        {
            b.comando(String.Format("call deleteProducto({0})",
                Entidad.Codigobarras));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("call insertProducto(" +
              "'{0}','{1}','{2}',{3})", Entidad.Nombre,
                  Entidad.Descripcion, Entidad.Marca, Entidad.Codigobarras));
        }
        public void Actuailizar(dynamic Entidad)
        {
            b.comando(string.Format("call updateProducto(" +
              "'{0}','{1}','{2}',{3})", Entidad.Nombre,
                  Entidad.Descripcion, Entidad.Marca, Entidad.Codigobarras));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
              (string.Format("call showProducto('{0}')",
                  filtro), "Productos");
        }
    }
}
