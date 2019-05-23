﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_de_fixacao.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double total()
        {
            return Preco * Quantidade;
        }
            

    }
}
