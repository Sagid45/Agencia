using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EntidadAgencia
{
    public class Usuarios
    {
        public Usuarios(int idUsuario, string nombre, string apellidoP, string apellidoM, string fechaNacimiento, string rFC)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            FechaNacimiento = fechaNacimiento;
            RFC = rFC;
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string FechaNacimiento { get; set; }
        public string RFC { get; set; }
    }
}
