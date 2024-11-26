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
            //Escreva um programa que verifique se um número fornecido pelo usuário é positivo, negativo ou zero.

            int numero = 0;

            Console.Write("Informe um número: ");

            numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("Você digitou o número 0");
            } 
            else if (numero > 0)
            {
                Console.WriteLine("O seu número é positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O seu número é negativo");
            }

            //Escreva um programa que leia um mês do ano e informe quantos dias ele tem.

            int mes = 0;

            Console.WriteLine("Informe um mês: ");

            mes = int.Parse(Console.ReadLine());

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                Console.WriteLine("O mês que voce digitou tem 31 dias ");
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                Console.WriteLine("O mês que voce digitou tem 30 dias ");
            }
            else if (mes == 2)
            {
                Console.WriteLine("esse mês tem 28 dias ou 29"); 
            }

            //Faça um programa que leia a nota de um aluno e informe se ele está aprovado(nota maior ou igual a 7), em recuperação(nota entre 5 e 7) ou
            //reprovado (nota menor que 5).

            int nota = 0;
            Console.WriteLine("Digite qual foi sua nota: ");
            nota = int.Parse(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("Você esta aprovado: ");
            }
            else if (nota == 5 || nota == 6)
            {
                Console.WriteLine("Você esta em recuperação: ");
            }
            else if (nota < 5)
            {
                Console.WriteLine("Infelizmente você reprovou: ");
            }

            //Calcule a soma de todos os números de 1 a 100 utilizando um laço de repetição. //5050

            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }
            Console.WriteLine("A soma dos números de 1 a 100 é igual: " + soma);


            //Implemente uma contagem regressiva de 10 até 0 utilizando um laço de repetição.

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
           
            //Faça um programa que leia o nome de um aluno e suas três notas, calcule a média e informe se ele está aprovado(média maior ou igual a 7) ou
            //reprovado.

            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            float nota3 = float.Parse(Console.ReadLine());

            float media = (nota1 + nota2 + nota3) /3;

            Console.WriteLine("A media do aluno ("


        }
    }
}


