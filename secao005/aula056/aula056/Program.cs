using System;
using System.Globalization;
namespace aula056 {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("tv", 500.00, 10);

            p.Nome= "TV 4K";

            Console.WriteLine(p.Nome);
        }
    }
}