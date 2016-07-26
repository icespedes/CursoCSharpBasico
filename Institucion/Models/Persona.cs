using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion.Models
{
    public abstract class Persona
    {
        public static int ContadorPersonas = 0;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public short Edad { get; set; }
        public string Teléfono { get; set; }
        protected int Inasistencias { get; set; }
        public virtual string NombreCompleto
        {
            get
            {
                return $"{Nombre} {Apellido}"; //String Literals $  || Otra forma es return string.format("{0} {1}", Nombre, Apellido).
            }
        }

        public Persona()
        {
            ContadorPersonas++; //es igual que escribir ContadorPersonas = ContadorPersonas + 1 || ContadorPersonas += 1
        }

        public abstract string ConstruirResumen();
    }
}
