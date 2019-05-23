using System;
using System.Collections.Generic;

namespace Conjuntos {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            A.IntersectWith(B);  // mostra o elementos iguais dentro do conjunto

            /*A.UnionWith(B);  //une todos os elementos que tem em B em A.  */

           /* A.ExceptWith(B);    remove o elementos que os cojuntos tem em comum.  */
            
           /* B.Remove(4); // remove um elemento de B. */


            foreach(int x in A) {
                Console.WriteLine(x);
            }

       /*     Console.WriteLine("Digite  um valor: ");
            int N = int.Parse(Console.ReadLine());                         Digite um valor e verificar se o numero pertence ao conjunto ou nao

            if (B.Contains(N)) {
                Console.WriteLine(N+" Pertence ao conjunto B");
            }
            else {
                Console.WriteLine("Não pertence.");
            }

            Console.ReadLine();   */
        }
    }
}
