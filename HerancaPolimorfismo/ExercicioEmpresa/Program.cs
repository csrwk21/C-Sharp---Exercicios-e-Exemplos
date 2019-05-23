using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioEmpresa;

namespace ExercicioEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> List = new List<Employee>();

            Console.WriteLine("Enter a number of employees: ");
            int N = int.Parse(Console.ReadLine());

            for ( int i = 0; i < N; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.WriteLine("Outsourced (y/n");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if ( ch == 'y' || ch == 'Y')
                {
                    Console.WriteLine("Aditional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    List.Add(new OutsourcedEmployee(name, hours, valuePerhour, additionalCharge));
                }
                else
                {
                    List.Add(new Employee(name, hours, valuePerhour));
                }
            }

            Console.WriteLine();

            foreach (object emp in List)
            {
                Console.WriteLine(emp.Name );
            }
            Console.WriteLine("PAYMENTS: ");
        }
    }
}
