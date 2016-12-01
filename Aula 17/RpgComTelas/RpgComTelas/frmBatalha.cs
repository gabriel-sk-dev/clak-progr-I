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
    public partial class frmBatalha : Form
    {
        public string NomePersonagem { get; set; }
        public string NomeLocal { get; set; }


        private int _nivelPersonagem;
        private int _vidaMonstro;
        private int _vidaPersonagem;
        private int _xpAtual;
        private int _xpMaximo;
        private int _xpMinimo;

        public frmBatalha()
        {
            InitializeComponent();
        }       

        private void frmCidadePrincipal_Load(object sender, EventArgs e)
        {
            string descricao = String.Format("{0} está em {1}.", 
                                                this.NomePersonagem,
                                                this.NomeLocal);
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

            _vidaPersonagem = 100;
            pbrVida.Value = _vidaPersonagem;

            _xpAtual = Convert.ToInt32(dados.Tables[0].Rows[0]["xp"].ToString());
            _xpMinimo = Convert.ToInt32(dados.Tables[0].Rows[0]["xpMinimo"].ToString());
            _xpMaximo = Convert.ToInt32(dados.Tables[0].Rows[0]["xpMaximo"].ToString());
            pbrXp.Minimum = _xpMinimo;
            pbrXp.Maximum = _xpMaximo;
            pbrXp.Value = _xpAtual;

            _nivelPersonagem = Convert.ToInt32(dados.Tables[0].Rows[0]["nivel"].ToString());
            lblNivel.Text = "Nível " + _nivelPersonagem;
        }

        private void btnLutar_Click(object sender, EventArgs e)
        {
            lblMonstro.Visible = true;
            btnAtacar.Visible = true;
            lstLuta.Visible = true;
            pgrVidaMonstro.Visible = true;

            btnLutar.Visible = false;

            lblMonstro.Text = lstMonstros.SelectedItem.ToString();
            _vidaMonstro = 100;
            pgrVidaMonstro.Value = _vidaMonstro;

            lstLuta.Items.Clear();
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();

            int dano = rdm.Next(1, _nivelPersonagem * 100);
            _vidaMonstro -= dano;
            pgrVidaMonstro.Value = _vidaMonstro <= 0 ? 0 : _vidaMonstro ;
            lstLuta.Items.Add(String.Format("{0} atacou {1} e tirou {2} de dano",
                                                this.NomePersonagem,
                                                lblMonstro.Text,
                                                dano));
            //if (_vidaMonstro <= 0)
            //    pgrVidaMonstro.Value = 0;
            //else
            //    pgrVidaMonstro.Value = _vidaMonstro;


            if(_vidaMonstro <=0)
            {
                lstLuta.Items.Add(String.Format("{0} matou {1}",
                                                this.NomePersonagem,
                                                lblMonstro.Text));
                // calculo xp
                int novaXp =+ _xpAtual + 10;
                int novoNivel = _nivelPersonagem;

                if(novaXp >= _xpMaximo)
                {
                    novoNivel++;
                    _xpMinimo = _xpMaximo;
                    _xpMaximo = _xpMaximo * 2;
                }
                // Criando conexao
                SqlConnection conexao = new SqlConnection(@"Data Source = GABRIEL-NT; Initial Catalog =RPG; " +
                                                            @"User ID =sa; Password =Gabriel;");

                // Criando comando para ser enviado
                string consulta =
                       String.Format(@"UPDATE Personagens
                                       SET Nivel = {0},
                                        Xp = {1},
                                        XpMaximo = {2},
                                        XpMinimo = {3}
                                        WHERE nome = '{4}'",
                                        novoNivel,
                                        novaXp,
                                        _xpMaximo,
                                        _xpMinimo,
                                        this.NomePersonagem);
                SqlCommand comando = new SqlCommand(consulta, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();  //ISSO QUE EXECUTA O COMANDO NO BANCO
                conexao.Close();

                pbrXp.Minimum = _xpMinimo;
                pbrXp.Maximum = _xpMaximo;
                pbrXp.Value = novaXp;
                lblNivel.Text = "Nivel " + novoNivel;

                MessageBox.Show("Voce ganhou");

                lblMonstro.Visible = false;
                btnAtacar.Visible = false;
                lstLuta.Visible = false;
                pgrVidaMonstro.Visible = false;

                btnLutar.Visible = true;
            }

            // Ataque do monstro
            dano = rdm.Next(1, 100);
            _vidaPersonagem -= dano;
            pbrVida.Value = _vidaPersonagem <= 0 ? 0 : _vidaPersonagem;
            lstLuta.Items.Add(String.Format("{0} atacou {1} e tirou {2} de dano",                                                
                                                lblMonstro.Text,
                                                this.NomePersonagem,
                                                dano));

            if(_vidaPersonagem <=0)
            {
                lstLuta.Items.Add(String.Format("{0} matou {1}",                                                
                                                lblMonstro.Text,
                                                this.NomePersonagem));
                MessageBox.Show("Voce perdeu, seu fracassado de merda");
                frmCidadePrincipal cidade = new frmCidadePrincipal();
                cidade.NomePersonagem = this.NomePersonagem;
                cidade.Show();
                this.Close();
            }
        }
    }
}
