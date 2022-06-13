using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto Criando conversoes e outros tipos numéricos");

            double salario = 1200.50;

            int salarioInt = (int)salario;

            Console.WriteLine(salarioInt);

            Console.WriteLine("Execução finalizada. Tecle ENTER para sair");
            Console.ReadLine();
        }
    }
}
