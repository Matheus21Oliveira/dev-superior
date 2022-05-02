/* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
mensagem explicativa: */

using System;

namespace Exercicio001 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Escolha um valor: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Escolha outro valor: ");
            int numero2 = int.Parse(Console.ReadLine());

            int soma = numero1 + numero2;

            Console.WriteLine("Soma = " + soma);
        }
    }
}


