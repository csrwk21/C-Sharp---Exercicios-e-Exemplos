using System;

namespace Numeros {
    class Program {
        static void Main(string[] args) {
            Num[] vect = new Num[10];

            Console.WriteLine("Quantos numero quer digitar? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {

                //Console.WriteLine($"Numero #{i}:");
                Console.Write("Numero: ");
                int numero = int.Parse(Console.ReadLine());
                //int num1 = int.Parse(Console.ReadLine());
                vect[i] = new Num(numero);
            }

            Console.WriteLine();

            for(int i = 0; i < 10; i++) {
                if(vect[i] != null) {
                    Console.WriteLine(i+": "+vect[i]);
                }
            }
        }
    }
}
