using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenv2
{
    internal class acciones
    {
        public List<peliculas> pelicas = new List<peliculas>();

        peliculas p = new peliculas();

        public void agregarpeli()
        {
            Console.WriteLine("Nombre");
            p.Nombre = Console.ReadLine();
            Console.WriteLine("Año de lanzamiento");
            p.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Compañia");
            p.Acompañia = Console.ReadLine();
            Console.WriteLine("¿Cuantos premios gano?");
            p.Premios = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tema de la pelicula");
            p.Tema = Console.ReadLine();

            pelicas.Add(new peliculas(p.Nombre, ));
        }
    }
}
