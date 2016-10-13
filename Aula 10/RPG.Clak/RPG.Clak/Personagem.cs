using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Clak
{
    public class Personagem
    {
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
