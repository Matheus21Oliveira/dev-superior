using System;
using System.Globalization;

namespace aula042 {
    public static class Program {
        static void Main(string[] args) {

            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto");
            
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade em estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + produto);
        }
    }
}