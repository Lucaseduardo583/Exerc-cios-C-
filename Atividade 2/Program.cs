using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicios exer = new Exercicios();
            //exer.Resultados();


            //Menu de escolha..

            Console.WriteLine("Escolha uma operação: ");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.Write("Digite o número da operação desejada (1/2/3/4): ");

            //Perguntar os números
            //mensagem bonita de retorno


            calculadora calc = new calculadora();

            double resul = calc.Somar(7, 8);
            Console.WriteLine($"soma: {resul}");

            resul = calc.Subtrair(17, 7);
            Console.WriteLine($"subtrair: {resul}");

            resul = calc.Multiplicar(10, 7);
            Console.WriteLine($"multiplicacar: {resul}");

            resul = calc.Divisão(50, 10);
            Console.WriteLine(resul.ToString("F"));

            Console.Write("press Enter...");
            Console.ReadKey();

        }
    }
}  


