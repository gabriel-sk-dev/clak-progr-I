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
            // pegar cor padrão da letra
            ConsoleColor corPadrao = Console.ForegroundColor;

            // Garantir que o programa fique rodando em loop
            bool possoSair = false;
            while (possoSair == false)
            {
                Console.Clear();
                // Informar as opções existentes
                Console.WriteLine("Opções válidas");
                Console.WriteLine("[1] Cadastro de produtos");
                Console.WriteLine("[2] Venda de produtos");
                Console.WriteLine("[9] Sair");

                // Perguntar qual a opção o usuário deseja
                Console.WriteLine();
                Console.Write("O que deseja fazer? ");
                string opcaoLida = Console.ReadLine();

                switch (opcaoLida)
                {
                    case "1":
                        Console.Clear();
                        // Se for 1 então cadastro produtos
                        Console.WriteLine("-------- CADASTRO DE PRODUTOS ---------");
                        Console.Write("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        // Se for 2 então venda de produtos
                        Console.WriteLine("-------- VENDA DE PRODUTOS ---------");
                        Console.Write("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                    case "9":
                        // Se for 9 sair
                        possoSair = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção informada é inválida!");
                        Console.ForegroundColor = corPadrao;
                        Console.Write("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }                                
            }

        }
    }
}
