using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Models
{
    public  class Professor : Pessoa
    {
        public Professor()
        {

        }
        public Professor(string nome) : base(nome)
        {

        }
        public decimal Salario { get; set; }

        // Subscreve
        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}. Meu salário é {Salario} ");
        }
    }
}
