namespace RpgComTelas
{
    partial class frmCidadePrincipal
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
            this.btnViaja = new System.Windows.Forms.Button();
            this.cboLocal = new System.Windows.Forms.ComboBox();
            this.pbrVida = new System.Windows.Forms.ProgressBar();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblVida = new System.Windows.Forms.Label();
            this.lblXp = new System.Windows.Forms.Label();
            this.pbrXp = new System.Windows.Forms.ProgressBar();
            this.lblNivel = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
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
            // btnViaja
            // 
            this.btnViaja.Location = new System.Drawing.Point(19, 115);
            this.btnViaja.Name = "btnViaja";
            this.btnViaja.Size = new System.Drawing.Size(171, 23);
            this.btnViaja.TabIndex = 1;
            this.btnViaja.Text = "Viajar";
            this.btnViaja.UseVisualStyleBackColor = true;
            this.btnViaja.Click += new System.EventHandler(this.btnViaja_Click);
            // 
            // cboLocal
            // 
            this.cboLocal.FormattingEnabled = true;
            this.cboLocal.Items.AddRange(new object[] {
            "Floresta",
            "Deserto",
            "Castelo"});
            this.cboLocal.Location = new System.Drawing.Point(19, 88);
            this.cboLocal.Name = "cboLocal";
            this.cboLocal.Size = new System.Drawing.Size(171, 21);
            this.cboLocal.TabIndex = 2;
            // 
            // pbrVida
            // 
            this.pbrVida.Location = new System.Drawing.Point(19, 225);
            this.pbrVida.Name = "pbrVida";
            this.pbrVida.Size = new System.Drawing.Size(273, 23);
            this.pbrVida.TabIndex = 3;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(16, 72);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(127, 13);
            this.lblLocal.TabIndex = 4;
            this.lblLocal.Text = "Para onde desejar viajar?";
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVida.Location = new System.Drawing.Point(16, 202);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(52, 20);
            this.lblVida.TabIndex = 5;
            this.lblVida.Text = "VIDA";
            // 
            // lblXp
            // 
            this.lblXp.AutoSize = true;
            this.lblXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXp.Location = new System.Drawing.Point(17, 261);
            this.lblXp.Name = "lblXp";
            this.lblXp.Size = new System.Drawing.Size(32, 20);
            this.lblXp.TabIndex = 7;
            this.lblXp.Text = "XP";
            // 
            // pbrXp
            // 
            this.pbrXp.Location = new System.Drawing.Point(20, 284);
            this.pbrXp.Name = "pbrXp";
            this.pbrXp.Size = new System.Drawing.Size(273, 23);
            this.pbrXp.TabIndex = 6;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(17, 310);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(61, 20);
            this.lblNivel.TabIndex = 8;
            this.lblNivel.Text = "NIVEL";
            this.lblNivel.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(21, 346);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(452, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // frmCidadePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 381);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblXp);
            this.Controls.Add(this.pbrXp);
            this.Controls.Add(this.lblVida);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.pbrVida);
            this.Controls.Add(this.cboLocal);
            this.Controls.Add(this.btnViaja);
            this.Controls.Add(this.lblDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCidadePrincipal";
            this.Text = "frmCidadePrincipal";
            this.Load += new System.EventHandler(this.frmCidadePrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnViaja;
        private System.Windows.Forms.ComboBox cboLocal;
        private System.Windows.Forms.ProgressBar pbrVida;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Label lblXp;
        private System.Windows.Forms.ProgressBar pbrXp;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Button btnSair;
    }
}