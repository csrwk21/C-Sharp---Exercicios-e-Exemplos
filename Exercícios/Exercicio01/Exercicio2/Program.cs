using System;
using System.Globalization;

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {

            Funcionarios funcionario = new Funcionarios();
            Funcionarios funcionario2 = new Funcionarios();

            Console.WriteLine("Digite os dados do primeiro funcionario: ");
    
            funcionario.nome = Console.ReadLine();
          
            funcionario.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados do segundo funcionario: ");
           
            funcionario2.nome =(Console.ReadLine());
            Console.Write("Sálario: ");
            funcionario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double medSalario = (funcionario.salario + funcionario2.salario) / 2;


            Console.WriteLine("Sálario médio é: " +medSalario.ToString("F4"),CultureInfo.InvariantCulture);

        }
    }
}
