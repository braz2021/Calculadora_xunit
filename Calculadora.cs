using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora.xunit
{
    public class Calculadora
    {
        public double num1 { get; set; }
        public double num2 {get; set; }
        public double resultado { get; set ;}

        public void Somar()
        {
           resultado = num1 + num2;  
        }

        public void Subtrair()
        {
            resultado = num1 - num2;
        }

        public void Multiplicar()
        {
            resultado = num1 * num2;
        }
        public void Dividir()
        {
            resultado = num1 / num2;
        }
    }
}