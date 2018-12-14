using System;
using System.Collections.Generic;
using System.Text;

namespace Cede_Dotnet_Csharp_Workshop_UnitTest
{
    public class Operaciones
    {
        public double Doble(double numero)
        {
            return numero * 2;
        }

        public double Triple(double numero)
        {
            return numero * 3;
        }

        public double RaizCuadrada(double numero)
        {            
            return Math.Sqrt(numero);
        }

        public double Logaritmo(double numero)
        {
            return Math.Log(numero);
        }

        public double Logaritmo10(double numero)
        {
            return Math.Log10(numero);
        }

        public double Exponencial(double numero)
        {
            return Math.Exp(numero);
        }
    }
}
