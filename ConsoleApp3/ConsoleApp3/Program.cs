using System;
using System.Globalization;
namespace ConsoleApp3 {
    class Program {
        static void Main(string[] args) {

            Aluno aluno = new Aluno();

            Console.Write("Digite o nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
         
            Aluno[] V = new Aluno[4];

            Console.Write("Digite as 4 notas do ALuno: ");

            for (int i = 0; i < 4;i++){                            
                double nota = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                V[i] = new Aluno { Nota = nota };
            }
            
            double soma = 0.0;

            for(int i = 0; i < 4; i++) {
                soma += V[i].Nota; 
            }

            double media = soma / 4;

            Console.WriteLine("Nome: " +aluno.Nome+ " A media é: "+media.ToString("F2"),CultureInfo.InvariantCulture);
        }
    }
}
