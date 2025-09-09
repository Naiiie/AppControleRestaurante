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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PgnInicial));
            this.PgnImagemInicio = new System.Windows.Forms.PictureBox();
            this.BtnCadEmpresa = new System.Windows.Forms.Button();
            this.BtnCadExterno = new System.Windows.Forms.Button();
            this.LblCadEmpresa = new System.Windows.Forms.Label();
            this.LblCadExterno = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PgnImagemInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // PgnImagemInicio
            // 
            this.PgnImagemInicio.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PgnImagemInicio.ErrorImage")));
            this.PgnImagemInicio.Image = ((System.Drawing.Image)(resources.GetObject("PgnImagemInicio.Image")));
            this.PgnImagemInicio.InitialImage = ((System.Drawing.Image)(resources.GetObject("PgnImagemInicio.InitialImage")));
            this.PgnImagemInicio.Location = new System.Drawing.Point(2, 1);
            this.PgnImagemInicio.Name = "PgnImagemInicio";
            this.PgnImagemInicio.Size = new System.Drawing.Size(475, 130);
            this.PgnImagemInicio.TabIndex = 0;
            this.PgnImagemInicio.TabStop = false;
            // 
            // BtnCadEmpresa
            // 
            this.BtnCadEmpresa.Location = new System.Drawing.Point(41, 183);
            this.BtnCadEmpresa.Name = "BtnCadEmpresa";
            this.BtnCadEmpresa.Size = new System.Drawing.Size(199, 46);
            this.BtnCadEmpresa.TabIndex = 1;
            this.BtnCadEmpresa.Text = "Cadastro da Empresa";
            this.BtnCadEmpresa.UseVisualStyleBackColor = true;
            this.BtnCadEmpresa.Click += new System.EventHandler(this.BtnCadEmpresa_Click);
            // 
            // BtnCadExterno
            // 
            this.BtnCadExterno.Location = new System.Drawing.Point(354, 183);
            this.BtnCadExterno.Name = "BtnCadExterno";
            this.BtnCadExterno.Size = new System.Drawing.Size(199, 46);
            this.BtnCadExterno.TabIndex = 2;
            this.BtnCadExterno.Text = "Cadastro Externo";
            this.BtnCadExterno.UseVisualStyleBackColor = true;
            this.BtnCadExterno.Click += new System.EventHandler(this.button2_Click);
            // 
            // LblCadEmpresa
            // 
            this.LblCadEmpresa.AutoSize = true;
            this.LblCadEmpresa.Location = new System.Drawing.Point(57, 246);
            this.LblCadEmpresa.Name = "LblCadEmpresa";
            this.LblCadEmpresa.Size = new System.Drawing.Size(156, 26);
            this.LblCadEmpresa.TabIndex = 5;
            this.LblCadEmpresa.Text = "Cadastre ou faça o login para \r\ngerenciar de perto sua empresa";
            this.LblCadEmpresa.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblCadExterno
            // 
            this.LblCadExterno.AutoSize = true;
            this.LblCadExterno.Location = new System.Drawing.Point(351, 246);
            this.LblCadExterno.Name = "LblCadExterno";
            this.LblCadExterno.Size = new System.Drawing.Size(249, 26);
            this.LblCadExterno.TabIndex = 6;
            this.LblCadExterno.Text = "Cadastre ou faça login como funcionario e participe\r\n ativamente  em sua empresa";
            // 
            // btnLogin
            // 
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.LblCadExterno);
            this.Controls.Add(this.LblCadEmpresa);
            this.Controls.Add(this.BtnCadExterno);
            this.Controls.Add(this.BtnCadEmpresa);
            this.Controls.Add(this.PgnImagemInicio);
            this.Name = "PgnInicial";
            this.Text = "PgnInicial";
            this.Load += new System.EventHandler(this.PgnInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PgnImagemInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PgnImagemInicio;
        private System.Windows.Forms.Button BtnCadEmpresa;
        private System.Windows.Forms.Button BtnCadExterno;
        private System.Windows.Forms.Label LblCadEmpresa;
        private System.Windows.Forms.Label LblCadExterno;
        private System.Windows.Forms.Button btnLogin;
    }
}

