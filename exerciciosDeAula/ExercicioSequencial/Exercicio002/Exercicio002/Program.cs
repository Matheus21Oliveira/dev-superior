/* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
casas decimais */

using System;
using System.Globalization;

namespace Exercicio002 {
    class Program {
        static void Main(string[] args) {
            double pi = 3.14159; 
            
            Console.WriteLine("Insira o raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}    
