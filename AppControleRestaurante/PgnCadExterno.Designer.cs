namespace AppControleRestaurante
{
    partial class PgnCadExterno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PgnCadExterno));
            this.txbUsuario2 = new System.Windows.Forms.TextBox();
            this.txbSenha2 = new System.Windows.Forms.TextBox();
            this.txbNomeFuncionario = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnSalvar2 = new System.Windows.Forms.Button();
            this.txbEmailFuncionario = new System.Windows.Forms.TextBox();
            this.pictureLog2 = new System.Windows.Forms.PictureBox();
            this.btnVoltar3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLog2)).BeginInit();
            this.SuspendLayout();
            // 
            // txbUsuario2
            // 
            this.txbUsuario2.Location = new System.Drawing.Point(496, 187);
            this.txbUsuario2.Name = "txbUsuario2";
            this.txbUsuario2.Size = new System.Drawing.Size(165, 20);
            this.txbUsuario2.TabIndex = 7;
            // 
            // txbSenha2
            // 
            this.txbSenha2.Location = new System.Drawing.Point(496, 281);
            this.txbSenha2.Name = "txbSenha2";
            this.txbSenha2.PasswordChar = '*';
            this.txbSenha2.Size = new System.Drawing.Size(165, 20);
            this.txbSenha2.TabIndex = 8;
            // 
            // txbNomeFuncionario
            // 
            this.txbNomeFuncionario.Location = new System.Drawing.Point(38, 153);
            this.txbNomeFuncionario.Name = "txbNomeFuncionario";
            this.txbNomeFuncionario.Size = new System.Drawing.Size(201, 20);
            this.txbNomeFuncionario.TabIndex = 10;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(66, 364);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(228, 20);
            this.txbID.TabIndex = 11;
            this.txbID.Text = "ID da empresa:";
            this.txbID.Click += new System.EventHandler(this.txbID_Click);
            this.txbID.TextChanged += new System.EventHandler(this.txbID_TextChanged);
            // 
            // btnSalvar2
            // 
            this.btnSalvar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(217)))), ((int)(((byte)(211)))));
            this.btnSalvar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar2.Font = new System.Drawing.Font("Noto Serif Georgian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar2.Location = new System.Drawing.Point(521, 364);
            this.btnSalvar2.Name = "btnSalvar2";
            this.btnSalvar2.Size = new System.Drawing.Size(197, 60);
            this.btnSalvar2.TabIndex = 12;
            this.btnSalvar2.Text = "SALVAR E ENTRAR";
            this.btnSalvar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar2.UseVisualStyleBackColor = false;
            this.btnSalvar2.Click += new System.EventHandler(this.btnSalvar2_Click);
            // 
            // txbEmailFuncionario
            // 
            this.txbEmailFuncionario.Location = new System.Drawing.Point(38, 255);
            this.txbEmailFuncionario.Name = "txbEmailFuncionario";
            this.txbEmailFuncionario.Size = new System.Drawing.Size(201, 20);
            this.txbEmailFuncionario.TabIndex = 14;
            // 
            // pictureLog2
            // 
            this.pictureLog2.Image = ((System.Drawing.Image)(resources.GetObject("pictureLog2.Image")));
            this.pictureLog2.Location = new System.Drawing.Point(-2, -3);
            this.pictureLog2.Name = "pictureLog2";
            this.pictureLog2.Size = new System.Drawing.Size(800, 452);
            this.pictureLog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLog2.TabIndex = 0;
            this.pictureLog2.TabStop = false;
            // 
            // btnVoltar3
            // 
            this.btnVoltar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(207)))), ((int)(((byte)(200)))));
            this.btnVoltar3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar3.Font = new System.Drawing.Font("Noto Sans Georgian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar3.Location = new System.Drawing.Point(694, 31);
            this.btnVoltar3.Name = "btnVoltar3";
            this.btnVoltar3.Size = new System.Drawing.Size(75, 34);
            this.btnVoltar3.TabIndex = 15;
            this.btnVoltar3.Text = "Voltar";
            this.btnVoltar3.UseVisualStyleBackColor = false;
            this.btnVoltar3.Click += new System.EventHandler(this.btnVoltar3_Click);
            // 
            // PgnCadExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar3);
            this.Controls.Add(this.txbEmailFuncionario);
            this.Controls.Add(this.btnSalvar2);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.txbNomeFuncionario);
            this.Controls.Add(this.txbSenha2);
            this.Controls.Add(this.txbUsuario2);
            this.Controls.Add(this.pictureLog2);
            this.Name = "PgnCadExterno";
            this.Text = "PgnLoginExterno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLog2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLog2;
        private System.Windows.Forms.TextBox txbUsuario2;
        private System.Windows.Forms.TextBox txbSenha2;
        private System.Windows.Forms.TextBox txbNomeFuncionario;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Button btnSalvar2;
        private System.Windows.Forms.TextBox txbEmailFuncionario;
        private System.Windows.Forms.Button btnVoltar3;
    }
}