using System;
using System.Globalization;

namespace LerDados {
    class Program {
        static void Main(string[] args) {

            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Sálario bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(funcionario);

            Console.Write("Digite a porcentagem para aumentar o sálario: ");
            double aumentar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(aumentar);

            Console.WriteLine(funcionario);
        }
    }
}
