using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Computador 
    {
        public override string ToString()
        {
            return "Metodo tostring sobrescrito";//mesmo sem passsar parametro na classe computador, ja ta instanciando objetos da classe object
        }
    }
}