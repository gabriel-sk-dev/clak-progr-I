using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExemploBancoDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome ");
            string nome = Console.ReadLine();

            Console.Write("Digite a cidade ");
            string cidade = Console.ReadLine();


            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString =
               @"Data Source=GABRIEL-NT;Initial Catalog=Teste;" +
               @"User ID =sa; Password =Gabriel;";

            SqlConnection conexaoSuperRapida = new SqlConnection();
            conexaoSuperRapida.ConnectionString =
               @"Data Source=GABRIEL-NT;Initial Catalog=Teste;" +
               @"User ID =sa; Password =Gabriel;";

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = 
                "INSERT INTO Pessoas (Nome,Cidade, Telefone) VALUES ('"+nome+"', '"+cidade+"', 'Telefone')";

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();


            Console.Read();
        }
    }
}
