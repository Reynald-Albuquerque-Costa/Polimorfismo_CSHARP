using Polimorfismo.Models;
using System;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();

            aluno1.Nome = "Rynald";
            aluno1.Idade = 19;
            aluno1.Nota = 10;
            aluno1.Apresentar();



            Professor professor1 = new Professor();

            professor1.Nome = "Eduardo";
            professor1.Idade = 40;
            professor1.Salario = 1500;
            professor1.Apresentar();
        }
    }
}
