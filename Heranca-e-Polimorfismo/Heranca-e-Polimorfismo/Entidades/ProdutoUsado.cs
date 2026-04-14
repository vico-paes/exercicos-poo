using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_e_Polimorfismo.Entidades
{
    internal class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string EtiquetaPreco()
        {
            return base.EtiquetaPreco();
            return $"{Nome} (usado) $ {Preco:F2} (Data de fabricação: {DataFabricacao:dd/MM/yyyy})";
        }
    }
}
