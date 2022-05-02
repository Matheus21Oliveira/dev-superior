/* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
decimais.*/

using System;
using System.Globalization;

namespace Exercicio004 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual número do funcionario? ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Qual tempo que este funcionario trabalhou? "); 
            int tempo = int.Parse(Console.ReadLine());

            Console.Write("Qual o valor que este funcionario recebe por hora? ");
            double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = tempo * horas;

            Console.WriteLine("Numero: " + numero);
            Console.WriteLine("Salario R$" + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

