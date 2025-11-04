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
            this.txbLogSenha = new System.Windows.Forms.TextBox();
            this.btnLogEntrar = new System.Windows.Forms.Button();
            this.btnEsqueciSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbLogUsuario
            // 
            this.txbLogUsuario.Location = new System.Drawing.Point(45, 169);
            this.txbLogUsuario.Name = "txbLogUsuario";
            this.txbLogUsuario.Size = new System.Drawing.Size(189, 20);
            this.txbLogUsuario.TabIndex = 0;
            // 
            // txbLogSenha
            // 
            this.txbLogSenha.Location = new System.Drawing.Point(45, 283);
            this.txbLogSenha.Name = "txbLogSenha";
            this.txbLogSenha.PasswordChar = '*';
            this.txbLogSenha.Size = new System.Drawing.Size(189, 20);
            this.txbLogSenha.TabIndex = 3;
            this.txbLogSenha.TextChanged += new System.EventHandler(this.txbLogSenha_TextChanged);
            // 
            // btnLogEntrar
            // 
            this.btnLogEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(207)))), ((int)(((byte)(200)))));
            this.btnLogEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogEntrar.Font = new System.Drawing.Font("Noto Serif Georgian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogEntrar.Location = new System.Drawing.Point(567, 363);
            this.btnLogEntrar.Name = "btnLogEntrar";
            this.btnLogEntrar.Size = new System.Drawing.Size(174, 39);
            this.btnLogEntrar.TabIndex = 4;
            this.btnLogEntrar.Text = "Entrar";
            this.btnLogEntrar.UseVisualStyleBackColor = false;
            this.btnLogEntrar.Click += new System.EventHandler(this.btnLogEntrar_Click);
            // 
            // btnEsqueciSenha
            // 
            this.btnEsqueciSenha.Location = new System.Drawing.Point(45, 379);
            this.btnEsqueciSenha.Name = "btnEsqueciSenha";
            this.btnEsqueciSenha.Size = new System.Drawing.Size(134, 23);
            this.btnEsqueciSenha.TabIndex = 5;
            this.btnEsqueciSenha.Text = "Esqueci senha ";
            this.btnEsqueciSenha.UseVisualStyleBackColor = true;
            this.btnEsqueciSenha.Click += new System.EventHandler(this.btnEsqueciSenha_Click_1);
            // 
            // PgnLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppControleRestaurante.Properties.Resources.Captura_de_tela_2025_11_04_0759402;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEsqueciSenha);
            this.Controls.Add(this.btnLogEntrar);
            this.Controls.Add(this.txbLogSenha);
            this.Controls.Add(this.txbLogUsuario);
            this.DoubleBuffered = true;
            this.Name = "PgnLogin";
            this.Text = "PgnLogin";
            this.Load += new System.EventHandler(this.PgnLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbLogUsuario;
        private System.Windows.Forms.TextBox txbLogSenha;
        private System.Windows.Forms.Button btnLogEntrar;
        private System.Windows.Forms.Button btnEsqueciSenha;
    }
}