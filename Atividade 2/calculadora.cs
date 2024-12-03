using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    internal class calculadora
    {
        public int Somar(int numero1, int numero2)
        {
            int resultado = 0;

            resultado = numero1 + numero2;

            return resultado;
        }
        public int Subtrair(int numero1, int numero2)
        {
            int resultado = 0;

            resultado = numero1 - numero2;

            return resultado;
        }
        public int Multiplicar(int numero1, int numero2)
        {
            int resultado = 0;

            resultado = numero1 * numero2;

            return resultado;
        }
        public double Divisão(double numero1, double numero2)
        {
            double resultado = 0;

            resultado = numero1 / numero2;

            return resultado;
        }
    }
}
    

