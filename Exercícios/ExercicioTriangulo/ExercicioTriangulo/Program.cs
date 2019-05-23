using System;
using System.Globalization;

namespace ExercicioRetangulo{
    class Program {
        static void Main(string[] args) {

            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Digite a Largura e Altura do retângulo: ");
            retangulo.largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            retangulo.altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Area:"+retangulo.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: "+retangulo.Diagonal().ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
