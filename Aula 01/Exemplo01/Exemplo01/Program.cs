using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world !!!!!");

            Console.Write("Digite seu nome:");
            string nomeDoUsuario = Console.ReadLine();

            Console.WriteLine();
            
            Console.Write("Seja bem vindo " + nomeDoUsuario);


            // Para o programa ficar executando
            Console.ReadLine();            
        }
    }
}
