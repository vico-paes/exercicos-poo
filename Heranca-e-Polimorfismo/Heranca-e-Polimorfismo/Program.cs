using Heranca_e_Polimorfismo.Entidades;
using System;
using System.Collections.Generic;   


namespace Heranca_e_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos produtos?");
            int num = int.Parse(Console.ReadLine());

            //o professor usou uma lista de produtos, mais nao e necessario assim//
            // https://github.com/acenelio/inheritance5-csharp/blob/master/Course/Program.cs //

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Produto {i}");
                Console.Write("Comum, usado ou importado (c/u/i)? ");
                char x = char.Parse(Console.ReadLine());

                if (x == char.Parse("c"))
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine());
                    Produto produto = new Produto(nome, preco);
                    Console.WriteLine(produto.EtiquetaPreco());
                }
                else if (x == char.Parse("u"))
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Data de fabricação (DD/MM/YYYY): ");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());
                    ProdutoUsado produtoUsado = new ProdutoUsado(nome, preco, dataFabricacao);
                    Console.WriteLine(produtoUsado.EtiquetaPreco());
                }
                else if (x == char.Parse("i"))
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Taxa alfândega: ");
                    double taxaAlfandega = double.Parse(Console.ReadLine());
                    ProdutoImportado produtoImportado = new ProdutoImportado(nome, preco, taxaAlfandega);
                    Console.WriteLine(produtoImportado.EtiquetaPreco());
                }
            }
        }
    }
}
