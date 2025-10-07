namespace AppControleRestaurante
{
    partial class PgnCadEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PgnCadEmpresa));
            this.TxbNome = new System.Windows.Forms.TextBox();
            this.TxbCNPJ = new System.Windows.Forms.TextBox();
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.TxbContato = new System.Windows.Forms.TextBox();
            this.LblNomeEmpresa = new System.Windows.Forms.Label();
            this.LblCNPJ = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.Label();
            this.CmbTamEmpresa = new System.Windows.Forms.ComboBox();
            this.LblTamEmpresa = new System.Windows.Forms.Label();
            this.LblUserEmpresa = new System.Windows.Forms.Label();
            this.TxbUsuario = new System.Windows.Forms.TextBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TxbSenha = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.pictureLog1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxbNome
            // 
            this.TxbNome.Location = new System.Drawing.Point(47, 115);
            this.TxbNome.Name = "TxbNome";
            this.TxbNome.Size = new System.Drawing.Size(246, 20);
            this.TxbNome.TabIndex = 0;
            // 
            // TxbCNPJ
            // 
            this.TxbCNPJ.Location = new System.Drawing.Point(47, 165);
            this.TxbCNPJ.Name = "TxbCNPJ";
            this.TxbCNPJ.Size = new System.Drawing.Size(246, 20);
            this.TxbCNPJ.TabIndex = 1;
            // 
            // TxbEmail
            // 
            this.TxbEmail.Location = new System.Drawing.Point(47, 217);
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(246, 20);
            this.TxbEmail.TabIndex = 2;
            // 
            // TxbContato
            // 
            this.TxbContato.Location = new System.Drawing.Point(49, 271);
            this.TxbContato.Name = "TxbContato";
            this.TxbContato.Size = new System.Drawing.Size(246, 20);
            this.TxbContato.TabIndex = 3;
            // 
            // LblNomeEmpresa
            // 
            this.LblNomeEmpresa.AutoSize = true;
            this.LblNomeEmpresa.Location = new System.Drawing.Point(44, 99);
            this.LblNomeEmpresa.Name = "LblNomeEmpresa";
            this.LblNomeEmpresa.Size = new System.Drawing.Size(35, 13);
            this.LblNomeEmpresa.TabIndex = 4;
            this.LblNomeEmpresa.Text = "Nome";
            // 
            // LblCNPJ
            // 
            this.LblCNPJ.AutoSize = true;
            this.LblCNPJ.Location = new System.Drawing.Point(46, 149);
            this.LblCNPJ.Name = "LblCNPJ";
            this.LblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.LblCNPJ.TabIndex = 5;
            this.LblCNPJ.Text = "CNPJ";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(44, 201);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(35, 13);
            this.LblEmail.TabIndex = 6;
            this.LblEmail.Text = "E-mail";
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(44, 249);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(44, 13);
            this.LblNumero.TabIndex = 7;
            this.LblNumero.Text = "Numero";
            // 
            // CmbTamEmpresa
            // 
            this.CmbTamEmpresa.FormattingEnabled = true;
            this.CmbTamEmpresa.Items.AddRange(new object[] {
            "(1)- Micro Empresa",
            "(2)-Pequena Empresa",
            "(3)-Média Empresa",
            "(4)- Grande Empresa"});
            this.CmbTamEmpresa.Location = new System.Drawing.Point(47, 331);
            this.CmbTamEmpresa.Name = "CmbTamEmpresa";
            this.CmbTamEmpresa.Size = new System.Drawing.Size(246, 21);
            this.CmbTamEmpresa.TabIndex = 13;
            // 
            // LblTamEmpresa
            // 
            this.LblTamEmpresa.AutoSize = true;
            this.LblTamEmpresa.Location = new System.Drawing.Point(44, 305);
            this.LblTamEmpresa.Name = "LblTamEmpresa";
            this.LblTamEmpresa.Size = new System.Drawing.Size(165, 13);
            this.LblTamEmpresa.TabIndex = 14;
            this.LblTamEmpresa.Text = "Selecione o tamanho da empresa";
            // 
            // LblUserEmpresa
            // 
            this.LblUserEmpresa.AutoSize = true;
            this.LblUserEmpresa.Location = new System.Drawing.Point(453, 163);
            this.LblUserEmpresa.Name = "LblUserEmpresa";
            this.LblUserEmpresa.Size = new System.Drawing.Size(56, 13);
            this.LblUserEmpresa.TabIndex = 16;
            this.LblUserEmpresa.Text = "USUARIO";
            // 
            // TxbUsuario
            // 
            this.TxbUsuario.Location = new System.Drawing.Point(456, 194);
            this.TxbUsuario.Name = "TxbUsuario";
            this.TxbUsuario.Size = new System.Drawing.Size(246, 20);
            this.TxbUsuario.TabIndex = 17;
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Location = new System.Drawing.Point(453, 271);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(44, 13);
            this.LblSenha.TabIndex = 18;
            this.LblSenha.Text = "SENHA";
            // 
            // TxbSenha
            // 
            this.TxbSenha.Location = new System.Drawing.Point(456, 298);
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.Size = new System.Drawing.Size(246, 20);
            this.TxbSenha.TabIndex = 19;
            this.TxbSenha.UseSystemPasswordChar = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(592, 367);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(131, 23);
            this.BtnSalvar.TabIndex = 20;
            this.BtnSalvar.Text = "SALVAR e ENTRAR";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // pictureLog1
            // 
            this.pictureLog1.Image = ((System.Drawing.Image)(resources.GetObject("pictureLog1.Image")));
            this.pictureLog1.Location = new System.Drawing.Point(0, -2);
            this.pictureLog1.Name = "pictureLog1";
            this.pictureLog1.Size = new System.Drawing.Size(803, 453);
            this.pictureLog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLog1.TabIndex = 21;
            this.pictureLog1.TabStop = false;
            // 
            // PgnCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxbSenha);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.TxbUsuario);
            this.Controls.Add(this.LblUserEmpresa);
            this.Controls.Add(this.LblTamEmpresa);
            this.Controls.Add(this.CmbTamEmpresa);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblCNPJ);
            this.Controls.Add(this.LblNomeEmpresa);
            this.Controls.Add(this.TxbContato);
            this.Controls.Add(this.TxbEmail);
            this.Controls.Add(this.TxbCNPJ);
            this.Controls.Add(this.TxbNome);
            this.Controls.Add(this.pictureLog1);
            this.Name = "PgnCadEmpresa";
            this.Text = "PgnLoginEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbNome;
        private System.Windows.Forms.TextBox TxbCNPJ;
        private System.Windows.Forms.TextBox TxbEmail;
        private System.Windows.Forms.TextBox TxbContato;
        private System.Windows.Forms.Label LblNomeEmpresa;
        private System.Windows.Forms.Label LblCNPJ;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.ComboBox CmbTamEmpresa;
        private System.Windows.Forms.Label LblTamEmpresa;
        private System.Windows.Forms.Label LblUserEmpresa;
        private System.Windows.Forms.TextBox TxbUsuario;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TxbSenha;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.PictureBox pictureLog1;
    }
}