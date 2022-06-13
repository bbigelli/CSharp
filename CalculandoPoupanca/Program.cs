using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto Calculando Poupança");

            double valorInvestido = 1000.00;
            int contadorMes = 1;

            //0.36% = 0.0036
            while (contadorMes <= 12)
            {
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine("Após" + contadorMes + "meses você terá: R$" + valorInvestido);

                contadorMes++;
            }
            Console.ReadLine();        
        }
    }
}
