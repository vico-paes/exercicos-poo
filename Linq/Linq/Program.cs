using Linq.Entidades;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tudo aqui e so para nao criar um arquivo txt//
            string[] lines = {
            "Maria,maria@gmail.com,3200,00",
            "Alex,alex@gmail.com,1900,00",
            "Marco,marco@gmail.com,1700,00",
            "Bob,bob@gmail.com,3500,00",
            "Anna,anna@gmail.com,2800,00"};
            List<Funcionarios> fun = new List<Funcionarios>();

            foreach (string line in lines)
            {
                string[] list = line.Split(',');
                string nome = list[0];
                string email = list[1];
                double salario = double.Parse(list[2]);

                fun.Add(new Funcionarios(nome, email, salario));
            } //ate aqui//

            Console.Write("Coloque o valor do salário ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Emails de quem tem o salrio maior que " + valor);
            var ordem = fun.Where(p => p.Salario > valor).OrderBy(p => p.Nome);
            foreach (var x in ordem)
            {
                Console.WriteLine(x.Email);
            }
            Console.WriteLine();

            var soma = fun.Where(p => p.Nome[0] == 'M').Sum(p => p.Salario);
            Console.Write("Soma dos salarios das pessoas que começam com 'M': " + soma.ToString("F2"));


        }
    }
}
