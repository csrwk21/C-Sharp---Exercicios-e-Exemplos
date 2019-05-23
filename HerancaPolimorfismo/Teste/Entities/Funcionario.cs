using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Entities
{
    class Funcionario : Cadastro
    {
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {
        }

        public Funcionario (string nome, int matricula, DateTime dataNasc, string cargo, double salario) : 
            base(nome,matricula, dataNasc)
        {
            Cargo = cargo;
            Salario = salario;
        }

        public override string ToString()
        {
            return "Nome: "
                + Nome
                +", Cargo: "
                + Cargo
                +", Salário: "
                +Salario
                + ", Matricula"
                + Matricula
                + ", Data de nascimento: "
                + DataNascimento.ToString("dd/MM/yyyy");
        }
    }
}
