namespace AppControleRestaurante
{
    partial class CadCatalogo
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
            this.CmbAtividadeP = new System.Windows.Forms.ComboBox();
            this.btnSalvarP = new System.Windows.Forms.Button();
            this.cmbCategoriaP = new System.Windows.Forms.ComboBox();
            this.txbNomeP = new System.Windows.Forms.TextBox();
            this.txbDescricaoP = new System.Windows.Forms.TextBox();
            this.txbCustoP = new System.Windows.Forms.TextBox();
            this.txbValorP = new System.Windows.Forms.TextBox();
            this.txbEstoqueP = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltarCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbAtividadeP
            // 
            this.CmbAtividadeP.FormattingEnabled = true;
            this.CmbAtividadeP.Items.AddRange(new object[] {
            "(1) ATIVO",
            "(2) INATIVO"});
            this.CmbAtividadeP.Location = new System.Drawing.Point(464, 253);
            this.CmbAtividadeP.Name = "CmbAtividadeP";
            this.CmbAtividadeP.Size = new System.Drawing.Size(246, 21);
            this.CmbAtividadeP.TabIndex = 14;
            this.CmbAtividadeP.SelectedIndexChanged += new System.EventHandler(this.CmbAtividadeP_SelectedIndexChanged);
            // 
            // btnSalvarP
            // 
            this.btnSalvarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(198)))));
            this.btnSalvarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarP.Font = new System.Drawing.Font("Noto Sans Georgian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarP.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarP.Location = new System.Drawing.Point(545, 383);
            this.btnSalvarP.Name = "btnSalvarP";
            this.btnSalvarP.Size = new System.Drawing.Size(200, 55);
            this.btnSalvarP.TabIndex = 17;
            this.btnSalvarP.Text = "Salvar Produto";
            this.btnSalvarP.UseVisualStyleBackColor = false;
            this.btnSalvarP.Click += new System.EventHandler(this.btnSalvarP_Click);
            // 
            // cmbCategoriaP
            // 
            this.cmbCategoriaP.FormattingEnabled = true;
            this.cmbCategoriaP.Items.AddRange(new object[] {
            "(1) Bebidas",
            "(2) Porções",
            "(3) Pratos",
            "(4) Sobremesas",
            "(5)Outros"});
            this.cmbCategoriaP.Location = new System.Drawing.Point(464, 152);
            this.cmbCategoriaP.Name = "cmbCategoriaP";
            this.cmbCategoriaP.Size = new System.Drawing.Size(246, 21);
            this.cmbCategoriaP.TabIndex = 18;
            // 
            // txbNomeP
            // 
            this.txbNomeP.Location = new System.Drawing.Point(26, 97);
            this.txbNomeP.Name = "txbNomeP";
            this.txbNomeP.Size = new System.Drawing.Size(201, 20);
            this.txbNomeP.TabIndex = 21;
            // 
            // txbDescricaoP
            // 
            this.txbDescricaoP.Location = new System.Drawing.Point(26, 170);
            this.txbDescricaoP.Name = "txbDescricaoP";
            this.txbDescricaoP.Size = new System.Drawing.Size(201, 20);
            this.txbDescricaoP.TabIndex = 22;
            // 
            // txbCustoP
            // 
            this.txbCustoP.Location = new System.Drawing.Point(26, 302);
            this.txbCustoP.Name = "txbCustoP";
            this.txbCustoP.Size = new System.Drawing.Size(188, 20);
            this.txbCustoP.TabIndex = 23;
            // 
            // txbValorP
            // 
            this.txbValorP.Location = new System.Drawing.Point(26, 367);
            this.txbValorP.Name = "txbValorP";
            this.txbValorP.Size = new System.Drawing.Size(201, 20);
            this.txbValorP.TabIndex = 24;
            // 
            // txbEstoqueP
            // 
            this.txbEstoqueP.Location = new System.Drawing.Point(455, 347);
            this.txbEstoqueP.Name = "txbEstoqueP";
            this.txbEstoqueP.Size = new System.Drawing.Size(141, 20);
            this.txbEstoqueP.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AppControleRestaurante.Properties.Resources.Captura_de_tela_2025_12_01_153945;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-20, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(842, 458);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnVoltarCat
            // 
            this.btnVoltarCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(207)))), ((int)(((byte)(200)))));
            this.btnVoltarCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltarCat.Location = new System.Drawing.Point(688, 23);
            this.btnVoltarCat.Name = "btnVoltarCat";
            this.btnVoltarCat.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarCat.TabIndex = 26;
            this.btnVoltarCat.Text = "Voltar";
            this.btnVoltarCat.UseVisualStyleBackColor = false;
            this.btnVoltarCat.Click += new System.EventHandler(this.btnVoltarCat_Click);
            // 
            // CadCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltarCat);
            this.Controls.Add(this.txbEstoqueP);
            this.Controls.Add(this.txbValorP);
            this.Controls.Add(this.txbCustoP);
            this.Controls.Add(this.txbDescricaoP);
            this.Controls.Add(this.txbNomeP);
            this.Controls.Add(this.cmbCategoriaP);
            this.Controls.Add(this.btnSalvarP);
            this.Controls.Add(this.CmbAtividadeP);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CadCatalogo";
            this.Text = "CadCatalogo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CmbAtividadeP;
        private System.Windows.Forms.Button btnSalvarP;
        private System.Windows.Forms.ComboBox cmbCategoriaP;
        private System.Windows.Forms.TextBox txbNomeP;
        private System.Windows.Forms.TextBox txbDescricaoP;
        private System.Windows.Forms.TextBox txbCustoP;
        private System.Windows.Forms.TextBox txbValorP;
        private System.Windows.Forms.TextBox txbEstoqueP;
        private System.Windows.Forms.Button btnVoltarCat;
    }
}