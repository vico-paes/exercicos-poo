using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosAbstratos.Entidades
{
    abstract class Pessoa
    {
        public string Name { get; set; }
        public double RendaAnual { get; set; }

        //o copilot daqui fala para colocar protecded nas classes abstratas, nao sei se mmuda algo//
        public Pessoa()
        {
        }

        public Pessoa(string name, double rendaAnual)
        {
            Name = name;
            RendaAnual = rendaAnual;
        }
        public abstract double Imposto();
    }
}
