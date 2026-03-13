using System;
using System.Collections.Generic;
using System.Text;

namespace PrimieroEX
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Qunt;

        public double ValorTotalEmEstoque()
        {
            return Preco * Qunt;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Qunt = Qunt + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Qunt = Qunt - quantidade;
        }

        public override string ToString()
        {
            return $"Produto: {Nome}, Preço: {Preco.ToString("F2")}, Quantidade: {Qunt}, Valor total em estoque: {ValorTotalEmEstoque().ToString("F2")}";
        }
    }
}
