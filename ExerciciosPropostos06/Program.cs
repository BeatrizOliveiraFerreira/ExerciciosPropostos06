using System;
using System.Globalization;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');

            float a = float.Parse(vet[0], CultureInfo.InvariantCulture);
            float b = float.Parse(vet[1], CultureInfo.InvariantCulture);
            float c = float.Parse(vet[2], CultureInfo.InvariantCulture);

            float pi = 3.14159f;

            float areaDoTriangulo = a * c / 2f;
            float areaDoCirculoDeRaio = pi * c * c;
            float areaDoTrapezio = (a * b) * c / 2f;
            float areaDoquadrado = b * b;
            float areaDoRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areaDoTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaDoCirculoDeRaio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaDoTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaDoquadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaDoRetangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
