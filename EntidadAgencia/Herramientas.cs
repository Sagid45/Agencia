using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadAgencia
{
    public class Herramientas
    {
        public Herramientas(long codigoherramienta, string nombre, double medida, string marca, string descripcion)
        {
            Codigoherramienta = codigoherramienta;
            Nombre = nombre;
            Medida = medida;
            Marca = marca;
            Descripcion = descripcion;
        }

        public long Codigoherramienta { get; set; }
        public string Nombre { get; set; } 
        public double Medida { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
    }
}
