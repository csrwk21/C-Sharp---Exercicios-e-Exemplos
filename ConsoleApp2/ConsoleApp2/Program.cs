using System;
using System.Globalization;

namespace ConsoleApp2 {
    class Program {
        static void Main(string[] args) {

            double A, B, C;
            double Pi = 3.14159;

            string[] vet = Console.ReadLine().Split(' ');
         
            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);

            double AreaTriangulo = (A * C) / 2;
            double AreaCirculo = Math.Pow(C, 2) * Pi ;
            double AreaTrapezio = (A + B) * C / 2;
            double AreaQuadrado = B * B;
            double AreaRetangulo = A * B;

            Console.WriteLine("TRIANGULO: " + AreaTriangulo.ToString("F3"));
            Console.WriteLine("CICULO: " + AreaCirculo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + AreaTrapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + AreaQuadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + AreaRetangulo.ToString("F3"));

        }
    }
}