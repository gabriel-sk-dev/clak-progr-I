using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> placas = new List<string>();
            IList<DateTime> datas = new List<DateTime>();
            IList<int> codigos = new List<int>();

            string placa = "";
            DateTime entrada = DateTime.Now;
            int codigo = 1;

            placas.Add(placa);
            datas.Add(entrada);
            codigos.Add(codigo);           

            IList<Entrada> bancoDeDados = new List<Entrada>(); 

            Entrada entrada1 = new Entrada();
            entrada1.Placa = "8976";
            entrada1.Hora = DateTime.Now;
            entrada1.Modelo = "Fusca";

            bancoDeDados.Add(entrada1);

            Entrada entrada2 = new Entrada();
            entrada2.Placa = "9988";
            entrada2.Hora = DateTime.Now.AddHours(-3);

            bancoDeDados.Add(entrada2);

            Entrada entrada3 = new Entrada();
            entrada3.Placa = "5566";
            entrada3.Hora = DateTime.Now.AddHours(-6);

            bancoDeDados.Add(entrada3);


            // Localizar a placa 9988 e mostrar o tempo de permanencia
            foreach (var item in bancoDeDados)
            {
                Console.WriteLine(item.Placa + " | " + item.Hora + " | " + item.Modelo);
            }

            Console.ReadLine();
        }
    }

    public class Entrada
    {
        public string Placa;
        public DateTime Hora;
        public string Modelo;
    }
}
