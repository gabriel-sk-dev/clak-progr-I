using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClakTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region Fazer o programa rodar para sempre
                bool possoSair = false;
                while (possoSair == false)
                {
                    Console.WriteLine("To rodando");

                    #region Programa principal
                    string leituraDoTeclado = "";

                    Console.Write("Informe a kilometragem inicial:");
                    leituraDoTeclado = Console.ReadLine();
                    int kmInicial = Convert.ToInt32(leituraDoTeclado);


                    Console.Write("Informe a kilometragem final:");
                    leituraDoTeclado = Console.ReadLine();
                    int kmFinal = Convert.ToInt32(leituraDoTeclado);

                    decimal valorPorKilometro = 5.35m;
                    int hora = DateTime.Now.Hour;
                    if (hora >= 8 && hora <= 18)
                    {
                        valorPorKilometro = 4.28m;
                    }

                    decimal valorCorrida = (kmFinal - kmInicial) * valorPorKilometro;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("O valor a ser pago é de R$ " + valorCorrida);
                    #endregion

                    Console.Write("Você quer sair? (S/N)");
                    string leitura = Console.ReadLine();

                    if (leitura.ToUpper() == "S" )
                    {
                        possoSair = true;
                    }
                }
                #endregion
            }
            catch (Exception)
            {
                Console.WriteLine("Opssss deu merda !");
                Console.WriteLine("Contate o suporte técnico!");
            }
            
            // Para não fechar o programa
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para fechar .....");
            Console.ReadKey();
        }
    }
}
