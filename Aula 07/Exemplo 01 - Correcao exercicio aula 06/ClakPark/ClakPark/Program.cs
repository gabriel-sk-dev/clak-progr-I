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

                    case ConsoleKey.F2:
                        ExecutarRotinaParaCalculoESaida();
                        break;

                    case ConsoleKey.F3:
                        ExecutarRelatorioFinanceiroPorMes();
                        break;

                    case ConsoleKey.F4:
                        possoSair = true;
                        break;
                    default:
                        ExibirMensagemDeErro("Opção de menu inválida!");
                        AguardarTeclaPressionada();
                        break;
                }
            }

        }

        private static void ExecutarRelatorioFinanceiroPorMes()
        {
            ExibirTituloDaRotina("Relatorio Financeiro");

            // Pegar o ano
            string ano = ExibirMensagemELerString("Informe o ano: ");
            // Pegar o mes
            string mes = ExibirMensagemELerString("Informe o mes: ");

            decimal valorTotal = 0;
            for (int i = 0; i < saidas.Count; i++)
            {
                if (saidas[i] == default(DateTime))
                    continue;
                if(saidas[i].Year.ToString() == ano && 
                    saidas[i].Month.ToString() == mes)
                {
                    Console.WriteLine(saidas[i].ToString() + " | " + "R$" + pagamentos[i] );
                    valorTotal += pagamentos[i];
                }
            }
            Console.WriteLine("Total de pagamentos: " + "R$" + valorTotal);

            AguardarTeclaPressionada();
        }

        #region Rotinas principais        

        private static void ExecutarRotinaParaCalculoESaida()
        {
            ExibirTituloDaRotina("Saida de veiculos");

            // Pegar a placa do veiculo
            string placa = ExibirMensagemELerString("Informe a placa: ");
            int posicao = LocalizarVeiculoPelaPlaca(placa);

            // Devo ter encontrado veiculo
            if (posicao == -1)
            {
                ExibirMensagemDeErro("Placa não possui entrada no estacionamento!");
                AguardarTeclaPressionada();
                return;
            }

            // Veiculo não pode ter saida           
            if (saidas[posicao] != default(DateTime))
            {                            
                ExibirMensagemDeErro("Veículo já saiu do estacionamento!");
                AguardarTeclaPressionada();
                return;
            }

            // Calcula a permanencia
            double permanencia = (DateTime.Now - entradas[posicao]).TotalMinutes;

            // Calcula o valor
            decimal valor = CalcularValorParaPermanencia(permanencia);

            // Exibir permanencia e valor
            ExibirMensagemDeSucesso("Permanencia de " + permanencia +
                "no valor de R$" + valor);

            // Pergunta se deseja sair
            ConsoleKeyInfo resposta = ExibirMensagemELerTecla("Deseja Gravar (S/N)");

            if (resposta.Key == ConsoleKey.S)
            {
                // Gravar a saida
                saidas[posicao] = DateTime.Now;
                pagamentos[posicao] = valor;
                ExibirMensagemDeSucesso("Saida registrada");
            }

            AguardarTeclaPressionada();
        }

        private static decimal CalcularValorParaPermanencia(double permanencia)
        {
            decimal valor = 0;
            // Permanencia: ate 15 min R$ 0,00
            if (permanencia <= 15)
            {
                valor = 0.00m;
            }
            // Permanencia: ate 30 min R$ 4,00
            else if (permanencia <= 30)
            {
                valor = 4.00m;
            }
            // Permanencia: ate 1 hora R$ 6,00
            else if (permanencia <= 60)
            {
                valor = 6.00m;
            }
            // Permanencia: cada 1 hora excedente R$ 3,00 
            else if (permanencia > 60 && permanencia < 480)
            {
                valor = 6.00m;
                permanencia = permanencia - 60;
                while (permanencia > 0)
                {
                    valor += 3.00m;
                    permanencia = permanencia - 60;
                }
            }
            // Permanencia: turno de 8 horas R$ 25,00 
            else
            {
                valor = 25.00m;
                permanencia = permanencia - 480;
                while (permanencia > 0)
                {
                    if (permanencia >= 480)
                    {
                        valor += 25.00m;
                        permanencia = permanencia - 480;
                    }
                    else
                    {
                        valor += 3.00m;
                        permanencia = permanencia - 60;
                    }
                }
            }
            return valor;
        }

        private static int LocalizarVeiculoPelaPlaca(string placa)
        {            
            for (int i = 0; i < placas.Count; i++)
            {
                if (placa == placas[i])
                    return i;
            }
            return -1;
        }

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
            entradas.Add(new DateTime(2016, 9, 1, 19, 00, 00));
            saidas.Add(new DateTime(2016, 9, 1, 19, 01, 00));
            pagamentos.Add(20);

            codigos.Add(2);
            placas.Add("IKK-5541");
            entradas.Add(new DateTime(2016, 9, 1, 19, 30, 00));
            saidas.Add(new DateTime(2016, 9, 1, 19, 02, 00));
            pagamentos.Add(21);

            codigos.Add(3);
            placas.Add("IFD-8932");
            entradas.Add(new DateTime(2016, 9, 1, 18, 30, 00));
            saidas.Add(new DateTime(2016, 9, 1, 19, 03, 00));
            pagamentos.Add(22);
            
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
