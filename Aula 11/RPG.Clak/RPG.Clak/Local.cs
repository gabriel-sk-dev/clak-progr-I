using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Clak
{
    public class Local

    {
        public Local(string nome,
                    int nivelmaximomonstros,
                    int nivelminimodomonstro)
        {
            Nome = nome;
            NivelMaximoMonstros = nivelmaximomonstros;
            NivelMinimoMonstros = nivelminimodomonstro;
        }

        public string Nome { get; set; }
        public int NivelMaximoMonstros { get; set; }

        public int NivelMinimoMonstros { get; set; }
    }
}
