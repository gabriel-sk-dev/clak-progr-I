using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClakParkVersao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket obj = new Ticket();
            
            // Perguntar o codigo e guardar no objeto
            Console.Write("Qual o codigo");
            obj.Codigo = Console.ReadLine();
            obj.Entrada = DateTime.Now;

        }

    }

    public class Ticket
    {
        public string Codigo;
        public DateTime Entrada;
        public int Permanencia;
        public bool EstaValidado;
        public DateTime DataValidacao;
        public DateTime Saida;
    }
}
