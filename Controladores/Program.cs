using Ejercicio1Array.Dtos;
using Ejercicio1Array.Servicios;

namespace Ejercicio1Array.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 12/12/2023 -> irodhan
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// 12/12/2023 -> irodhan
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        {
            MenuInterfaz mI = new MenuImplementacion();
            OperacionalesInterfaz oI = new OperacionalesImplementacion();
            VajillaDto[] nuevaVajilla = new VajillaDto[5];

            //Atributos
            int opcionSeleccionada = 0;
            bool cerrarMenu=false;

            while(!cerrarMenu) 
            {
                opcionSeleccionada = mI.mostrarMenuYSeleccion();

                switch( opcionSeleccionada ) 
                { 
                    case 0:
                        Console.WriteLine("[INFO] -  Ha seleccionado la opción 0");
                        Console.WriteLine("[INFO] -  Se va ha cerrar el menú");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Ha seleccionado la opción 1");
                        oI.agregarElemento(nuevaVajilla);
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opción seleccionada no coincide con ninguna opción");
                        break;
                }
            }
        }
    }
}