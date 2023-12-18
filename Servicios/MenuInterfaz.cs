using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Array.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra y pide al usuario la opcion que desea utilizar
        /// 12/12/2023 -> irodhan
        /// </summary>
        /// <returns>Devuelve la opcion seleccionada del usuario</returns>
        public int mostrarMenuYSeleccion();
    }
}
