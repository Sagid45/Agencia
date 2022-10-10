using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosAgencia
{
    public interface IEntidades
    {
        void Guardar(dynamic Entidad);
        void Borrar(dynamic Entidad);
        void Actualizar(dynamic Entidad);
        DataSet Mostrar(string filtro);
    }
}
