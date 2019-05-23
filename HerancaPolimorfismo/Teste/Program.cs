using System;
using System.Globalization;
using Teste.Entities;
namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digites os dados: ");

            Console.WriteLine("Vai cadastrar uma Pessoa ou um  funcionario?");
            string ler = Console.ReadLine();

            if ( ler == "Pessoa" || ler == "pessoa")
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Matrícula: ");
                int matricula = int.Parse(Console.ReadLine());
                Console.Write("Digite a data de nascimento");
                DateTime dataNasc = DateTime.Parse(Console.ReadLine());

                Cadastro cadastro = new Cadastro(nome, matricula, dataNasc);

                Console.Clear();
                Console.WriteLine(cadastro);
            }
            else if (ler == "funcionario" || ler == "Funcionario")
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o cargo do funcinario");
                string cargo = Console.ReadLine();
                Console.Write("Digite o salario: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Digite a matricula do funcionario: ");
                int matricula = int.Parse(Console.ReadLine());
                Console.Write("Digite a data de nascimento");
                DateTime dataNasc = DateTime.Parse(Console.ReadLine());

                Funcionario funcionario = new Funcionario(nome, matricula, dataNasc, cargo, salario);
                Console.Clear();

                Console.WriteLine(funcionario);
            }
            


        }
    }
}
