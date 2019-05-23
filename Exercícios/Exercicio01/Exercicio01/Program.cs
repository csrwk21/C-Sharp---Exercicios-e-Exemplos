using System;

namespace Exercicio01 {
    class Program {
        static void Main(string[] args) {

            Pessoas pessoa = new Pessoas();
            Pessoas pessoa1 = new Pessoas();

            Console.WriteLine("Digite os dados da primeiro pessoa: ");
            pessoa.nome = Console.ReadLine();
            pessoa.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados da segunda pessoa: ");
            pessoa1.nome = Console.ReadLine();
            pessoa1.idade = int.Parse(Console.ReadLine());

            if(pessoa.idade > pessoa1.idade) {
                Console.WriteLine(pessoa.nome+" é mais velha");
            }
            else {
                Console.WriteLine(pessoa1.nome+" é mais velha");
            }


        }
    }
}
