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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.btnEnviar.Location = new System.Drawing.Point(66, 343);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(209, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar código de redefinição";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txbUsuarioRec
            // 
            this.txbUsuarioRec.Location = new System.Drawing.Point(66, 219);
            this.txbUsuarioRec.Name = "txbUsuarioRec";
            this.txbUsuarioRec.Size = new System.Drawing.Size(191, 20);
            this.txbUsuarioRec.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "insira seu usuario para recuperação";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pnlRedefinirSenha
            // 
            this.pnlRedefinirSenha.Controls.Add(this.btnRedefinir);
            this.pnlRedefinirSenha.Controls.Add(this.lblNovaSenha);
            this.pnlRedefinirSenha.Controls.Add(this.txbNovaSenha);
            this.pnlRedefinirSenha.Controls.Add(this.txbToken);
            this.pnlRedefinirSenha.Controls.Add(this.lblToken);
            this.pnlRedefinirSenha.Location = new System.Drawing.Point(377, 71);
            this.pnlRedefinirSenha.Name = "pnlRedefinirSenha";
            this.pnlRedefinirSenha.Size = new System.Drawing.Size(368, 168);
            this.pnlRedefinirSenha.TabIndex = 3;
            this.pnlRedefinirSenha.Visible = false;
            this.pnlRedefinirSenha.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRedefinirSenha_Paint);
            // 
            // btnRedefinir
            // 
            this.btnRedefinir.Location = new System.Drawing.Point(235, 142);
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
            this.lblNovaSenha.Location = new System.Drawing.Point(240, 59);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(67, 13);
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
            this.txbToken.Size = new System.Drawing.Size(100, 20);
            this.txbToken.TabIndex = 1;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(16, 33);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(130, 13);
            this.lblToken.TabIndex = 0;
            this.lblToken.Text = "Token recebido por e-mail";
            // 
            // PgnRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRedefinirSenha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txbUsuarioRec);
            this.Controls.Add(this.btnEnviar);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlRedefinirSenha;
        private System.Windows.Forms.TextBox txbToken;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Button btnRedefinir;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.TextBox txbNovaSenha;
    }
}