using System;

namespace ExercicioMatriz {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for(int i = 0; i < N; i++) {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0;j<N;j++) {

                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:  ");
            for(int i = 0; i < N; i++) {
                Console.Write(mat[i,i] + " ");
            }

            
            int contagem = 0;
            for(int i = 0; i < N; i++) {
                for(int j = 0; j < N; j++) {
                   if(mat[i,j] < 0) {
                        contagem++;
                    }
                }
            }

            Console.WriteLine("Negative numbers: " +contagem);
          /*  foreach(object show in mat) {
                Console.WriteLine(show);
            }
            */
        }
    }
}
