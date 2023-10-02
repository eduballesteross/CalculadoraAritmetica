using ContadorHorasConsola.Servicios;

namespace ContadorHorasConsola.Controladores
{

    /// <summary>
    /// Clase principal de la aplicación ContadorHorasConsola (CLASE PRINCIPAL)
    /// 260923- ebp
    /// </summary>
    
    internal class Program
    {
        /// <summary>
        /// Clase principal de la aplicación ContadorHorasConsola (MAIN)
        /// 260923- ebp
        /// </summary>
        /// 



        public static void Main(string[] args)
        {

            MenuInterfaz menuI = new MenuImplementacion();
            menuI.mensajeBienvenida();


            /// Variable que controla el while
            bool cerrarMenu = false;

            //Variable del usuario

            int opcionSeleccion;

            //iniciamos el while

            while (!cerrarMenu) 
            {

                opcionSeleccion = menuI.mostrarSeleccionarMenu();
                Console.WriteLine(opcionSeleccion);

                switch (opcionSeleccion)

                {
                    case 0:
                        Console.WriteLine("INFO-- Se ejecuta caso 0");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("INFO-- Se ejecuta caso 1");
                        break;

                    case 2:
                        Console.WriteLine("INFO-- Se ejecuta caso 2");
                        break;

                    case 3:
                        Console.WriteLine("INFO-- Se ejecuta caso 3");
                        break;

                    case 4:
                        Console.WriteLine("INFO-- Se ejecuta caso 4");
                        break;

                    case 5:
                        Console.WriteLine("INFO-- Se ejecuta caso 5");
                        break;

                    default:

                        Console.WriteLine("[INFO] - La opción seleccionada no coincide");
                        break;
                }

                }
        }

    }



}
