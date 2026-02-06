using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public Diretor(string nome) : base(nome)
        {
            
        }

        public override void Apresentar()
        {
             Console.WriteLine($"Ola, meu nome e: {Nome}, tenho {Idade} anos, sou diretor e meu salario de {Salario}");
        }
    }
}