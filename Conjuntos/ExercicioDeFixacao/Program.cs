using System;
using System.Collections.Generic;

namespace ExercicioDeFixacao {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos: ");
            int NumeroA = int.Parse(Console.ReadLine());

            for(int i =0; i < NumeroA; i++) {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            Console.Write("O curso B possui quantos alunos: ");
            int NumeroB = int.Parse(Console.ReadLine());

            for(int i = 0; i < NumeroB; i++) {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }

            Console.WriteLine("O curso C possui quantos alunos: ");
            int NumeroC = int.Parse(Console.ReadLine());

            for(int i =0;i < NumeroC; i++) {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);
            }

            HashSet<int> Y = new HashSet<int>();

            Y.UnionWith(A);
            Y.UnionWith(B);
            Y.UnionWith(C);
            Console.WriteLine("Total: "+Y.Count);

        }
    }
}
