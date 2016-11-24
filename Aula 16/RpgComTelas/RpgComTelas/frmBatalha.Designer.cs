namespace RpgComTelas
{
    partial class frmBatalha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnLutar = new System.Windows.Forms.Button();
            this.pbrVida = new System.Windows.Forms.ProgressBar();
            this.lblVida = new System.Windows.Forms.Label();
            this.lblXp = new System.Windows.Forms.Label();
            this.pbrXp = new System.Windows.Forms.ProgressBar();
            this.lblNivel = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lstMonstros = new System.Windows.Forms.ListBox();
            this.lstLuta = new System.Windows.Forms.ListBox();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.pgrVidaMonstro = new System.Windows.Forms.ProgressBar();
            this.lblMonstro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(13, 13);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(145, 31);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // btnLutar
            // 
            this.btnLutar.Location = new System.Drawing.Point(12, 247);
            this.btnLutar.Name = "btnLutar";
            this.btnLutar.Size = new System.Drawing.Size(171, 23);
            this.btnLutar.TabIndex = 1;
            this.btnLutar.Text = "Lutar";
            this.btnLutar.UseVisualStyleBackColor = true;
            this.btnLutar.Click += new System.EventHandler(this.btnLutar_Click);
            // 
            // pbrVida
            // 
            this.pbrVida.Location = new System.Drawing.Point(10, 305);
            this.pbrVida.Name = "pbrVida";
            this.pbrVida.Size = new System.Drawing.Size(273, 23);
            this.pbrVida.TabIndex = 3;
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVida.Location = new System.Drawing.Point(7, 282);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(52, 20);
            this.lblVida.TabIndex = 5;
            this.lblVida.Text = "VIDA";
            // 
            // lblXp
            // 
            this.lblXp.AutoSize = true;
            this.lblXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXp.Location = new System.Drawing.Point(8, 341);
            this.lblXp.Name = "lblXp";
            this.lblXp.Size = new System.Drawing.Size(32, 20);
            this.lblXp.TabIndex = 7;
            this.lblXp.Text = "XP";
            // 
            // pbrXp
            // 
            this.pbrXp.Location = new System.Drawing.Point(11, 364);
            this.pbrXp.Name = "pbrXp";
            this.pbrXp.Size = new System.Drawing.Size(273, 23);
            this.pbrXp.TabIndex = 6;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(8, 390);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(61, 20);
            this.lblNivel.TabIndex = 8;
            this.lblNivel.Text = "NIVEL";            
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 426);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(452, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // lstMonstros
            // 
            this.lstMonstros.FormattingEnabled = true;
            this.lstMonstros.Items.AddRange(new object[] {
            "Rei da bala",
            "Pavio curto",
            "Joe Ferro"});
            this.lstMonstros.Location = new System.Drawing.Point(12, 55);
            this.lstMonstros.Name = "lstMonstros";
            this.lstMonstros.Size = new System.Drawing.Size(171, 186);
            this.lstMonstros.TabIndex = 10;
            // 
            // lstLuta
            // 
            this.lstLuta.FormattingEnabled = true;
            this.lstLuta.Location = new System.Drawing.Point(297, 55);
            this.lstLuta.Name = "lstLuta";
            this.lstLuta.Size = new System.Drawing.Size(393, 186);
            this.lstLuta.TabIndex = 11;
            this.lstLuta.Visible = false;
            // 
            // btnAtacar
            // 
            this.btnAtacar.Location = new System.Drawing.Point(297, 247);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(393, 23);
            this.btnAtacar.TabIndex = 12;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = true;
            this.btnAtacar.Visible = false;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // pgrVidaMonstro
            // 
            this.pgrVidaMonstro.Location = new System.Drawing.Point(297, 305);
            this.pgrVidaMonstro.Name = "pgrVidaMonstro";
            this.pgrVidaMonstro.Size = new System.Drawing.Size(393, 23);
            this.pgrVidaMonstro.TabIndex = 13;
            this.pgrVidaMonstro.Visible = false;
            // 
            // lblMonstro
            // 
            this.lblMonstro.AutoSize = true;
            this.lblMonstro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonstro.Location = new System.Drawing.Point(293, 282);
            this.lblMonstro.Name = "lblMonstro";
            this.lblMonstro.Size = new System.Drawing.Size(152, 20);
            this.lblMonstro.TabIndex = 14;
            this.lblMonstro.Text = "NOME MONSTRO";
            this.lblMonstro.Visible = false;
            // 
            // frmBatalha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 461);
            this.Controls.Add(this.lblMonstro);
            this.Controls.Add(this.pgrVidaMonstro);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.lstLuta);
            this.Controls.Add(this.lstMonstros);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblXp);
            this.Controls.Add(this.pbrXp);
            this.Controls.Add(this.lblVida);
            this.Controls.Add(this.pbrVida);
            this.Controls.Add(this.btnLutar);
            this.Controls.Add(this.lblDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBatalha";
            this.Text = "frmCidadePrincipal";
            this.Load += new System.EventHandler(this.frmCidadePrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnLutar;
        private System.Windows.Forms.ProgressBar pbrVida;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Label lblXp;
        private System.Windows.Forms.ProgressBar pbrXp;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ListBox lstMonstros;
        private System.Windows.Forms.ListBox lstLuta;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.ProgressBar pgrVidaMonstro;
        private System.Windows.Forms.Label lblMonstro;
    }
}