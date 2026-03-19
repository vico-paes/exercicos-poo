using System;
using System.Collections.Generic;
using System.Text;

namespace ExFinal5
{
    internal class ContaBancaria
    {
        // o get vc nunca podera mudar, o set vc pode mudar, o private vc so pode mudar dentro da propria classe //
        public int NumeroConta { get; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        // public double Deposito { get; private set; } , jeito que o Andre ensinou//

        // this pega o de fora //
        public ContaBancaria(int numeroConta, string titular, double saldo) //int deposito =0//)
        {
            this.NumeroConta = numeroConta;
            this.Titular = titular;
            this.Saldo = saldo;
            // this.Deposito = deposito;//
        }

        /*o nelio faz 2 construtrores, 1 com o saldo outro sem o saldo, e no que tem o saldo
        ele usa um Deposito(saldo), pq caso mude algo no sacar ou depositar ele muda aqui tbm*/
        public void depositar(double valor)
        {
            Saldo += valor;
        }
        public void sacar(double valor)
        {
            Saldo -= valor + 5.00;
        }
        public override string ToString()
        {
            return $"{NumeroConta}, Titular: {Titular}, Saldo: ${Saldo.ToString("F2")}";
        }

    }
}
