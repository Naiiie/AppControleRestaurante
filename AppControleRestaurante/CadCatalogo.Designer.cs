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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNomeP = new System.Windows.Forms.Label();
            this.lblDescricaoP = new System.Windows.Forms.Label();
            this.lblAtividadeP = new System.Windows.Forms.Label();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.lblValorCusto = new System.Windows.Forms.Label();
            this.CmbAtividadeP = new System.Windows.Forms.ComboBox();
            this.btnSalvarP = new System.Windows.Forms.Button();
            this.cmbCategoriaP = new System.Windows.Forms.ComboBox();
            this.LblCategoriaP = new System.Windows.Forms.Label();
            this.txbNomeP = new System.Windows.Forms.TextBox();
            this.txbDescricaoP = new System.Windows.Forms.TextBox();
            this.txbCustoP = new System.Windows.Forms.TextBox();
            this.txbValorP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 439);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNomeP
            // 
            this.lblNomeP.AutoSize = true;
            this.lblNomeP.Location = new System.Drawing.Point(36, 35);
            this.lblNomeP.Name = "lblNomeP";
            this.lblNomeP.Size = new System.Drawing.Size(93, 13);
            this.lblNomeP.TabIndex = 1;
            this.lblNomeP.Text = "Nome do Produto:";
            this.lblNomeP.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescricaoP
            // 
            this.lblDescricaoP.AutoSize = true;
            this.lblDescricaoP.Location = new System.Drawing.Point(36, 110);
            this.lblDescricaoP.Name = "lblDescricaoP";
            this.lblDescricaoP.Size = new System.Drawing.Size(109, 13);
            this.lblDescricaoP.TabIndex = 4;
            this.lblDescricaoP.Text = "Descrição do produto";
            // 
            // lblAtividadeP
            // 
            this.lblAtividadeP.AutoSize = true;
            this.lblAtividadeP.Location = new System.Drawing.Point(36, 344);
            this.lblAtividadeP.Name = "lblAtividadeP";
            this.lblAtividadeP.Size = new System.Drawing.Size(47, 13);
            this.lblAtividadeP.TabIndex = 5;
            this.lblAtividadeP.Text = "Produto:";
            this.lblAtividadeP.Click += new System.EventHandler(this.lblAtividadeP_Click);
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Location = new System.Drawing.Point(36, 262);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(83, 13);
            this.lblValorVenda.TabIndex = 6;
            this.lblValorVenda.Text = "Valor de Venda:";
            // 
            // lblValorCusto
            // 
            this.lblValorCusto.AutoSize = true;
            this.lblValorCusto.Location = new System.Drawing.Point(36, 190);
            this.lblValorCusto.Name = "lblValorCusto";
            this.lblValorCusto.Size = new System.Drawing.Size(75, 13);
            this.lblValorCusto.TabIndex = 7;
            this.lblValorCusto.Text = "Valor de custo";
            // 
            // CmbAtividadeP
            // 
            this.CmbAtividadeP.FormattingEnabled = true;
            this.CmbAtividadeP.Items.AddRange(new object[] {
            "(1) ATIVO",
            "(2) INATIVO"});
            this.CmbAtividadeP.Location = new System.Drawing.Point(39, 360);
            this.CmbAtividadeP.Name = "CmbAtividadeP";
            this.CmbAtividadeP.Size = new System.Drawing.Size(246, 21);
            this.CmbAtividadeP.TabIndex = 14;
            // 
            // btnSalvarP
            // 
            this.btnSalvarP.Location = new System.Drawing.Point(540, 384);
            this.btnSalvarP.Name = "btnSalvarP";
            this.btnSalvarP.Size = new System.Drawing.Size(117, 23);
            this.btnSalvarP.TabIndex = 17;
            this.btnSalvarP.Text = "Salvar Produto";
            this.btnSalvarP.UseVisualStyleBackColor = true;
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
            this.cmbCategoriaP.Location = new System.Drawing.Point(469, 122);
            this.cmbCategoriaP.Name = "cmbCategoriaP";
            this.cmbCategoriaP.Size = new System.Drawing.Size(246, 21);
            this.cmbCategoriaP.TabIndex = 18;
            // 
            // LblCategoriaP
            // 
            this.LblCategoriaP.AutoSize = true;
            this.LblCategoriaP.Location = new System.Drawing.Point(475, 78);
            this.LblCategoriaP.Name = "LblCategoriaP";
            this.LblCategoriaP.Size = new System.Drawing.Size(59, 13);
            this.LblCategoriaP.TabIndex = 20;
            this.LblCategoriaP.Text = "CategoriaP";
            // 
            // txbNomeP
            // 
            this.txbNomeP.Location = new System.Drawing.Point(39, 75);
            this.txbNomeP.Name = "txbNomeP";
            this.txbNomeP.Size = new System.Drawing.Size(100, 20);
            this.txbNomeP.TabIndex = 21;
            // 
            // txbDescricaoP
            // 
            this.txbDescricaoP.Location = new System.Drawing.Point(39, 152);
            this.txbDescricaoP.Name = "txbDescricaoP";
            this.txbDescricaoP.Size = new System.Drawing.Size(100, 20);
            this.txbDescricaoP.TabIndex = 22;
            // 
            // txbCustoP
            // 
            this.txbCustoP.Location = new System.Drawing.Point(39, 227);
            this.txbCustoP.Name = "txbCustoP";
            this.txbCustoP.Size = new System.Drawing.Size(100, 20);
            this.txbCustoP.TabIndex = 23;
            // 
            // txbValorP
            // 
            this.txbValorP.Location = new System.Drawing.Point(39, 295);
            this.txbValorP.Name = "txbValorP";
            this.txbValorP.Size = new System.Drawing.Size(100, 20);
            this.txbValorP.TabIndex = 24;
            // 
            // CadCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbValorP);
            this.Controls.Add(this.txbCustoP);
            this.Controls.Add(this.txbDescricaoP);
            this.Controls.Add(this.txbNomeP);
            this.Controls.Add(this.LblCategoriaP);
            this.Controls.Add(this.cmbCategoriaP);
            this.Controls.Add(this.btnSalvarP);
            this.Controls.Add(this.CmbAtividadeP);
            this.Controls.Add(this.lblValorCusto);
            this.Controls.Add(this.lblValorVenda);
            this.Controls.Add(this.lblAtividadeP);
            this.Controls.Add(this.lblDescricaoP);
            this.Controls.Add(this.lblNomeP);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CadCatalogo";
            this.Text = "CadCatalogo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNomeP;
        private System.Windows.Forms.Label lblDescricaoP;
        private System.Windows.Forms.Label lblAtividadeP;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Label lblValorCusto;
        private System.Windows.Forms.ComboBox CmbAtividadeP;
        private System.Windows.Forms.Button btnSalvarP;
        private System.Windows.Forms.ComboBox cmbCategoriaP;
        private System.Windows.Forms.Label LblCategoriaP;
        private System.Windows.Forms.TextBox txbNomeP;
        private System.Windows.Forms.TextBox txbDescricaoP;
        private System.Windows.Forms.TextBox txbCustoP;
        private System.Windows.Forms.TextBox txbValorP;
    }
}