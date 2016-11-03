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
            SqlConnection conexao = new SqlConnection(@"Data Source = GABRIEL-NT; Initial Catalog = Teste; " +
                                                        @"User ID =sa; Password =Gabriel;");
            string consulta = "SELECT * FROM Pessoas";
            SqlCommand comando = new SqlCommand(consulta, conexao);

            DataSet dados = new DataSet();

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(dados);

            listPersonagens.Columns.Add("Personagem");
            listPersonagens.FullRowSelect = true;
            listPersonagens.View = View.Details;
            listPersonagens.GridLines = true;

            foreach (DataRow personagemBanco in dados.Tables[0].Rows)
            {
                listPersonagens.Items.Add(new ListViewItem(personagemBanco["nome"].ToString()));
            }
        }
    }
}
