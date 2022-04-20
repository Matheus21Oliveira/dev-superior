using System;
using System.Globalization;
namespace aula070 {
    class Program {
        static void Main(string[] args) {
            int numero = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[numero]; 

            for (int i = 0; i < numero; i++) {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vetor[i] = new Produto { Nome = nome, Preco = preco };

            }

            double soma = 0;

            for (int i = 0; i < numero; i++) {
                soma += vetor[i].Preco;
            }

            double media = soma / numero;

            Console.WriteLine("AVERAGE PRICE = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}