using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Workshop_Interfaces.Animales
{
    public class Perro : IAnimal
    {
        public string Nombre { get; set; }
        public string Familia { get; set; }
        public string Clase { get; set; }

        public Perro()
        {
            Nombre = "Perro";
            Familia = "Cánidos";
            Clase = "Mamífero";
        }
    }
}
