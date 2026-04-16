using MetodosAbstratos.Entidades;
using System;
using System.Collections.Generic;

namespace MetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> lista = new List<Pessoa>();

            Console.Write("Quantas pessoas vc deseja? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Taxa da pessoa {i}: ");
                Console.Write("Fisica ou Juridica? (f/j) " );
                char tipo = char.Parse(Console.ReadLine());

                if (tipo == 'f')
                {
                    Console.Write("Nome: ");
                    string name = Console.ReadLine();
                    Console.Write("Renda Anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine());
                    Console.Write("Despesas Saude: ");
                    double despesasSaude = double.Parse(Console.ReadLine());
                    lista.Add(new PessoaFisica(name, rendaAnual, despesasSaude));
                }
                else if (tipo == 'j')
                {
                    Console.Write("Nome: ");
                    string name = Console.ReadLine();
                    Console.Write("Renda Anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine());
                    Console.Write("Numero de Funcionarios: ");
                    int numeroFuncionarios = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaJuridica(name, rendaAnual, numeroFuncionarios));
                }
                
                }
            Console.WriteLine();
            Console.WriteLine("Taxas pagas");
            foreach (Pessoa pessoa in lista)
            {
                Console.WriteLine($"{pessoa.Name}: $ {pessoa.Imposto().ToString("F2")}");
            }
        }
    }
}