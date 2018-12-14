using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Orderne el siguiente código y utilice las mejoras de C# para simplificarlo
             * PISTAS: String interpolation y out variables son requeridas
            */
            while (true)
            {
                Console.WriteLine("  ");
                Console.WriteLine("Escoja el tipo de operación");
                Console.WriteLine("S=Sumar , M = Multiplicar");

                string operacion = Console.ReadLine();

                Console.WriteLine("Ingrese Numero 1");

                int numero1 = 0;
                int.TryParse(Console.ReadLine(), out numero1);


                Console.WriteLine("Ingrese Numero 2");

                int numero2 = 0;
                int.TryParse(Console.ReadLine(), out numero2);

                int resultado = 0;

                switch (operacion.ToUpper())
                {
                    case "M":
                        resultado = numero1 * numero2;
                        break;
                    case "S":
                        resultado = numero1 + numero2;
                        break;
                    default:
                        continue;
                }

                Console.WriteLine("el resultado es " + resultado);


                Console.ReadKey();

            }           
        }
    }
}
