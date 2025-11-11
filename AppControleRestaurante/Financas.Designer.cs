namespace AppControleRestaurante
{
    partial class Financas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblTotalPeriodo;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblAte;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblTotalPeriodo = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblAte = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(16, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(160, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Relatório Financeiro";

            // lblDe
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(16, 45);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(26, 13);
            this.lblDe.TabIndex = 1;
            this.lblDe.Text = "De:";

            // dtInicio
            this.dtInicio.Location = new System.Drawing.Point(44, 40);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(120, 20);
            this.dtInicio.TabIndex = 2;
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // lblAte
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(180, 45);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(28, 13);
            this.lblAte.TabIndex = 3;
            this.lblAte.Text = "Até:";

            // dtFim
            this.dtFim.Location = new System.Drawing.Point(210, 40);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(120, 20);
            this.dtFim.TabIndex = 4;
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // btnAtualizar
            this.btnAtualizar.Location = new System.Drawing.Point(350, 38);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(80, 23);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Filtrar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);

            // dgvVendas
            this.dgvVendas.Location = new System.Drawing.Point(16, 75);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.Size = new System.Drawing.Size(600, 300);
            this.dgvVendas.TabIndex = 6;
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // lblTotalPeriodo
            this.lblTotalPeriodo.AutoSize = true;
            this.lblTotalPeriodo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPeriodo.Location = new System.Drawing.Point(16, 385);
            this.lblTotalPeriodo.Name = "lblTotalPeriodo";
            this.lblTotalPeriodo.Size = new System.Drawing.Size(180, 19);
            this.lblTotalPeriodo.TabIndex = 7;
            this.lblTotalPeriodo.Text = "Total no período: R$ 0,00";

            // FrmRelatorioFinanceiro
            this.ClientSize = new System.Drawing.Size(640, 420);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.lblAte);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.lblTotalPeriodo);
            this.Name = "FrmRelatorioFinanceiro";
            this.Text = "Relatório Financeiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
