using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.models
{
    public class Calculadorafinal
    {
        public void Somar(double num1, double num2)
        {
            double resultado = num1 + num2;
            Console.WriteLine($"O resultado de {num1} + {num2} é {resultado}");
        }
        public void Subtrair(double num1, double num2)
        {
            double resultado = num1 - num2;
            Console.WriteLine($"O resultado de {num1} - {num2} é {resultado}");
        }
        public void Multiplicar(double num1, double num2)
        {
            double resultado = num1 * num2;
            Console.WriteLine($"O resultado de {num1} X {num2} é {resultado}");
        }
        public void Dividir(double num1, double num2)
        {
            double resultado = num1 / num2;
            Console.WriteLine($"O resultado de {num1} divido por {num2} é {resultado}");
        }
        public void Potencia(double num1, double num2)
        {
            double resultado = Math.Pow(num1, num2);
            Console.WriteLine($"A potência de {num1} por {num2} é {resultado}");
        }
    }
}