using System;

namespace RefEOut {
    class Program {
        static void Main(string[] args) {

            // parametro ref
               //a váriavel precisa ser inicializada.
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            /* parametro out
                 a váriavel não precisa ser inicializada.
                 ele pega o valor da variavel e armazena e depois que calcula o resulta ele jogar a variavel de origem
                 com o parametro Out.
                  */
            int a1 = 10;
            int triple;
            Calculator.Triple(a1, out triple);
            Console.WriteLine(triple);

        }
    }
}
