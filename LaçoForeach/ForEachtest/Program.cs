using System;

namespace ForEachtest {
    class Program {
        static void Main(string[] args) {
            String[] vect = new String[3];
                        
            for (int i = 0; i < vect.Length; i++) {
                vect[i] = Console.ReadLine();
            }

            foreach(String obj in vect) {
                Console.WriteLine("Nomes: " + obj);
            }
           
        }
    }
}
