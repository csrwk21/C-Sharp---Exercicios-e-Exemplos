using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Entities
{
    class Cadastro
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public DateTime DataNascimento { get; set; }

        public Cadastro()
        {

        }

        public Cadastro( string nome, int matricula, DateTime dataNasci)
        {
            Nome = nome;
            Matricula = matricula;
            DataNascimento = dataNasci;
        }

        public override string ToString()
        {
            return "Nome: "
                + Nome
                + ", Matricula"
                + Matricula
                + ", Data de nascimento: "
                + DataNascimento.ToString("dd/MM/yyyy");
        }
    }
}
