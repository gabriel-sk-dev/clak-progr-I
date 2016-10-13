using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Clak
{
    class Program
    {
        private static Menu _menuAtual;
        private static bool _sairDoJogo;
        private static Personagem _jogador;
        private static Local _localAtual;

        static void Main(string[] args)
        {
            _sairDoJogo = false;
            while (!_sairDoJogo)
                ExecutaProgramaPrincipal();
        }

        private static void ExecutaProgramaPrincipal()
        {
            ExibirOpcoesMenuPara(_menuAtual);
            ConsoleKeyInfo tecla = LerTecla();
            ExecutaOpcaoConformeMenu(tecla);            
        }

        private static void ExecutaOpcaoConformeMenu(ConsoleKeyInfo tecla)
        {
            if(tecla.Key == ConsoleKey.Escape)
            {
                _sairDoJogo = true;
                return;
            }

            switch (_menuAtual)
            {
                case Menu.Principal:
                    ExecutaOpcaoParaMenuPrincipal(tecla);
                    break;
                case Menu.EmJogoNaCidade:
                    ExecutaOpcaoParaMenuQuandoJogadorEstaNaCidade(tecla);
                    break;
                case Menu.EmJogoForaDaCidade:
                    ExecutaOpcaoParaMenuQuandoJogadorEstaForaDaCidade(tecla);
                    break;
                case Menu.Quest:
                    break;
                default:
                    break;
            }

        }        

        private static void ExecutaOpcaoParaMenuPrincipal(ConsoleKeyInfo tecla)
        {
            switch (tecla.Key)
            {
                case ConsoleKey.F1:
                    CriaPersonagem();
                    break;
                default:
                    break;
            }
        }

        private static void ExecutaOpcaoParaMenuQuandoJogadorEstaNaCidade(ConsoleKeyInfo tecla)
        {
            switch (tecla.Key)
            {
                case ConsoleKey.F3:
                    ViajaPara();
                    break;
                default:
                    break;
            }
        }

        private static void ExecutaOpcaoParaMenuQuandoJogadorEstaForaDaCidade(ConsoleKeyInfo tecla)
        {
            switch (tecla.Key)
            {
                case ConsoleKey.F3:
                    ViajaPara();
                    break;
                case ConsoleKey.F5:
                    AtacaMonstro();
                    break;
                default:
                    break;
            }
        }

        private static void AtacaMonstro()
        {
            Console.Clear();
            Console.WriteLine("-- Em combate --");

            Monstro monstro = new Monstro();
            monstro.Nome = "ASKdjiasd";
            monstro.Nivel = _jogador.Nivel;
            monstro.RecompensaExperiencia = monstro.Nivel * 100;
            monstro.DanoMaximo = monstro.Nivel * 100;
            monstro.VidaMaxima = monstro.Nivel * 100;

            Random rdm = new Random();

            while (_jogador.VidaMaxima > 0 || monstro.VidaMaxima > 0)
            {
                var danoNoMonstro = rdm.Next(1, _jogador.Nivel * 100);
                monstro.VidaMaxima -= danoNoMonstro;
                EscreveMensagemDeDanoEmMonstro(monstro, danoNoMonstro);

                if (monstro.VidaMaxima <= 0)
                    break;

                var danoPersonagem = rdm.Next(1, monstro.DanoMaximo);
                _jogador.VidaMaxima -= danoPersonagem;
                EscreveMensagemDeDanoEmPersonagem(monstro, danoPersonagem);

                if (_jogador.VidaMaxima <= 0)
                {
                    _jogador.VidaMaxima = 100;                    
                    _menuAtual = Menu.EmJogoNaCidade;
                    break;
                }
            }
            
            EscreveMensagemDeSucesso(String.Format("Fim da luta !"));
            AguardaTecla();
        }

        private static void EscreveMensagemDeDanoEmPersonagem(Monstro monstro, int dano)
        {
            var corAnterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            if (_jogador.VidaMaxima > 0)
                Console.WriteLine(String.Format("{0} acertou {1} e tirou {2} de dano. {1} está com {3} de vida", monstro.Nome, _jogador.Nome, dano, _jogador.VidaMaxima));
            else
                Console.WriteLine(String.Format("{0} acertou {1} e tirou {2} de dano. Você morreu!!!!!", monstro.Nome, _jogador.Nome, dano));
            Console.WriteLine();
            Console.ForegroundColor = corAnterior;
        }

        private static void EscreveMensagemDeDanoEmMonstro(Monstro monstro, int dano)
        {
            var corAnterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            if(monstro.VidaMaxima > 0)
                Console.WriteLine( String.Format("{0} acertou {1} e tirou {2} de dano. {1} está com {3} de vida", _jogador.Nome, monstro.Nome, dano, monstro.VidaMaxima  ) );
            else
                Console.WriteLine(String.Format("{0} acertou {1} e tirou {2} de dano. {1} morreu!!!", _jogador.Nome, monstro.Nome, dano));
            Console.WriteLine();
            Console.ForegroundColor = corAnterior;
        }

        private static void CriaPersonagem()
        {
            Console.Clear();
            Console.WriteLine("-- Criação personagem --");

            Console.Write("Qual o genero ([M]asculino/[F]eminino)?");
            var generoLido = Console.ReadKey();
            Console.WriteLine();

            Console.Write("Qual a classe ([A]rcanista/[F]eiticeiro/[M]onge/[B]arbaro)?");
            var classeLida = Console.ReadKey();
            Console.WriteLine();

            Console.Write("Qual o nome do personagem?");
            var nomeLido = Console.ReadLine();
            Console.WriteLine();

            _jogador = new Personagem();
            _jogador.Nome = nomeLido;
            switch (generoLido.Key)
            {
                case ConsoleKey.M:
                    _jogador.Genero = Genero.Masculino;
                    break;
                case ConsoleKey.F:
                    _jogador.Genero = Genero.Feminino;
                    break;
                default:
                    throw new InvalidOperationException(String.Format("[{0}] não é um genero válido, use apenas M ou F!", generoLido.KeyChar.ToString()));
            }
            switch (classeLida.Key)
            {
                case ConsoleKey.A:
                    _jogador.Classe = Classe.Arcanista;
                    break;
                case ConsoleKey.F:
                    _jogador.Classe = Classe.Feiticeiro;
                    break;
                case ConsoleKey.M:
                    _jogador.Classe = Classe.Monge;
                    break;
                case ConsoleKey.B:
                    _jogador.Classe = Classe.Barbaro;
                    break;
                default:
                    throw new InvalidOperationException(String.Format("[{0}] não é uma classe válida, use apenas A, F, M ou B!", classeLida.KeyChar.ToString()));
            }
            _jogador.VidaMaxima = 100;
            _jogador.ExperienciaAtual = 1;
            _jogador.Nivel = 1;

            EscreveMensagemDeSucesso(String.Format("{0} criado com sucesso!", _jogador.Nome));
            _menuAtual = Menu.EmJogoNaCidade;
            AguardaTecla();
        }

        private static void ViajaPara()
        {
            Console.Clear();
            Console.WriteLine("-- Viajar para --");
            Console.Write("Para onde desejar viajar ([F]loresta/[C]astelo/[I]greja)?");
            var localLido = Console.ReadKey();
            Console.WriteLine();

            _localAtual = new Local();
            _localAtual.NivelMaximoMonstros = _jogador.Nivel + 1;
            switch (localLido.Key)
            {
                case ConsoleKey.F:
                    _localAtual.Nome = "Floresta";
            
                    break;  
                default:
                    break;
            }

            _menuAtual = Menu.EmJogoForaDaCidade;
            EscreveMensagemDeSucesso(String.Format("{0} chegou em {1}", _jogador.Nome, _localAtual.Nome));
            AguardaTecla();
        }

        private static void AguardaTecla()
        {
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar ...");
            Console.ReadKey();
        }

        private static void EscreveMensagemDeSucesso(string mensagem)
        {
            var corAnterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(mensagem);
            Console.WriteLine();
            Console.ForegroundColor = corAnterior;
        }

        private static void ExibirOpcoesMenuPara(Menu menuAtual)
        {
            Console.Clear();
            switch (menuAtual)
            {
                case Menu.Principal:
                    Console.WriteLine("(F1) - Para criar personagem");
                    Console.WriteLine("(F2) - Para carregar personagem salvo");
                    Console.WriteLine("(ESC) - Para sair");                    
                    break;
                case Menu.EmJogoNaCidade:
                    Console.WriteLine(String.Format("{0} escolha uma das opções:", _jogador.Nome));
                    Console.WriteLine("(F1) - Para abrir inventario");
                    Console.WriteLine("(F2) - Para salvar progresso");
                    Console.WriteLine("(F3) - Para viajar até um local");                    
                    Console.WriteLine("(ESC) - Para sair");
                    break;
                case Menu.EmJogoForaDaCidade:
                    Console.WriteLine(String.Format("{0}, você está em {1} escolha uma das opções:", _jogador.Nome, _localAtual.Nome));
                    Console.WriteLine("(F1) - Para abrir inventario");
                    Console.WriteLine("(F2) - Para salvar progresso");
                    Console.WriteLine("(F3) - Para viajar até outro local");
                    Console.WriteLine("(F4) - Para viajar até a cidade");
                    Console.WriteLine("(F5) - Para atacar um monstro");
                    Console.WriteLine("(ESC) - Para sair");
                    break;
                case Menu.Quest:
                    break;
                default:
                    break;
            }
            Console.Write("Informe a opção desejada: ");
        }

        private static ConsoleKeyInfo LerTecla()
        {
            return Console.ReadKey();
        }
    }

    public enum Menu
    {
        Principal,        
        EmJogoNaCidade,
        EmJogoForaDaCidade,
        Quest
    }
}
