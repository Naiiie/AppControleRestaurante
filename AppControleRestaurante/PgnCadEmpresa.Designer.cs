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
            this.CmbTamEmpresa = new System.Windows.Forms.ComboBox();
            this.TxbUsuario = new System.Windows.Forms.TextBox();
            this.TxbSenha = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.pictureLog1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxbNome
            // 
            this.TxbNome.BackColor = System.Drawing.Color.White;
            this.TxbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbNome.ForeColor = System.Drawing.Color.Black;
            this.TxbNome.Location = new System.Drawing.Point(22, 151);
            this.TxbNome.Margin = new System.Windows.Forms.Padding(2);
            this.TxbNome.Name = "TxbNome";
            this.TxbNome.Size = new System.Drawing.Size(231, 20);
            this.TxbNome.TabIndex = 0;
            // 
            // TxbCNPJ
            // 
            this.TxbCNPJ.BackColor = System.Drawing.Color.White;
            this.TxbCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbCNPJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxbCNPJ.ForeColor = System.Drawing.Color.Black;
            this.TxbCNPJ.Location = new System.Drawing.Point(22, 217);
            this.TxbCNPJ.Name = "TxbCNPJ";
            this.TxbCNPJ.Size = new System.Drawing.Size(171, 20);
            this.TxbCNPJ.TabIndex = 1;
            // 
            // TxbEmail
            // 
            this.TxbEmail.BackColor = System.Drawing.Color.White;
            this.TxbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbEmail.Location = new System.Drawing.Point(22, 286);
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(231, 20);
            this.TxbEmail.TabIndex = 2;
            this.TxbEmail.TextChanged += new System.EventHandler(this.TxbEmail_TextChanged);
            // 
            // TxbContato
            // 
            this.TxbContato.BackColor = System.Drawing.Color.White;
            this.TxbContato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbContato.Location = new System.Drawing.Point(22, 348);
            this.TxbContato.Name = "TxbContato";
            this.TxbContato.Size = new System.Drawing.Size(171, 20);
            this.TxbContato.TabIndex = 3;
            // 
            // CmbTamEmpresa
            // 
            this.CmbTamEmpresa.BackColor = System.Drawing.Color.White;
            this.CmbTamEmpresa.ForeColor = System.Drawing.Color.Black;
            this.CmbTamEmpresa.FormattingEnabled = true;
            this.CmbTamEmpresa.Items.AddRange(new object[] {
            "(1)- Micro Empresa",
            "(2)-Pequena Empresa",
            "(3)-Média Empresa",
            "(4)- Grande Empresa"});
            this.CmbTamEmpresa.Location = new System.Drawing.Point(125, 417);
            this.CmbTamEmpresa.Name = "CmbTamEmpresa";
            this.CmbTamEmpresa.Size = new System.Drawing.Size(251, 21);
            this.CmbTamEmpresa.TabIndex = 13;
            // 
            // TxbUsuario
            // 
            this.TxbUsuario.BackColor = System.Drawing.Color.White;
            this.TxbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbUsuario.Location = new System.Drawing.Point(485, 187);
            this.TxbUsuario.Name = "TxbUsuario";
            this.TxbUsuario.Size = new System.Drawing.Size(205, 20);
            this.TxbUsuario.TabIndex = 17;
            this.TxbUsuario.TextChanged += new System.EventHandler(this.TxbUsuario_TextChanged);
            // 
            // TxbSenha
            // 
            this.TxbSenha.BackColor = System.Drawing.Color.White;
            this.TxbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbSenha.Location = new System.Drawing.Point(485, 274);
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.Size = new System.Drawing.Size(169, 20);
            this.TxbSenha.TabIndex = 19;
            this.TxbSenha.UseSystemPasswordChar = true;
            this.TxbSenha.TextChanged += new System.EventHandler(this.TxbSenha_TextChanged_1);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(209)))));
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalvar.Font = new System.Drawing.Font("Noto Serif Georgian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.Color.Black;
            this.BtnSalvar.Location = new System.Drawing.Point(534, 364);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(197, 53);
            this.BtnSalvar.TabIndex = 20;
            this.BtnSalvar.Text = "SALVAR e ENTRAR";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click_1);
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
            this.pictureLog1.Click += new System.EventHandler(this.pictureLog1_Click);
            // 
            // PgnCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxbSenha);
            this.Controls.Add(this.TxbUsuario);
            this.Controls.Add(this.CmbTamEmpresa);
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
        private System.Windows.Forms.TextBox TxbUsuario;
        private System.Windows.Forms.TextBox TxbSenha;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.PictureBox pictureLog1;
        public System.Windows.Forms.ComboBox CmbTamEmpresa;
    }
}