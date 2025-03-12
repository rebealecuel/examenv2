using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenv2
{
    internal class Program
    {
        public enum Menun
        {
            Agregar = 1, mostrar, contar, eliminar, actualizar, salir
        }
        static void Main(string[] args)
        {
            while (true)
            {
                switch (Menu())
                {
                    case Menun.Agregar:

                        break;
                    case Menun.mostrar:

                        break;
                    case Menun.contar:

                        break;
                    case Menun.eliminar:

                        break;
                    case Menun.actualizar:

                        break;
                    case Menun.salir:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opcion no encontrada");
                        break;
                }
            }
        }
        static Menun Menu()
        {
            Console.WriteLine("1) Agregar");
            Console.WriteLine("2) Mostrar");
            Console.WriteLine("3) Contar");
            Console.WriteLine("4) Eliminar");
            Console.WriteLine("5) Actualizar");
            Console.WriteLine("6) Salir");
            Menun opc = (Menun)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
