using System;
using System.Collections.Generic;
using System.Text;

namespace EXFinal8.Entidades
{
    internal class PedidoItem
    {
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public Produto Produto { get; set; }

        public PedidoItem()
        {
        }
        public PedidoItem(int quantidade, double valor, Produto produto)
        {
            Quantidade = quantidade;
            Valor = valor;
            Produto = produto;
        }
        public double SubTotal()
        {
            return Quantidade * Valor;
        }
    }
}
