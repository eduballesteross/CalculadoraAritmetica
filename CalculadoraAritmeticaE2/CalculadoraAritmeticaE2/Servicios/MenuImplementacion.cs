using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmeticaE2.Servicios
{
    /// <summary>
    /// Implementacion al MenuInterfaz
    /// 09102023 - ebp
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int  MenuCalculadora()
        {
            int seleccionMenu;

            Console.WriteLine("##################################");
            Console.WriteLine("0.Cerrar");
            Console.WriteLine("1.Suma");
            Console.WriteLine("2.Resta");
            Console.WriteLine("3.Multiplicación");
            Console.WriteLine("4.División");
            Console.WriteLine("Elija una opción:");
            Console.WriteLine("##################################");

            seleccionMenu = Console.ReadKey(true).KeyChar - ('0');
            return seleccionMenu;



        }

        public void SumaMenuCalculadora()
        {
            Console.Clear();    

            int sumauno;
            int sumados;

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Introduzca el primer operando: ");
            sumauno = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Introduzca el segundo operando: ");
            sumados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El resultado de la suma de " + sumauno + " + " + sumados + " es " + (sumauno + sumados));

            Console.WriteLine("---------------------------------");

        }

         public void RestaMenuCalculadora()
        {
            Console.Clear();

            int restauno;
            int restados;

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Introduzca el primer operando: ");
            restauno = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Introduzca el segundo operando: ");
            restados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El resultado de " + restauno + " - " + restados + " es " + (restauno - restados));

            Console.WriteLine("---------------------------------");

        }


        public void MultiplicacionMenuCalculadora()
        {
            Console.Clear() ;

            int multiplicando;
            int multiplicador;

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Introduzca el multiplicando: ");
            multiplicando = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el multiplicador");
            multiplicador = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El resultado de " + multiplicando + " por " + multiplicador + " es " + (multiplicando * multiplicador));
            Console.WriteLine("---------------------------------");
        }

        public void DivisionMenuCalculadora()
        {
            Console.Clear() ;
            float dividendo;
            float divisor;

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Introduzca el dividendo: ");
            dividendo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el divisor: ");
            divisor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El resultado de " + dividendo + " / " + divisor + " es " + (dividendo / divisor) + " con resto " + (dividendo%divisor));
            Console.WriteLine("---------------------------------");



        }

        
    }
}
