using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosAbstratos.Entidades
{
    internal class PessoaFisica : Pessoa
    {
        public double DespesasSaude { get; set; }

        public PessoaFisica()
        {
        }

        public PessoaFisica(string name, double rendaAnual, double despesasSaude)
            : base(name, rendaAnual)
        {
            DespesasSaude = despesasSaude;
        }

        public override double Imposto()
        {
            if (RendaAnual < 20000)
            {
                return RendaAnual * 0.15 - DespesasSaude * 0.5;
            }
            else
            {
                return RendaAnual * 0.25 - DespesasSaude * 0.5;
            }
        }
    }
}