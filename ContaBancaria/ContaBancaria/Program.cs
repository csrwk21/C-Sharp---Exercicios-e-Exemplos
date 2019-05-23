using System;
using System.Globalization;
namespace ContaBancaria {
    class Program {
        static void Main(string[] args) {

            Conta conta;
            Console.Write("Entre com o numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            String titular = Console.ReadLine();
            
            Console.Write("Haverá um depósito inicial s/n?");
            char Char = char.Parse(Console.ReadLine());

            if (Char == 's' || Char == 'S') {
                Console.Write("Entre com o valor do depósito inicial: ");
                double valorDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numeroConta,titular,valorDepositoInicial);
                Console.WriteLine("Dados da Conta:" + conta);
            }
            else {
                conta = new Conta(numeroConta, titular);
            }
                                
            Console.Write("Entre com um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(valorDeposito);

            Console.WriteLine("Dados da Conta: " + conta);

            Console.Write("Digite um valor para saque: ");
            double valorSacar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valorSacar);

            Console.WriteLine("Dados da Conta" + conta);


        }
    }
}
