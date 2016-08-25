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
            // SIMULACAO DO BANCO DE DADOS
            string[] codigos = new string[]
                { "001", "002", "003" };
            string[] nomes = new string[]
                { "coca cola", "sanduiche", "imigracao 1980" };
            string[] descricoes = new string[]
                { "refrigerante lata", "Pao com atum", "Chopp weiss 500ml" };
            decimal[] precos = new decimal[]
                { 4.5m, 10m, 16.20m };
            int[] quantidades = new int[]
                { 20, 5, 10 };


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


            // Final do programa
            Console.WriteLine();
            Console.Write("Pressione uma tecla para continuar ....");
            Console.ReadKey();
        }
    }
}
