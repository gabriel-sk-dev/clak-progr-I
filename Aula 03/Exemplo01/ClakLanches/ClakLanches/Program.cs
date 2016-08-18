using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClakLanches
{
    class Program
    {
        static void Main(string[] args)
        {            
            bool erro = true;
            while (erro == true)
            {
                // Cabeçalho
                Console.WriteLine("********************");
                Console.WriteLine("****CLAK LANCHES****");
                Console.WriteLine("********************");

                Console.Write("Informe o nome do usuário:");
                string nome = Console.ReadLine();
                Console.Write("Informe a senha:");
                string senha = Console.ReadLine();

                if (nome == "joao" && senha == "123456")
                {
                    Console.WriteLine("Seja bem vindo Joao");
                    erro = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dados de login inválidos! Pressione qualquer tecla para tentar novamente ....");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                }
            }
            
            // Final do programa
            Console.WriteLine();
            Console.Write("Pressione uma tecla para continuar ....");
            Console.ReadKey();
        }
    }
}
