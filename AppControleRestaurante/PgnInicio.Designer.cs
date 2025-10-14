namespace AppControleRestaurante
{
    partial class PgnInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCadEmpresa = new System.Windows.Forms.Button();
            this.BtnCadExterno = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCadEmpresa
            // 
            this.BtnCadEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(209)))));
            this.BtnCadEmpresa.BackgroundImage = global::AppControleRestaurante.Properties.Resources.Captura_de_tela_2025_10_14_125335;
            this.BtnCadEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCadEmpresa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCadEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(209)))));
            this.BtnCadEmpresa.Location = new System.Drawing.Point(30, 153);
            this.BtnCadEmpresa.Name = "BtnCadEmpresa";
            this.BtnCadEmpresa.Size = new System.Drawing.Size(176, 10);
            this.BtnCadEmpresa.TabIndex = 1;
            this.BtnCadEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCadEmpresa.UseVisualStyleBackColor = false;
            this.BtnCadEmpresa.UseWaitCursor = true;
            this.BtnCadEmpresa.Visible = false;
            this.BtnCadEmpresa.Click += new System.EventHandler(this.BtnCadEmpresa_Click);
            // 
            // BtnCadExterno
            // 
            this.BtnCadExterno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCadExterno.Location = new System.Drawing.Point(460, 207);
            this.BtnCadExterno.Name = "BtnCadExterno";
            this.BtnCadExterno.Size = new System.Drawing.Size(199, 46);
            this.BtnCadExterno.TabIndex = 2;
            this.BtnCadExterno.Text = "Cadastro Externo";
            this.BtnCadExterno.UseVisualStyleBackColor = true;
            this.BtnCadExterno.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.Location = new System.Drawing.Point(585, 380);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(175, 50);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Ir para o login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // PgnInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppControleRestaurante.Properties.Resources.Captura_de_tela_2025_10_14_123419;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.BtnCadExterno);
            this.Controls.Add(this.BtnCadEmpresa);
            this.DoubleBuffered = true;
            this.Name = "PgnInicial";
            this.Text = "PgnInicial";
            this.Load += new System.EventHandler(this.PgnInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCadExterno;
        private System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Button BtnCadEmpresa;
    }
}

