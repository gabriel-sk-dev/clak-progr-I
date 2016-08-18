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
            string leituraDoTeclado = "";

            Console.Write("Informe a kilometragem inicial:");
            leituraDoTeclado =  Console.ReadLine();
            int kmInicial = Convert.ToInt32(leituraDoTeclado);

            Console.Write("Informe a kilometragem final:");
            leituraDoTeclado = Console.ReadLine();
            int kmFinal = Convert.ToInt32(leituraDoTeclado);

            Console.Write("Informe o tipo da bandeira:");
            leituraDoTeclado = Console.ReadLine();
            int tipoBandeira = Convert.ToInt32(leituraDoTeclado);

            decimal valorPorKilometro = 4.28m;
            if (tipoBandeira == 2)
            {
                valorPorKilometro = 5.35m;
            }


            decimal valorCorrida = (kmFinal - kmInicial) * valorPorKilometro;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("O valor a ser pago é de R$ " + valorCorrida);

            // Para não fechar o programa
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para fechar .....");
            Console.ReadKey();
        }
    }
}
