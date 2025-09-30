namespace AppControleRestaurante
{
    partial class Catalogo
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
            this.components = new System.ComponentModel.Container();
            this.btnCadP = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.custoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cJ3027473PR2DataSet = new AppControleRestaurante.CJ3027473PR2DataSet();
            this.catalogoTableAdapter = new AppControleRestaurante.CJ3027473PR2DataSetTableAdapters.CatalogoTableAdapter();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027473PR2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadP
            // 
            this.btnCadP.AllowDrop = true;
            this.btnCadP.Location = new System.Drawing.Point(627, 148);
            this.btnCadP.Name = "btnCadP";
            this.btnCadP.Size = new System.Drawing.Size(174, 36);
            this.btnCadP.TabIndex = 0;
            this.btnCadP.Text = "Inserir Novo Produto";
            this.btnCadP.UseVisualStyleBackColor = true;
            this.btnCadP.Click += new System.EventHandler(this.CadProduto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItemDataGridViewTextBoxColumn,
            this.empresaIdDataGridViewTextBoxColumn,
            this.nomeItemDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.custoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.catalogoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 260);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idItemDataGridViewTextBoxColumn
            // 
            this.idItemDataGridViewTextBoxColumn.DataPropertyName = "IdItem";
            this.idItemDataGridViewTextBoxColumn.HeaderText = "IdItem";
            this.idItemDataGridViewTextBoxColumn.Name = "idItemDataGridViewTextBoxColumn";
            this.idItemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empresaIdDataGridViewTextBoxColumn
            // 
            this.empresaIdDataGridViewTextBoxColumn.DataPropertyName = "EmpresaId";
            this.empresaIdDataGridViewTextBoxColumn.HeaderText = "EmpresaId";
            this.empresaIdDataGridViewTextBoxColumn.Name = "empresaIdDataGridViewTextBoxColumn";
            // 
            // nomeItemDataGridViewTextBoxColumn
            // 
            this.nomeItemDataGridViewTextBoxColumn.DataPropertyName = "NomeItem";
            this.nomeItemDataGridViewTextBoxColumn.HeaderText = "NomeItem";
            this.nomeItemDataGridViewTextBoxColumn.Name = "nomeItemDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            // 
            // custoDataGridViewTextBoxColumn
            // 
            this.custoDataGridViewTextBoxColumn.DataPropertyName = "custo";
            this.custoDataGridViewTextBoxColumn.HeaderText = "custo";
            this.custoDataGridViewTextBoxColumn.Name = "custoDataGridViewTextBoxColumn";
            // 
            // catalogoBindingSource
            // 
            this.catalogoBindingSource.DataMember = "Catalogo";
            this.catalogoBindingSource.DataSource = this.cJ3027473PR2DataSet;
            // 
            // cJ3027473PR2DataSet
            // 
            this.cJ3027473PR2DataSet.DataSetName = "CJ3027473PR2DataSet";
            this.cJ3027473PR2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catalogoTableAdapter
            // 
            this.catalogoTableAdapter.ClearBeforeFill = true;
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Location = new System.Drawing.Point(12, 164);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(265, 20);
            this.txbPesquisa.TabIndex = 4;
            this.txbPesquisa.TextChanged += new System.EventHandler(this.btnPesquisarP_Click);
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCadP);
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027473PR2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CJ3027473PR2DataSet cJ3027473PR2DataSet;
        private System.Windows.Forms.BindingSource catalogoBindingSource;
        private CJ3027473PR2DataSetTableAdapters.CatalogoTableAdapter catalogoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txbPesquisa;
    }
}