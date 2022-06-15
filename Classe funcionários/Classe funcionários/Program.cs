using System;
using System.Globalization;
namespace Classe_funcionários
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionarios funcionario1 = new Funcionarios();
            Funcionarios funcionario2 = new Funcionarios();

            funcionario1.Nome = "Carlos Silva";
            funcionario1.Salario = 6300.00;
            funcionario2.Nome = "Ana Marques";
            funcionario2.Salario = 6700.00;

            double media;
            media = (funcionario1.Salario + funcionario2.Salario) / 2.0;
            Console.WriteLine("Salário médio = " + media.ToString("F2"),CultureInfo.InvariantCulture);


        }
    }
}