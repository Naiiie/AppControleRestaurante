namespace AppControleRestaurante
{
    partial class PgnRecuperarSenha
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txbUsuarioRec = new System.Windows.Forms.TextBox();
            this.pnlRedefinirSenha = new System.Windows.Forms.Panel();
            this.btnRedefinir = new System.Windows.Forms.Button();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.txbNovaSenha = new System.Windows.Forms.TextBox();
            this.txbToken = new System.Windows.Forms.TextBox();
            this.lblToken = new System.Windows.Forms.Label();
            this.pnlRedefinirSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(207)))), ((int)(((byte)(200)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Font = new System.Drawing.Font("Noto Serif Georgian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.Location = new System.Drawing.Point(83, 344);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(278, 49);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar código de redefinição";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txbUsuarioRec
            // 
            this.txbUsuarioRec.Location = new System.Drawing.Point(34, 131);
            this.txbUsuarioRec.Name = "txbUsuarioRec";
            this.txbUsuarioRec.Size = new System.Drawing.Size(263, 20);
            this.txbUsuarioRec.TabIndex = 1;
            this.txbUsuarioRec.TextChanged += new System.EventHandler(this.txbUsuarioRec_TextChanged);
            // 
            // pnlRedefinirSenha
            // 
            this.pnlRedefinirSenha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlRedefinirSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRedefinirSenha.Controls.Add(this.btnRedefinir);
            this.pnlRedefinirSenha.Controls.Add(this.lblNovaSenha);
            this.pnlRedefinirSenha.Controls.Add(this.txbNovaSenha);
            this.pnlRedefinirSenha.Controls.Add(this.txbToken);
            this.pnlRedefinirSenha.Controls.Add(this.lblToken);
            this.pnlRedefinirSenha.Location = new System.Drawing.Point(272, 157);
            this.pnlRedefinirSenha.Name = "pnlRedefinirSenha";
            this.pnlRedefinirSenha.Size = new System.Drawing.Size(368, 168);
            this.pnlRedefinirSenha.TabIndex = 3;
            this.pnlRedefinirSenha.Visible = false;
            this.pnlRedefinirSenha.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRedefinirSenha_Paint);
            // 
            // btnRedefinir
            // 
            this.btnRedefinir.Font = new System.Drawing.Font("Noto Serif Georgian", 9.749998F, System.Drawing.FontStyle.Bold);
            this.btnRedefinir.Location = new System.Drawing.Point(222, 133);
            this.btnRedefinir.Name = "btnRedefinir";
            this.btnRedefinir.Size = new System.Drawing.Size(133, 23);
            this.btnRedefinir.TabIndex = 4;
            this.btnRedefinir.Text = "Redefinir Senha";
            this.btnRedefinir.UseVisualStyleBackColor = true;
            this.btnRedefinir.Click += new System.EventHandler(this.btnRedefinir_Click_1);
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Font = new System.Drawing.Font("Noto Serif Georgian", 9.749998F, System.Drawing.FontStyle.Bold);
            this.lblNovaSenha.Location = new System.Drawing.Point(240, 54);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(86, 18);
            this.lblNovaSenha.TabIndex = 3;
            this.lblNovaSenha.Text = "Nova Senha";
            // 
            // txbNovaSenha
            // 
            this.txbNovaSenha.Location = new System.Drawing.Point(243, 75);
            this.txbNovaSenha.Name = "txbNovaSenha";
            this.txbNovaSenha.Size = new System.Drawing.Size(100, 20);
            this.txbNovaSenha.TabIndex = 2;
            this.txbNovaSenha.UseSystemPasswordChar = true;
            // 
            // txbToken
            // 
            this.txbToken.Location = new System.Drawing.Point(19, 49);
            this.txbToken.Name = "txbToken";
            this.txbToken.Size = new System.Drawing.Size(176, 20);
            this.txbToken.TabIndex = 1;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Font = new System.Drawing.Font("Noto Serif Georgian", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToken.Location = new System.Drawing.Point(16, 24);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(179, 18);
            this.lblToken.TabIndex = 0;
            this.lblToken.Text = "Token recebido por e-mail";
            // 
            // PgnRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppControleRestaurante.Properties.Resources.Captura_de_tela_2025_12_01_154806;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRedefinirSenha);
            this.Controls.Add(this.txbUsuarioRec);
            this.Controls.Add(this.btnEnviar);
            this.DoubleBuffered = true;
            this.Name = "PgnRecuperarSenha";
            this.Text = "PgnRecuperarSenha";
            this.pnlRedefinirSenha.ResumeLayout(false);
            this.pnlRedefinirSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txbUsuarioRec;
        private System.Windows.Forms.Panel pnlRedefinirSenha;
        private System.Windows.Forms.TextBox txbToken;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Button btnRedefinir;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.TextBox txbNovaSenha;
    }
}