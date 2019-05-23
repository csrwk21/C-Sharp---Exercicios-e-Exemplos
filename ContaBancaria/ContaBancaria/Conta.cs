using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria {
    class Conta {

        public int NumeroConta { get; private set; }
        public String Titular { get; set; }     
        public double Saldo { get; private set; }

        // contrutor com atributor numero da conta e nome do titular
        public Conta(int numeroConta, string titular) {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        // construtor que herdar os dados dos atributos do primeiro construtor com  o saldo
        public Conta(int numeroConta, string titular, double saldo) : this(numeroConta, titular) {
            Saldo = saldo;
        }
        //método para fazer o deposito
        public void Deposito( double valorDeposito) {
            Saldo = Saldo + valorDeposito;
        }
        //método para fazer um saque
        public void Sacar(double valorSacar) {
             Saldo = Saldo - valorSacar + 5.00;
        }
        //sobrecarga para mostrar os dados pré definidos
        public override string ToString() {
            return "Conta "
                    + NumeroConta
                    + ", Titular: "
                    + Titular
                    + ", Saldo: R$ " + Saldo.ToString("F2",CultureInfo.InvariantCulture);

                  
        }
    }
}
