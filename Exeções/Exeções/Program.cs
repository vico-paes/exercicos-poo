using System;
using System.Collections.Generic;
using System.Text;
using Exeções.Entidades;
using Exeções.Execoes;


namespace Exeções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Dados da conta:");
                Console.Write("Número: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                Console.Write("Limite de saque: ");
                double limiteSaque = double.Parse(Console.ReadLine());

                Conta conta = new Conta(numero, nome, saldo, limiteSaque);

                Console.WriteLine("Entre com o valor para saque: ");
                double valorSaque = double.Parse(Console.ReadLine());

                conta.Saque(valorSaque);
                Console.WriteLine("Saque realizado com sucesso!");
                Console.WriteLine("Saldo atual: " + conta.Saldo);

            }
            catch (ExecaoPrincipal e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
