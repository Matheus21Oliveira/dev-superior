using System;

namespace Exercicio003 {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Me dê o primeiro número pra ver se é multiplo: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Me dê o segundo número pra ver se é multiplo: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 % numero2 == 0 || numero2 % numero1 == 0) {
                Console.WriteLine("Multiplo");
            }
            else {
                Console.WriteLine("Não Multiplo");
            }
        }
    }
}