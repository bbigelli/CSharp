using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executanto projeto condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Joao é maior de idade");
            }
            else if (quantidadePessoas >= 2)
            {
                Console.WriteLine("João não é maior de idade, mas está acompanhado de um maior.");
            }
            else
            {
                Console.WriteLine("Joao não é maior de idade");
            }
            Console.ReadLine();
        }
    }
}
