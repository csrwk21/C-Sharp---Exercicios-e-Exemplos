using System;
using MetodoAbstratos.Entities;
using MetodoAbstratos.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;

namespace MetodoAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the numbers of shape: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");

                Console.Write("Rectangle or Circle (r/c)");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r' || ch == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(color, radius));
                }
            }

            Console.WriteLine("SHAPE AREAS: ");

            foreach (Shape sha in list)
            {
                Console.WriteLine(sha.Area().ToString("F2"), CultureInfo.InvariantCulture);
            }
        }
    }
}
