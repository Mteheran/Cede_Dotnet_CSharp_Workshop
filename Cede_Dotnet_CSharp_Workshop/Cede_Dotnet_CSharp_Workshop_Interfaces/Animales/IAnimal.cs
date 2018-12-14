using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Workshop_Interfaces.Animales
{
    public interface IAnimal
    {
        string Nombre { get; set; }
        string Familia { get; set; }
        string Clase { get; set; }
    }
}
