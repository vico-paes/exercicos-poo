using System;
using System.Collections.Generic;
using System.Text;

namespace EXFinal8.Entidades
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
        }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
