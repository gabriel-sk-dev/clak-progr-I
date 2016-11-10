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
    public partial class frmCriaPersonagem : Form
    {
        public frmCriaPersonagem()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            // Conectar com banco de dados
            SqlConnection conexao = new SqlConnection(@"Data Source=Gabriel-NT;User id=sa;Password=Gabriel;Initial Catalog=Rpg");

            //Cria comando
            string sql = String.Format("INSERT INTO Personagens (Nome, Classe, Vida, XP) VALUES ('{0}', '{1}', 100, 1 )",
                                    txtNome.Text, txtClasse.Text);
            SqlCommand comando = new SqlCommand(sql, conexao);            

            // Envia comando
            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();

            // Abre Janela de seleção de personagem
            
            // Fecha janela atual
        }
    }
}
