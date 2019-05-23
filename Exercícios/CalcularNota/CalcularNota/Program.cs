using System;
using System.Globalization;

namespace CalcularNota {
    class Program {
        static void Main(string[] args) {

            Aluno aluno = new Aluno();

            Console.Write("Nome: ");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Digite as notas do aluno");
            aluno.nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aluno.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final" + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado()) {
                Console.WriteLine("Aprovado ");
            }
            else {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram: " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + "Pontos");
            }

        }
    }
}
