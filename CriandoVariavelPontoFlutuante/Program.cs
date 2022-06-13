using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoVariavelPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto Criando variaveis ponto flutuante");

            double salario = 1200.70;

            Console.WriteLine("O salário atual é: " + salario);

            double idade;
            idade = 15.0 / 2;
            Console.WriteLine("A idade 15 / 2 é: " + idade);

            Console.WriteLine("Execução finalizada. Tecle ENTER para sair");
            Console.ReadLine();
        }
    }
}
