using System;
using System.Globalization;

namespace aula069 {
    class Program {
        static void Main(string[] args) {
            int numero = int.Parse(Console.ReadLine());

            double[] vetor = new double[numero];

            for (int i = 0; i < numero; i++) {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;

            for (int i = 0; i < vetor.Length; i++) {
                soma += vetor[i];
            }

            double media = soma / numero;

            Console.WriteLine("AVERAGE HEIGHT = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}