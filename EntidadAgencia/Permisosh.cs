using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadAgencia
{
    public class Permisosh
    {
        public Permisosh(int idpermisoh, int fkidusuario, string permisos)
        {
            Idpermisoh = idpermisoh;
            Fkidusuario = fkidusuario;
            Permisos = permisos;
        }

        public int Idpermisoh { get; set; }
        public int Fkidusuario { get; set; }
        public string Permisos { get; set; }
    }
}
