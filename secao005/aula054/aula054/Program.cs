using System;
using System.Globalization;
namespace aula054 {
    class Program {
        static void Main(string[] args) {

            Produto p = new produto("tv", 500.00, 10);

            p.SetNome("TV 4K")

            Console.WriteLine(p.GetNome());
        }
    }
}