using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Clak
{
    public class Monstro
    {
        public Monstro(string nome,
                        int nivel)
        {
            Nome = nome;
            Nivel = nivel;
            RecompensaExperiencia = Nivel * 100;
            DanoMaximo = Nivel * 100;
            VidaMaxima = Nivel * 100;
        }
        public string Nome { get;  set; }
        public int VidaMaxima { get; set; }
        public int Nivel { get; set; }
        public int DanoMaximo { get; set; }
        public int RecompensaExperiencia { get; set; }
    }
}
