using System;
using System.Collections.Generic;
using System.Text;
using Exeções.Execoes;

namespace Exeções.Entidades
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta() { }

        public Conta(int numero, string nome, double saldo, double limiteSaque)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            if (valor > LimiteSaque)
            {
                throw new ExecaoPrincipal("Valor do saque excede o limite permitido.");
            }
            if (valor > Saldo)
            {
                throw new ExecaoPrincipal("Saldo insuficiente para realizar o saque.");
            }
            Saldo -= valor;
        }
    }
}
