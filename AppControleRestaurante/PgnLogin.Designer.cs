namespace AppControleRestaurante
{
    partial class PgnLogin
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
            this.txbLogUsuario = new System.Windows.Forms.TextBox();
            this.lblLogUsuario = new System.Windows.Forms.Label();
            this.lblLogSenha = new System.Windows.Forms.Label();
            this.txbLogSenha = new System.Windows.Forms.TextBox();
            this.btnLogEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbLogUsuario
            // 
            this.txbLogUsuario.Location = new System.Drawing.Point(99, 157);
            this.txbLogUsuario.Name = "txbLogUsuario";
            this.txbLogUsuario.Size = new System.Drawing.Size(100, 20);
            this.txbLogUsuario.TabIndex = 0;
            // 
            // lblLogUsuario
            // 
            this.lblLogUsuario.AutoSize = true;
            this.lblLogUsuario.Location = new System.Drawing.Point(105, 125);
            this.lblLogUsuario.Name = "lblLogUsuario";
            this.lblLogUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblLogUsuario.TabIndex = 1;
            this.lblLogUsuario.Text = "Usuario";
            // 
            // lblLogSenha
            // 
            this.lblLogSenha.AutoSize = true;
            this.lblLogSenha.Location = new System.Drawing.Point(105, 242);
            this.lblLogSenha.Name = "lblLogSenha";
            this.lblLogSenha.Size = new System.Drawing.Size(38, 13);
            this.lblLogSenha.TabIndex = 2;
            this.lblLogSenha.Text = "Senha";
            // 
            // txbLogSenha
            // 
            this.txbLogSenha.Location = new System.Drawing.Point(125, 291);
            this.txbLogSenha.Name = "txbLogSenha";
            this.txbLogSenha.Size = new System.Drawing.Size(100, 20);
            this.txbLogSenha.TabIndex = 3;
            // 
            // btnLogEntrar
            // 
            this.btnLogEntrar.Location = new System.Drawing.Point(501, 356);
            this.btnLogEntrar.Name = "btnLogEntrar";
            this.btnLogEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnLogEntrar.TabIndex = 4;
            this.btnLogEntrar.Text = "Entrar";
            this.btnLogEntrar.UseVisualStyleBackColor = true;
            this.btnLogEntrar.Click += new System.EventHandler(this.btnLogEntrar_Click);
            // 
            // PgnLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogEntrar);
            this.Controls.Add(this.txbLogSenha);
            this.Controls.Add(this.lblLogSenha);
            this.Controls.Add(this.lblLogUsuario);
            this.Controls.Add(this.txbLogUsuario);
            this.Name = "PgnLogin";
            this.Text = "PgnLogin";
            this.Load += new System.EventHandler(this.PgnLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbLogUsuario;
        private System.Windows.Forms.Label lblLogUsuario;
        private System.Windows.Forms.Label lblLogSenha;
        private System.Windows.Forms.TextBox txbLogSenha;
        private System.Windows.Forms.Button btnLogEntrar;
    }
}