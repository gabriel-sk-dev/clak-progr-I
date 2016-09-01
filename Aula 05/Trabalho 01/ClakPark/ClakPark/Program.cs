using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClakPark
{
    class Program
    {
        // Atributos para simular os dados do banco de dados
        private static List<int> codigos = new List<int>();
        private static List<string> placas = new List<string>();
        private static List<DateTime> entradas = new List<DateTime>();
        private static List<DateTime> saidas = new List<DateTime>();
        private static List<decimal> pagamentos = new List<decimal>();

        static void Main(string[] args)
        {
            CarregarDadosDoBancoDeDados();

            // Executar programa principal
            bool possoSair = false;
            while ( !possoSair )
            {
                ExibirCabecalhoDoPrograma();

                ExibirMenuDescritivo();
                ConsoleKeyInfo opcaoMenuLido = ExibirMensagemELerTecla("O que deseja fazer? ");
                switch (opcaoMenuLido.Key)
                {
                    case ConsoleKey.F1:
                        ExecutarRotinaParaRegistroDeEntrada();
                        break;

                    //TODO : Adicionar rotina para calculo e registro da saida do veiculo
                    // Regras para valor:
                    // Permanencia: ate 15 min R$ 0,00
                    // Permanencia: ate 30 min R$ 4,00
                    // Permanencia: ate 1 hora R$ 6,00
                    // Permanencia: cada 1 hora excedente R$ 3,00 
                    // Permanencia: turno de 8 horas R$ 25,00 
                    //                    
                    // Regra: Não posso registrar saida para uma placa que já saiu
                    // Regra: Placa deve ser encontrada, caso contrario mostrar mensagem
                    // Regra: Exibir tempo total e valor a pagar
                    // Regra: Somente depois de exibir tempo e valor, perguntar para o usuário se deseja gravar saida

                    case ConsoleKey.F3:
                        possoSair = true;
                        break;
                    default:
                        ExibirMensagemDeErro("Opção de menu inválida!");
                        AguardarTeclaPressionada();
                        break;
                }
            }

        }

        #region Rotinas principais

        private static void ExecutarRotinaParaRegistroDeEntrada()
        {
            ExibirTituloDaRotina("registrar entrada");
            string placa = ExibirMensagemELerString("Informe a placa: ");


            // TODO : Colocar funcionalidade dentro de um método
            // TODO : Adicionar regra: Se uma placa está dentro do 
            //          estacionamento (sem data de saida, ou seja default(DateTime)) não posso registrar a entrada novamente
            // Adicionar no banco de dados
            codigos.Add(codigos.Max() + 1);
            placas.Add(placa);
            entradas.Add(DateTime.Now);
            saidas.Add(default(DateTime));
            pagamentos.Add(0);

            ExibirMensagemDeSucesso("Entrada registrada com sucesso");
            AguardarTeclaPressionada();
        }        

        #endregion

        #region Rotinas de apoio

        private static void CarregarDadosDoBancoDeDados()
        {
            codigos.Add(1);
            placas.Add("ICV-8976");
            entradas.Add(new DateTime(2017, 9, 1, 19, 00, 00));
            saidas.Add(default(DateTime));
            pagamentos.Add(0);

            codigos.Add(2);
            placas.Add("IKK-5541");
            entradas.Add(new DateTime(2017, 9, 1, 19, 30, 00));
            saidas.Add(default(DateTime));
            pagamentos.Add(0);

            codigos.Add(3);
            placas.Add("IFD-8932");
            entradas.Add(new DateTime(2017, 9, 1, 18, 30, 00));
            saidas.Add(new DateTime(2017, 9, 1, 19, 25, 00));
            pagamentos.Add(25.00m);
        }

        private static void ExibirCabecalhoDoPrograma()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("---------CLAK ESTACIONAMENTO---------");
            Console.WriteLine("-------------------------------------");
        }

        private static void ExibirMenuDescritivo()
        {
            Console.WriteLine();
            Console.WriteLine("F1 - Nova entrada de veiculo");
            Console.WriteLine("F2 - Calcular valor e registrar saída");
            Console.WriteLine("F3 - Sair");
            Console.WriteLine();
        }

        private static ConsoleKeyInfo ExibirMensagemELerTecla(string mensagem)
        {
            Console.Write(mensagem);
            return Console.ReadKey();
        }

        private static string ExibirMensagemELerString(string mensagem)
        {
            Console.Write(mensagem);
            return Console.ReadLine();
        }

        private static void ExibirMensagemDeErro(string mensagem)
        {
            var corOriginal = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensagem);
            Console.ForegroundColor = corOriginal;
        }
        private static void ExibirMensagemDeSucesso(string mensagem)
        {
            var corOriginal = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mensagem);
            Console.ForegroundColor = corOriginal;
        }

        private static void AguardarTeclaPressionada()
        {
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar ....");
            Console.ReadKey();
        }

        private static void ExibirTituloDaRotina(string mensagem)
        {
            Console.Clear();
            Console.WriteLine("---------- "+ mensagem.ToUpper() +" ----------");
            Console.WriteLine();
        }

        #endregion

    }
}
