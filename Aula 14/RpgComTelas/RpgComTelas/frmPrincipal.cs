using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpgComTelas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Criando conexao
            SqlConnection conexao = new SqlConnection(@"Data Source = GABRIEL-NT; Initial Catalog = Teste; " +
                                                        @"User ID =sa; Password =Gabriel;");

            // Criando comando para ser enviado
            string consulta = "SELECT * FROM Pessoas";
            SqlCommand comando = new SqlCommand(consulta, conexao);

            // Enviando comando e guardando resultado do comando
            DataSet dados = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(dados);

            // configurando o listview
            listPersonagens.Columns.Add("Personagem");
            listPersonagens.FullRowSelect = true;
            listPersonagens.View = View.Details;
            listPersonagens.GridLines = true;

            // Exibindo o resultado do banco dentro do listview
            foreach (DataRow personagemBanco in dados.Tables[0].Rows)
            {
                listPersonagens.Items.Add(new ListViewItem(personagemBanco["nome"].ToString()));
            }
        }

        private void listPersonagens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCriaPersonagem_Click(object sender, EventArgs e)
        {
            // abre formulario de criacao de personagem
            frmCriaPersonagem janela = new frmCriaPersonagem();
            janela.Show();

            // fecha a janela atual
        }
    }
}
