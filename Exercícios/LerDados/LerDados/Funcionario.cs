using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace LerDados {
    class Funcionario {
        public String Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto +(SalarioBruto * porcentagem / 100);
        }

        public override string ToString() {
            return"Funcionario: "
                +Nome
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
