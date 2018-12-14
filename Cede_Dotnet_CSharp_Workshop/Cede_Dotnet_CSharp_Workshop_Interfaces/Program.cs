using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Workshop_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escoge un Animal");
            Console.WriteLine("Gato, Perro");

            //Contruye el patrón factory en este punto
            //crea una enumeracion de los animales para gato perro
            //Factory debe recibir el tipo escogido por el cliente y devolver el objeto IAnimal
            //Agrega al menos 2 animales adicionales

            Console.ReadKey();
        }
    }
}
