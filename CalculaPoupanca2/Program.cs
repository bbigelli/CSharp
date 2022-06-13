using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto Calculando Poupança 2");

            double valorInvestido = 1000.00;            

            //0.36% = 0.0036
            for (int i = 1; i <= 12; i++) 
            {
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine("Após" + i + "meses você terá: R$" + valorInvestido);
            }
            
            Console.ReadLine();
        }
    }
}
