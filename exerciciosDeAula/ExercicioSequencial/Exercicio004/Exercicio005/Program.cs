using System;
using System.Globalization;

namespace Exercicio005 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual o numero da primeira peça?");
            int codigo1 = int.Parse(Console.ReadLine());

            Console.WriteLine("quantas peças? ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("valor unitario da peça: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual o numero da segunda peça?");
            int codigo2 = int.Parse(Console.ReadLine());

            Console.WriteLine("quantas peças? ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("valor unitario da peça: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = (numero1 * valor1) + (numero2 * valor2);
            
            Console.WriteLine("Valor a pagar: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

