using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaInvestimentoLongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto Calculando Poupança");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 12; j++) 
                {
                    valorInvestido *= fatorRendimento;
                }

                fatorRendimento += 0.0010;                
            }
            
            Console.WriteLine("Ao término do investimento, voce terá R$: " + valorInvestido);

            Console.ReadLine();
        }
    }
}
