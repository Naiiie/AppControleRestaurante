namespace AppControleRestaurante
{
    partial class FrmLancarPedido
    {
        /// <summary>
        /// Variáveis de design necessárias.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpeza de recursos usados.
        /// </summary>
        /// <param name="disposing">true se recursos gerenciados devem ser descartados; caso contrário, false.</param>
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
        /// Método necessário para o suporte do Designer.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProduto = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txbPesquisaCatalogo = new System.Windows.Forms.TextBox();
            this.btnPesquisarP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPesquisa.Location = new System.Drawing.Point(26, 22);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(67, 19);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Pesquisar:";
            // 
            // txbPesquisaCatalogo
            // 
            this.txbPesquisaCatalogo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbPesquisaCatalogo.Location = new System.Drawing.Point(99, 19);
            this.txbPesquisaCatalogo.Name = "txbPesquisaCatalogo";
            this.txbPesquisaCatalogo.Size = new System.Drawing.Size(200, 25);
            this.txbPesquisaCatalogo.TabIndex = 1;
            // 
            // btnPesquisarP
            // 
            this.btnPesquisarP.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPesquisarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPesquisarP.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarP.Location = new System.Drawing.Point(305, 19);
            this.btnPesquisarP.Name = "btnPesquisarP";
            this.btnPesquisarP.Size = new System.Drawing.Size(90, 25);
            this.btnPesquisarP.TabIndex = 2;
            this.btnPesquisarP.Text = "Buscar";
            this.btnPesquisarP.UseVisualStyleBackColor = false;
            this.btnPesquisarP.Click += new System.EventHandler(this.btnPesquisarP_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProduto.Location = new System.Drawing.Point(26, 60);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(62, 19);
            this.lblProduto.TabIndex = 3;
            this.lblProduto.Text = "Produto:";
            // 
            // cmbProduto
            // 
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(86, 57);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(258, 25);
            this.cmbProduto.TabIndex = 4;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQuantidade.Location = new System.Drawing.Point(26, 94);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(84, 19);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numQuantidade.Location = new System.Drawing.Point(116, 93);
            this.numQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(69, 25);
            this.numQuantidade.TabIndex = 6;
            this.numQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdicionarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdicionarItem.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarItem.Location = new System.Drawing.Point(191, 90);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(153, 28);
            this.btnAdicionarItem.TabIndex = 7;
            this.btnAdicionarItem.Text = "Adicionar ao Pedido";
            this.btnAdicionarItem.UseVisualStyleBackColor = false;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.BackgroundColor = System.Drawing.Color.White;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(30, 132);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.RowTemplate.Height = 25;
            this.dgvItens.Size = new System.Drawing.Size(429, 173);
            this.dgvItens.TabIndex = 8;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(305, 321);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(154, 30);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Finalizar Pedido";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotal.Location = new System.Drawing.Point(26, 327);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 20);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total: R$ 0";
            // 
            // FrmLancarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 395);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.btnAdicionarItem);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnPesquisarP);
            this.Controls.Add(this.txbPesquisaCatalogo);
            this.Controls.Add(this.lblPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLancarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de Pedido";
            this.Load += new System.EventHandler(this.FrmLancarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPesquisarP;
        private System.Windows.Forms.TextBox txbPesquisaCatalogo;
        private System.Windows.Forms.Label lblPesquisa;

    }
}
