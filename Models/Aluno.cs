using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)// recebendo o nome do aluno e passando o nome para a classe pessoa
        {
            
        }
        public double Nota {get; set;}
        // sobrescrevendo o metodo, polimorfismo(override)
        public override void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome e: {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}");
        }
    }
}