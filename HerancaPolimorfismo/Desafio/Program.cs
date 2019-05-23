using System;
using System.Globalization;
using Desafio.Entities;
using System.Collections.Generic;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter a number of tax payers: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or Company? (i/c)");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Helth expenditures: ");
                    double helthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, helthExpenditures));
                }
                else
                {
                    Console.Write("Number of Employee: ");
                    int numberOfEmployee = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numberOfEmployee));
                }
            }
            Console.WriteLine("TAX PAID");
            double sum = 0.0;
            foreach (TaxPayer tx in list)
            {
                double tax = tx.Tax();
                Console.WriteLine(tx.Name + ": $ " + tx.Tax().ToString("F2"), CultureInfo.InvariantCulture);
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
