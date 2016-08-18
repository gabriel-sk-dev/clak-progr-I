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
            string[] usuarios = new string[] 
                { "pedro", "maria", "joao", "gabriel", "paula" };

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

                // Responsabilidade de encontrar o nome do usuário no vetor
                bool encontrouUsuario = false;
                for (int i = 0; i < usuarios.Length; i++)
                {
                    if (nome == usuarios[i])
                    {
                        encontrouUsuario = true;
                    }
                }

                // Se encontrou o usuário e a senha for a desejada entao apresenta mensagem de boas vindas
                if (encontrouUsuario == true && senha == "123456")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Seja bem vindo " + usuarios[i]);
                    Console.ForegroundColor = ConsoleColor.White;
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
