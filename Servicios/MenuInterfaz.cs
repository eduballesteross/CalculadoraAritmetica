using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorHorasConsola.Servicios
{
    /// <summary>
    /// Interfaz que redacta los distintos métodos de la funcionalidad del menú
    /// 26092023 - ebp
    /// </summary>
    internal interface MenuInterfaz
    {

        /// <summary>
        /// Método que muestra un mensaje de bienvenida al programa
        /// 021023 - ebp
        /// </summary>


        public void mensajeBienvenida();

        /// <summary>
        /// Método que muestra las diferentes opciones del programa
        /// 26092023 - ebp
        /// </summary>

        public int mostrarSeleccionarMenu();
    }
}
