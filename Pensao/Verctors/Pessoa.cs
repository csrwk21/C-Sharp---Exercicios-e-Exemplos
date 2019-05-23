using System;
using System.Collections.Generic;
using System.Text;

namespace Verctors {
    class Pessoa {

        public String Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade) {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString() {
            return "nome " + Nome + " Idade: " + Idade;
        }
    }
}
