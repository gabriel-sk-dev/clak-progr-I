namespace RpgComTelas
{
    partial class frmPrincipal
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
            this.btnCriaPersonagem = new System.Windows.Forms.Button();
            this.listPersonagens = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnCriaPersonagem
            // 
            this.btnCriaPersonagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriaPersonagem.Location = new System.Drawing.Point(12, 227);
            this.btnCriaPersonagem.Name = "btnCriaPersonagem";
            this.btnCriaPersonagem.Size = new System.Drawing.Size(722, 44);
            this.btnCriaPersonagem.TabIndex = 0;
            this.btnCriaPersonagem.Text = "Criar novo personagem";
            this.btnCriaPersonagem.UseVisualStyleBackColor = true;
            this.btnCriaPersonagem.Click += new System.EventHandler(this.btnCriaPersonagem_Click);
            // 
            // listPersonagens
            // 
            this.listPersonagens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPersonagens.Location = new System.Drawing.Point(12, 12);
            this.listPersonagens.Name = "listPersonagens";
            this.listPersonagens.Size = new System.Drawing.Size(722, 209);
            this.listPersonagens.TabIndex = 1;
            this.listPersonagens.UseCompatibleStateImageBehavior = false;
            this.listPersonagens.SelectedIndexChanged += new System.EventHandler(this.listPersonagens_SelectedIndexChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 283);
            this.Controls.Add(this.listPersonagens);
            this.Controls.Add(this.btnCriaPersonagem);
            this.Name = "frmPrincipal";
            this.Text = "RPG";
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriaPersonagem;
        private System.Windows.Forms.ListView listPersonagens;
    }
}

