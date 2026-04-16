using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosAbstratos.Entidades
{
    internal class PessoaJuridica: Pessoa
    {
        public int NumeroFuncionarios { get; set; }
        public PessoaJuridica()
        {
        }
        public PessoaJuridica(string name, double rendaAnual, int numeroFuncionarios)
            : base(name, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }
        public override double Imposto()
        {
            if (NumeroFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
