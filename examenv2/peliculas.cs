using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenv2
{
    internal class peliculas
    {
        public peliculas() { }

        public peliculas(string nombre, int año, string acompañia, int premios, string tema)
        {
            Nombre = nombre;
            Año = año;
            Acompañia = acompañia;
            Premios = premios;
            Tema = tema;
        }

        public string Nombre { get; set; }
        public int Año { get; set; }
        public string Acompañia { get; set; }
        public int Premios { get; set; }
        public string Tema { get; set; }
    }
}
