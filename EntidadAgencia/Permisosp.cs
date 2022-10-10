using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadAgencia
{
    public class Permisosp
    {
        public Permisosp(int idpermisop, int fkidusuario, string permisos)
        {
            Idpermisop = idpermisop;
            Fkidusuario = fkidusuario;
            Permisos = permisos;
        }

        public int Idpermisop { get; set; }
        public int Fkidusuario { get; set; }
        public string Permisos { get; set; }
    }
}
