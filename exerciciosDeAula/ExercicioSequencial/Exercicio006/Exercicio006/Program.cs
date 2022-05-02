using System;
using System.Globalization;

namespace Exercicio006 {
    class Program {
        public static void Main(string[] args) {
            double pi = 3.14159;
            
            Console.Write("Insira o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Insira o segundo valor: "); 
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Insira o terceiro valor: ");
            double valor3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double triangulo = (valor1 * valor3) / 2;

            double circulo = pi * Math.Pow (valor3, 2);

            double trapezio = ((valor1 + valor2) * valor3) / 2;

            double quadrado = Math.Pow (valor2 , 2);

            double retangulo = valor1 * valor2;

            Console.WriteLine("Triangulo: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retangulo: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

