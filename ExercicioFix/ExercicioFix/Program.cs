using System;
using System.Globalization;
using ExercicioFix.Entities;
using ExercicioFix.Entities.Enum;

namespace ExercicioFix
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Client Data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter Order Data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("how many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for ( int i = 1; i <=n; i++)
            {
                Console.WriteLine($"Enter #{i} item Data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                
                Product product = new Product(nameProduct, priceProduct);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, priceProduct, product);

                order.AddItem(orderItem);              
            }

            Console.WriteLine();
            Console.WriteLine("Order Sumary: ");
            Console.WriteLine(order);

            
        }
    }
}
