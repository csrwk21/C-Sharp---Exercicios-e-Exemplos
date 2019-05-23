using System;

namespace Verctors {
    class Program {
        static void Main(string[] args) {

            Pessoa[] vetor = new Pessoa[10];

            Console.Write("Quantos nomes deseja cadastrar? ");
            int NumeroPessoa = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumeroPessoa; i++) {
                Console.Write("Digite o nome: ");
                String nome = Console.ReadLine();
                Console.Write("Digite a idade: ");
                int idade = int.Parse(Console.ReadLine());

                vetor[i] = new Pessoa(nome, idade);
            }

            for (int i = 0; i < 10; i++) {
                if (vetor[i] != null) {
                    Console.WriteLine("Dados: " + vetor[i]);
                }
            }

            Console.WriteLine("Deseja mostrar a media de idade das pessoas cadastradas? s/n");
            Char car = char.Parse(Console.ReadLine());

            if (car == 's' || car == 'S') {
                int soma = 0;
                for (int i = 0; i < NumeroPessoa; i++) {
                    soma += vetor[i].Idade;
                }

                int media = soma / NumeroPessoa;

                Console.WriteLine("A media de idade entre as pessoas cadastradas é de: " + media);
            }

            else {
                Console.Clear();
                Console.WriteLine("----------------Dados cadastrados----------------- ");
                for (int i = 0; i < 10; i++) {
                    if (vetor[i] != null) {

                        Console.WriteLine("Dados: " + vetor[i]);
                    }
                }
            }
        }
    }
}
