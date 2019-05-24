using System;
//using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            //Código refrente a classe DateTimeExtensions 

            /*   DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
               Console.WriteLine(dt.ElapsedTime());
               */


            //Código referente a classe StringExtensions
            string s1 = "Good morning dear students";

            Console.Write("Quantas letras você deseja corta da frase? ");
            int qtd = int.Parse(Console.ReadLine());
            Console.WriteLine(s1.Cut(qtd));
        }
    }
}
