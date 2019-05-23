using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            ConversorDeMoeda conversor = new ConversorDeMoeda();

            Console.WriteLine("Qual a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares deseja comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Valor a ser pago: "+ConversorDeMoeda.ConverterMoeda(quantidade, cotacao).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
