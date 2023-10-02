using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorHorasConsola.Servicios
{
    /// <summary>
    /// Controlador de horas que implementa a Menu Interfaz (IMPLEMENTACION DE LA INTERFAZ)
    /// 26092023 - ebp
    /// </summary>
    
    internal class MenuImplementacion : MenuInterfaz 
    {

        public void mensajeBienvenida()
        {
            String mensaje = "Controlador de horas de Edu Ballesteros";
            Console.WriteLine(mensaje);

        }


        int MenuInterfaz.mostrarSeleccionarMenu()
        {
            int opcionSeleccionadaMenu;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("0. Cerrar aplicación");
            Console.WriteLine("1. Crear usuario");
            Console.WriteLine("2. Registro de horas");
            Console.WriteLine("3. Cantidad de horas");
            Console.WriteLine("4. Comparación de horas");
            Console.WriteLine("5. Historial de juego");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Seleccione una opción:     ");

            //Guardamos la respuesta del usuario(ReadKey - Solo lee un cáracter)
            //KeyChar (Guarda la primera tecla que pulse el usuario)

            opcionSeleccionadaMenu = Console.ReadKey(true).KeyChar - ('0');
            return opcionSeleccionadaMenu;
        }
    }

    
    
}
