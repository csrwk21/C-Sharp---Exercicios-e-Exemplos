using System;
using System.Globalization;
namespace CondicionalTernaria {
    class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());

            string testando = (x < 10) ? "menor que 10" : "maior que 10";

            Console.WriteLine(testando);

            Console.WriteLine("Digite o preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double deconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine("O desconto é de: "+deconto);


        }
    }
}
