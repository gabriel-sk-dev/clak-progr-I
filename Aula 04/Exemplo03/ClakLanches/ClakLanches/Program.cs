using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClakLanches
{
    class Program
    {
        // SIMULACAO DO BANCO DE DADOS
        static string[] codigos = new string[]
            { "001", "002", "003" };
        static string[] nomes = new string[]
            { "coca cola", "sanduiche", "imigracao 1980" };
        static string[] descricoes = new string[]
            { "refrigerante lata", "Pao com atum", "Chopp weiss 500ml" };
        static decimal[] precos = new decimal[]
            { 4.5m, 10m, 16.20m };
        static int[] quantidades = new int[]
            { 20, 5, 10 };

        // pegar cor padrão da letra
        static ConsoleColor corPadrao = Console.ForegroundColor;

        static void Main(string[] args)
        {

            // Garantir que o programa fique rodando em loop
            bool possoSair = false;
            while (possoSair == false)
            {
                Console.Clear();
                // Informar as opções existentes
                Console.WriteLine("Opções válidas");
                Console.WriteLine("[F1] Cadastro de produtos");
                Console.WriteLine("[F2] Venda de produtos");
                Console.WriteLine("[ESC] Sair");

                // Perguntar qual a opção o usuário deseja
                Console.WriteLine();
                Console.Write("O que deseja fazer? ");
                ConsoleKeyInfo opcaoLida = Console.ReadKey();

                // Tratar a tecla lida para descobrir o menu
                switch (opcaoLida.Key)
                {
                    case ConsoleKey.F1:
                        Console.Clear();
                        // Se for 1 então cadastro produtos
                        Console.WriteLine("-------- CADASTRO DE PRODUTOS ---------");

                        ExecutarRotinaDeCadastro();

                        Console.Write("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F2:
                        Console.Clear();
                        // Se for 2 então venda de produtos
                        Console.WriteLine("-------- VENDA DE PRODUTOS ---------");

                        ExecutarRotinaDeVendaDeProdutos();

                        Console.Write("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Escape:
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

        public static void ExecutarRotinaDeVendaDeProdutos()
        {
            // Leitura do codigo
            Console.Write("Digite o codigo do produto: ");
            string codigoLido = Console.ReadLine();

            int posicaoProduto = -1;

            // Localizar o codigo dentro do vetor de codigos
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigoLido == codigos[i])
                {
                    // Guardar a posição do produto no vetor
                    posicaoProduto = i;
                }
            }

            // Se localizei o produto exibir dados
            if (posicaoProduto >= 0)
            {
                Console.WriteLine();
                Console.WriteLine(nomes[posicaoProduto]);
                Console.WriteLine(descricoes[posicaoProduto]);
                Console.WriteLine("R$ " + precos[posicaoProduto]);

                // Perguntar quantas unidades deseja
                Console.Write("Digite a quantidade: ");
                int quantidadeDesejada = Convert.ToInt32(Console.ReadLine());

                // Verificar se tenho estoque suficiente
                int quantidadeEmEstoque = quantidades[posicaoProduto];
                if (quantidadeDesejada > quantidadeEmEstoque)
                {
                    // Nao tenho mais estoque
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não existe quantidade suficiente para venda!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    // Informar o valor total da compra
                    decimal valorTotal = quantidadeDesejada * precos[posicaoProduto];

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Sua compra deu R$ {0}", valorTotal);
                    Console.ForegroundColor = ConsoleColor.White;

                    // Diminuir o estoque
                    quantidades[posicaoProduto] = quantidades[posicaoProduto] - quantidadeDesejada;
                }
            }
        }

        public static void ExecutarRotinaDeCadastro()
        {
            //Perguntar o codigo para ser criado
            Console.Write("Digite o codigo do novo produto: ");
            string codigoLido = Console.ReadLine();

            int posicaoProduto = -1;

            // Verificar se ja existe algum produto com o codigo
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigoLido == codigos[i])
                {
                    posicaoProduto = i;
                }
            }

            if (posicaoProduto >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Código já exsite!");
                Console.ForegroundColor = corPadrao;
                Console.WriteLine();
                Console.ReadKey();
            }
            else
            {
                // Perguntar o nome do produto, descricao, preco e quantidade                
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();

                // Acrescentar nos vetores

            }




        }
    }
}
