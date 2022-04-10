using System;
using System.Globalization;

namespace aula044 {
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

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionados ao estoque: ");
            int estoque = int.Parse(Console.ReadLine());

            produto.AdicionarProdutos(estoque);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            estoque = int.Parse(Console.ReadLine());

            produto.RemoverProdutos(estoque);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);
          
        }
    }
}