using Ejercicio1Array.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Array.Servicios
{
    internal interface OperacionalesInterfaz
    {
        /// <summary>
        /// Metodo que pide al usuario los valores necesarios para guardar un objeto en el array
        /// 12/12/2023 -> irodhan
        /// </summary>
        /// <param name="antiguaVajilla"></param>
        public void agregarElemento(VajillaDto[] antiguaVajilla);
    }
}
