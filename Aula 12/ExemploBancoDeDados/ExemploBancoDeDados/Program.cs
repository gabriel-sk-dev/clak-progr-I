using System;
using System.Collections.Generic;
using System.Data;
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

            Console.Write("Digite a telefone ");
            string telefone = Console.ReadLine();

            // Cria conexao com o banco de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString =
               @"Data Source=GABRIEL-NT;Initial Catalog=Teste;" +
               @"User ID =sa; Password =Gabriel;";

            
            // Cria comando que será enviado
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = 
                "INSERT INTO Pessoas (Nome,Cidade, Telefone) VALUES ('"+nome+"', '"+cidade+"', '"+telefone+"')";

            // Envia o comando, abrindo a conexao, executando o comando e fechando a conexao
            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();

            Console.WriteLine("Comando foi executado com sucesso no banco de dados");
            Console.WriteLine();

            Console.WriteLine("Aguarde consultando registros no banco de dados");

            // Atribui outro comando SQL
            comando.CommandText = "SELECT Id, Nome, Cidade, Telefone FROM Pessoas";

            // cria um adaptador para receber os dados do comando sql
            SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando);

            // Cria um objeto para guardar o resultado da consulta
            DataSet dados = new DataSet();

            // Manda executar o comando e preencher o dataset com os dados do comando sql
            sqlAdaptador.Fill(dados);

            // O Dataset é uma "copia" do banco de dados, porem apenas com o resultado do comando enviado então....
            int totalDeRegistros = dados.Tables[0].Rows.Count; // Consigo pegar quantas linhas minha consulta retornou
            Console.WriteLine("ID | Nome | Cidade | Telefone");
            foreach (DataRow linha in dados.Tables[0].Rows)
            {
                string texto = String.Format("{0} | {1} | {2} | {3}",
                                                linha["id"].ToString(),
                                                linha["nome"].ToString(),
                                                linha["cidade"].ToString(),
                                                linha["telefone"].ToString());
                Console.WriteLine(texto);
            }

            Console.WriteLine();
            Console.WriteLine("Total de registros encontrados " + totalDeRegistros);

            Console.Read();
        }
    }
}
