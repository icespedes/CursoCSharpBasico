using Institucion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GESTION DE INSTITUCION");

            Persona[] lista = new Persona[3];
            lista[0] = new Alumno("Ignacio", "Cespedes")
            {
                Id = 1,
                Edad = 26,
                Teléfono = "71364790",
                Email = "b.ignacio.cespedes@gmail.com"
            };

            lista[1] = new Profesor()
            {
                Id = 2,
                Nombre = "Ignacio",
                Apellido = "Cespedes",
                Edad = 26,
                Teléfono = "71364790",
                Catedra = "Programación"
            };

            lista[2] = new Profesor()
            {
                Id = 2,
                Nombre = "William",
                Apellido = "Torvalds",
                Edad = 25,
                Teléfono = "71364911",
                Catedra = "Algebra"
            };

            Console.WriteLine(Persona.ContadorPersonas);
            Console.WriteLine("Resumenes");

            //Para cada persona p en la lista llama al metodo construirResumen
            foreach (Persona p in lista)
            {
                Console.WriteLine($"Tipo {p.GetType()}");
                Console.WriteLine($"{p.ConstruirResumen()}");
            }

            Console.ReadLine();

        }
    }
}
