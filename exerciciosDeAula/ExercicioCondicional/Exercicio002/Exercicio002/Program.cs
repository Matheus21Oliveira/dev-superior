using System;

namespace Exercicio002 {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Insira um número pra dizer se é impar ou par");
            int numero = int.Parse(Console.ReadLine());

            if (numero%2 == 0) {
                Console.WriteLine("PAR");
            } else {
                Console.WriteLine("IMPAR");
            }
        }
    }
}