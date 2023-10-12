using CalculadoraAritmeticaE2.Servicios;

namespace CalculadoraAritmeticaE2.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 09102023 - ebp
    /// </summary>

    internal class Program
    {
        /// <summary>
        /// Método de entrada de la aplicación
        /// 09102023 - ebp
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            MenuInterfaz menuI =  new MenuImplementacion();


            bool cerrarMenu = false;
            int seleccionMenuP;

            while (!cerrarMenu)
            {

                seleccionMenuP = menuI.MenuCalculadora();
                Console.WriteLine(seleccionMenuP);

                switch (seleccionMenuP)
                {
                    case 0:
                        Console.WriteLine("[INFO] Se cerrará la aplicación");
                        cerrarMenu = true; break;

                    case 1:
                        Console.WriteLine("Has seleccionado la opcion de Sumar");
                        menuI.SumaMenuCalculadora();
                        break;

                    case 2:
                        Console.WriteLine("Has seleccionado la opcion de Restar");
                        menuI.RestaMenuCalculadora();
                        break;

                    case 3:
                        Console.WriteLine("Has seleccionado la opcion de Multiplicar");
                        menuI.MultiplicacionMenuCalculadora();
                        break;

                    case 4:
                        Console.WriteLine("Has seleccionado la opcion de Dividir");
                        menuI.DivisionMenuCalculadora();
                        break;
                }

            }


        }

    }


}
