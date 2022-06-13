using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto Calculando Poupança");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++) 
                { 
                    Console.Write("*");
                    if (j >= i)
                        break;
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
