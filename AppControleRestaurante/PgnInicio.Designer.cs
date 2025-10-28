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
            this.BtnCadEmpresa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCadEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadEmpresa.Font = new System.Drawing.Font("Noto Serif Georgian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadEmpresa.ForeColor = System.Drawing.Color.Black;
            this.BtnCadEmpresa.Location = new System.Drawing.Point(28, 133);
            this.BtnCadEmpresa.Name = "BtnCadEmpresa";
            this.BtnCadEmpresa.Size = new System.Drawing.Size(196, 47);
            this.BtnCadEmpresa.TabIndex = 1;
            this.BtnCadEmpresa.Text = "Cadastro da Empresa";
            this.BtnCadEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnCadEmpresa.UseVisualStyleBackColor = true;
            this.BtnCadEmpresa.UseWaitCursor = true;
            this.BtnCadEmpresa.Click += new System.EventHandler(this.BtnCadEmpresa_Click);
            // 
            // BtnCadExterno
            // 
            this.BtnCadExterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(209)))));
            this.BtnCadExterno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCadExterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadExterno.Font = new System.Drawing.Font("Noto Serif Georgian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadExterno.ForeColor = System.Drawing.Color.Black;
            this.BtnCadExterno.Location = new System.Drawing.Point(270, 133);
            this.BtnCadExterno.Name = "BtnCadExterno";
            this.BtnCadExterno.Size = new System.Drawing.Size(196, 47);
            this.BtnCadExterno.TabIndex = 8;
            this.BtnCadExterno.Text = "Cadastro Externo";
            this.BtnCadExterno.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnCadExterno.UseVisualStyleBackColor = true;
            this.BtnCadExterno.UseWaitCursor = true;
            this.BtnCadExterno.Click += new System.EventHandler(this.BtnCadExterno_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(209)))));
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Noto Serif Georgian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(540, 366);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(222, 54);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Ir para login";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.UseWaitCursor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
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
        public System.Windows.Forms.Button BtnCadEmpresa;
        public System.Windows.Forms.Button BtnCadExterno;
        public System.Windows.Forms.Button btnLogin;
    }
}

