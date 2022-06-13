using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executanto projeto condicionais2");

            int idadeJoao = 16;
            int quantidadePessoas = 2;
            bool acompanhado = quantidadePessoas >= 2;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Joao pode entrar");
            }
            else
            {
                Console.WriteLine("Joao não pode entrar");
            }
            Console.ReadLine();
        }
    }
}
