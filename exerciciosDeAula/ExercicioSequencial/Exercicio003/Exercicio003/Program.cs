using System;

namespace Exercicio003 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o quarto valor: ");
            int valor4 = int.Parse(Console.ReadLine());

            int diferença = (valor1 * valor2 - valor3 * valor4);

            Console.WriteLine("Diferença = " + diferença);
        }
    }
}

