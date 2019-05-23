using System;
using System.Globalization;

namespace TopicosEspeciais {
    class Program {
        static void Main(string[] args) {

            var a = 10;
            var b = 10.1;
            var c = "Cesar";

            var total = a + b;

            Console.WriteLine((double)total);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
