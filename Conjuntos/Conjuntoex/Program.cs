using System;
using System.Collections.Generic;

namespace Conjuntoex {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.WriteLine("Quantos números deseja registrar em A? ");
            int qtdNumerosA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os numeros que deseja registrar em A: ");
            for(int i = 0;i< qtdNumerosA; i++) {
                int ler = int.Parse(Console.ReadLine());
                A.Add(ler);
            }

            Console.WriteLine("Quantidade de números que deseja registrar em B? ");
            int qtdNumerosB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os números que deseja registrar em B: ");
            for (int i = 0; i < qtdNumerosB; i++) {
                int ler = int.Parse(Console.ReadLine());
                B.Add(ler);
            }

            Console.WriteLine("Quantidade de números que deseja registrar em C? ");
            int qtdNumerosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os números que deseja registrar em C: ");
            for (int i = 0; i < qtdNumerosc; i++) {
                int ler = int.Parse(Console.ReadLine());
                B.Add(ler);
            }

            HashSet<int> total = new HashSet<int>();
            total.UnionWith(A);
            total.UnionWith(B);
            total.UnionWith(C);
            Console.WriteLine("Total de números registrados: "+total.Count);

            Console.ReadLine();

        }
    }
}
