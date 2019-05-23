using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioFuncionario.Entities;

namespace ExercicioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> List = new List<Employee>();
            // entra com o numero de usuário que irá cadastrar
            Console.WriteLine("Enter a number of employees: ");
            int N = int.Parse(Console.ReadLine());

            // for para cadastrar os usuários de acordo com o numero de usuário quer cadastrar.
            for (int i = 0; i < N; i++)
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

                //verifica se o usuário digitou Y para "Yes" e N para "No"
                if (ch == 'y' || ch == 'Y')
                {
                    Console.WriteLine("Aditional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //adiciona os dados digitados na lista instanciada como "list"
                    List.Add(new OutsourcedEmployee(name, hours, valuePerhour, additionalCharge));
                }
                else
                {
                    //adiciona os dados digitados na lista instanciada como "list"
                    List.Add(new Employee(name, hours, valuePerhour));
                }
            }

            Console.WriteLine();

            Console.WriteLine("PAYMENTS: ");
            // pega todos os dados que foram cadastrados na lista e mostra na tela para o usuário
            foreach (Employee emp in List)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
