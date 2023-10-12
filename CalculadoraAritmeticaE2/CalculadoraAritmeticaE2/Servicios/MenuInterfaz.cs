using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmeticaE2.Servicios
{
    /// <summary>
    /// Menu Interfaz con la redacción de los distintos métodos
    /// 09102023 - ebp
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra el menu de seleccion de la aplicación
        /// 09102023 - ebp
        /// </summary>
        /// <returns></returns>
        public int MenuCalculadora();

        /// <summary>
        /// Método que describe la funcionalidad Suma
        /// 09102023 - ebp
        /// </summary>
        public void SumaMenuCalculadora();

        /// <summary>
        /// Método que describe la funcionalidad Resta
        /// 09102023 - ebp
        /// </summary>

        public void RestaMenuCalculadora();

        /// <summary>
        /// Método que define la funcionalidad Multiplicacion
        /// 09102023 - ebp
        /// </summary>

        public void MultiplicacionMenuCalculadora();

        /// <summary>
        /// Método que defina la funcionalidad División
        /// 09102023 - ebp
        /// </summary>

        public void DivisionMenuCalculadora();
    }
}
