using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
            
        }

        public decimal Salario {get; set;}
        // override sobrescreve, polimorfismo
        public override void Apresentar()
        {
             Console.WriteLine($"Ola, meu nome e: {Nome}, tenho {Idade} anos, e meu salario de {Salario}");
        }
    }
}