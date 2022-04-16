using System;
using System.Globalization;

namespace secao004 {
    class aula046 {
        static double pi = 3.14;
        public static void Main(String[] args) {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circulo = circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + circulo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de pi: " + pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double circunferencia(double raio) {
            return 2 * pi * raio;
        }

        static double Volume(double raio) {
            return 4.0 / 3.0 * pi * raio * raio * raio;
        }
    }
}

