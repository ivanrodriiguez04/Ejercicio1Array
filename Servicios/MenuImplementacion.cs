using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Array.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion = 0;

            Console.WriteLine("        Menu        ");
            Console.WriteLine("--------------------");
            Console.WriteLine("0. Cerrar App       ");
            Console.WriteLine("1. Añadir elemento  ");
            Console.WriteLine("--------------------");
            Console.WriteLine("\n");
            Console.WriteLine("¿Qué opción desea utilizar?");
            opcion=Convert.ToInt32(Console.ReadLine()); 
            return opcion;
        }
    }
}
