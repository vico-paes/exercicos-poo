using System;
using System.Collections.Generic;
using System.Text;

namespace EXFinal8.Entidades
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }

        public Cliente()
        {
        }
        public Cliente(string nome, string email, DateTime nascimento)
        {
            Nome = nome;
            Email = email;
            Nascimento = nascimento;
        }
    }

}
