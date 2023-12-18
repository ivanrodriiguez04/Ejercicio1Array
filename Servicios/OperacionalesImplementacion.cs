using Ejercicio1Array.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Array.Servicios
{
    internal class OperacionalesImplementacion : OperacionalesInterfaz
    {
        public void agregarElemento(VajillaDto[] antiguaVajilla)
        {
           for (int i = 0;i< antiguaVajilla.Length;i++) 
            {
                antiguaVajilla[i] = pedirInformacion();
            }
        }
        private VajillaDto pedirInformacion() 
        {
            VajillaDto vajilla = new VajillaDto();
            Console.WriteLine("Introduzca el id de la vajilla: ");
            vajilla.IdVajilla = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre de la vajilla: ");
            vajilla.NombreElemento = Console.ReadLine();
            vajilla.CodigoElemento = vajilla.IdVajilla + vajilla.NombreElemento;
            Console.WriteLine("Introduzca la descripcion del elemento: ");
            vajilla.DescripcionElemento = Console.ReadLine();
            Console.WriteLine("Introduzca la cantidad del elemento:");
            vajilla.CantidadElemento = Convert.ToInt32(Console.ReadLine());
            return vajilla;
        }
    }
}
