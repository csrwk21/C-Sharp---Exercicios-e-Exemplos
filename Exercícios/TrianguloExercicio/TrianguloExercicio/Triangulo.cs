using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace TrianguloExercicio {
    class Triangulo {

        public double xA, xB, xC;
        public double yA, yB, yC;
        public double areaX, areaY;

        public void lerValoresX() {
            Console.WriteLine("Digite os valores de X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public void lerValoresY() {
            Console.WriteLine("Digite os valores de Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public void calcularArea() {

            double p = (xA + xB + xC) / 2.0;
            areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            Console.WriteLine("Area X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            double p2 = (yA + yB + yC) / 2.0;
            areaY = Math.Sqrt(p * (p2 - yA) * (p2 - yB) * (p2 - yC));
            Console.WriteLine("Area Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
        }

        public void calcularAreaY() {
          
        }

        public void testarArea() {
            if (areaX >= areaY) {
                Console.WriteLine("Area X é maior");
            }
            else {
                Console.WriteLine("Area Y é maior");
            }
        }

    }
}
