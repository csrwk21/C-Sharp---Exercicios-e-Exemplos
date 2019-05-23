using System;

namespace Struct {
    class Program {
        static void Main(string[] args) {
            double? x = null;

            double? y = 10.0;

            /*  Point p;
              p.x = double.Parse(Console.ReadLine());
              p.y = 20;

              Console.WriteLine(p);  */

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            if (x.HasValue) {
                Console.WriteLine(x.Value);
            }
            else {
                Console.WriteLine("X is null");
            }

            if (y.HasValue) {
                Console.WriteLine(y.Value);
            }
            else {
                Console.WriteLine("Y is null");
            }
        }
    }
}
