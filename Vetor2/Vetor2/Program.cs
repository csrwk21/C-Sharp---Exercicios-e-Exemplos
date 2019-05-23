using System;
using System.Globalization;

namespace Vetor2 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for(int i= 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                vect[i] = new Produto { Nome = name, Preco = price };
            }

            double soma = 0.0;

            for(int i =0; i < n; i++) {
                soma += vect[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine("preço medio = "+media.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
