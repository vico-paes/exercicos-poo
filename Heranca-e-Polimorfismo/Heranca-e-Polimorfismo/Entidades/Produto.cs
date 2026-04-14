using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_e_Polimorfismo.Entidades
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; protected set; }   

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string EtiquetaPreco()
        {
            return $"{Nome} $ {Preco:F2}";
        }
    }
}
