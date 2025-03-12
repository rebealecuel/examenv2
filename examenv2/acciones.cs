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

            pelicas.Add(new peliculas(p.Nombre, p.Año, p.Acompañia, p.Premios, p.Tema));
        }

        public void Mostarte()
        {
            foreach(var p in pelicas)
            {
                Console.WriteLine($"Nombre: {p.Nombre}");
                Console.WriteLine($"Año de lanzamiento:{p.Año}");
                Console.WriteLine($"Su compañia es:{p.Acompañia}");
                Console.WriteLine($"Premios otorgados:{p.Premios}");
                Console.WriteLine($"Tema:{p.Tema}");
            }
        }

        public int COntar()
        {
            Console.WriteLine("Numero de peliculas:");
            return pelicas.Count; 
        }

        public void Elimina(string nombrepeli)
        {
            var peli = pelicas.Find(x => x.Nombre == nombrepeli);
            if ( peli != null )
                pelicas.Remove(peli);
            else
                Console.WriteLine("No se encontro la pelicula");
        }
        
        public void Actuli(string nombrepeli)
        {
            var peli = pelicas.Find(x => x.Nombre == nombrepeli);
            if (peli != null)
            {
                Console.WriteLine("Nuevo nombre");
                peli.Nombre = Console.ReadLine();
                Console.WriteLine("Año");
                peli.Año = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Compañia");
                peli.Acompañia = Console.ReadLine();
                Console.WriteLine("Nueva cantidad");
                peli.Premios = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Tema de la pelicular");
                peli.Tema = Console.ReadLine();

                Console.WriteLine("Pelicula actualizada con exito");
            }
            else
                Console.WriteLine("No se encontro la pelicula");
        }
    }
}
