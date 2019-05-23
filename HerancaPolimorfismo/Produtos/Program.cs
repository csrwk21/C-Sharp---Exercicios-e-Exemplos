using System;
using System.Globalization;
using System.Collections.Generic;
using Produtos.Entities;
namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter a number of products: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Product #{i} data:");

                Console.WriteLine("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'C' || ch == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (ch == 'u' || ch == 'U')
                {
                    Console.WriteLine("Manufcture date (DD/MM/YYYY) ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(manufactureDate));
                }
                else
                {
                    Console.WriteLine("Custom fee: ");
                    double customfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, customfee));
                }
            }


            Console.WriteLine("Price Tags: ");

            foreach(Product pro in list)
            {
                Console.WriteLine(pro.PriceTag());
            }
        }
    }
}
