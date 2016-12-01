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
    public partial class frmCidadePrincipal : Form
    {
        public string NomePersonagem { get; set; }

        public frmCidadePrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCidadePrincipal_Load(object sender, EventArgs e)
        {
            string descricao = String.Format("{0} está na cidade.", 
                                                this.NomePersonagem);
            lblDescricao.Text = descricao;

            // Criando conexao
            SqlConnection conexao = new SqlConnection(@"Data Source = GABRIEL-NT; Initial Catalog =RPG; " +
                                                        @"User ID =sa; Password =Gabriel;");

            // Criando comando para ser enviado
            string consulta = 
                   String.Format(@"SELECT * 
                                    FROM Personagens 
                                    WHERE nome = '{0}'",
                                    this.NomePersonagem);
            SqlCommand comando = new SqlCommand(consulta, conexao);

            // Enviando comando e guardando resultado do comando
            DataSet dados = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(dados);

            pbrVida.Value = 100;

            int xp = Convert.ToInt32(dados.Tables[0].Rows[0]["xp"].ToString());
            int xpMinimo = Convert.ToInt32(dados.Tables[0].Rows[0]["xpMinimo"].ToString());
            int xpMaximo = Convert.ToInt32(dados.Tables[0].Rows[0]["xpMaximo"].ToString());
            pbrXp.Minimum = xpMinimo;
            pbrXp.Maximum = xpMaximo;
            pbrXp.Value = xp;


            lblNivel.Text = "Nível " + dados.Tables[0].Rows[0]["nivel"].ToString();
        }

        private void btnViaja_Click(object sender, EventArgs e)
        {
            frmBatalha batalha = new frmBatalha();
            batalha.NomePersonagem = this.NomePersonagem;
            batalha.NomeLocal = cboLocal.SelectedItem.ToString();
            batalha.Show();
            this.Close();
        }
    }
}
