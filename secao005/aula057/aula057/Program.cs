using System;
using System.Globalization;
namespace aula057 {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("tv", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}

