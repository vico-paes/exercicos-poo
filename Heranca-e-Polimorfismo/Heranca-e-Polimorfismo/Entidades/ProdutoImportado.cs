using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_e_Polimorfismo.Entidades
{
    internal class ProdutoImportado : Produto
    {
        public double TaxaAlfandega { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double taxaAlfandega) : base(nome, preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        public override string EtiquetaPreco()
        {
            double precoTotal = Preco + TaxaAlfandega;
            return $"{Nome} $ {precoTotal:F2} (Taxa alfândega: $ {TaxaAlfandega:F2})";
        }
    }
}
