using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Clak
{    
    public class Personagem
    {
        public Personagem(string nome, 
                          ConsoleKey genero, 
                          ConsoleKey classe)
        {
            Nome = nome;
            switch (genero)
            {
                case ConsoleKey.M:
                    Genero = Genero.Masculino;
                    break;
                case ConsoleKey.F:
                    Genero = Genero.Feminino;
                    break;
                default:
                    throw new InvalidOperationException(String.Format("[{0}] não é um genero válido, use apenas M ou F!", generoLido.KeyChar.ToString()));
            }

            switch (classe)
            {
                case ConsoleKey.A:
                    Classe = Classe.Arcanista;
                    break;
                case ConsoleKey.F:
                    Classe = Classe.Feiticeiro;
                    break;
                case ConsoleKey.M:
                    Classe = Classe.Monge;
                    break;
                case ConsoleKey.B:
                    Classe = Classe.Barbaro;
                    break;
                default:
                    throw new InvalidOperationException(String.Format("[{0}] não é uma classe válida, use apenas A, F, M ou B!", classeLida.KeyChar.ToString()));
            }
            VidaMaxima = 100;
            ExperienciaAtual = 1;
            Nivel = 1;
        }

        public string Nome { get; set; }
        public Classe Classe { get; set; }
        public Genero Genero { get; set; }
        public int VidaMaxima { get; set; }
        public int ExperienciaAtual { get; set; }
        public int Nivel { get; set; }
    }

    public enum Classe
    {
        Arcanista, 
        Barbaro,
        Feiticeiro,
        Monge
    }

    public enum Genero
    {
        Masculino,
        Feminino
    }
}
