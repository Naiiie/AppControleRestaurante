namespace AppControleRestaurante
{
    partial class PgnInicioEmpresa
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
            this.btnFinanças = new System.Windows.Forms.Button();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFinanças
            // 
            this.btnFinanças.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanças.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(198)))));
            this.btnFinanças.Image = global::AppControleRestaurante.Properties.Resources.Captura_de_tela_2025_10_30_142038;
            this.btnFinanças.Location = new System.Drawing.Point(117, 38);
            this.btnFinanças.Name = "btnFinanças";
            this.btnFinanças.Size = new System.Drawing.Size(57, 55);
            this.btnFinanças.TabIndex = 4;
            this.btnFinanças.UseVisualStyleBackColor = true;
            this.btnFinanças.Click += new System.EventHandler(this.btnFinanças_Click);
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(198)))));
            this.btnCatalogo.Image = global::AppControleRestaurante.Properties.Resources.Captura_de_tela_2025_10_30_142134;
            this.btnCatalogo.Location = new System.Drawing.Point(12, 38);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(75, 65);
            this.btnCatalogo.TabIndex = 5;
            this.btnCatalogo.UseVisualStyleBackColor = true;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(198)))));
            this.btnFuncionarios.Image = global::AppControleRestaurante.Properties.Resources.Captura_de_tela_2025_10_30_1449531;
            this.btnFuncionarios.Location = new System.Drawing.Point(716, 378);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(62, 60);
            this.btnFuncionarios.TabIndex = 6;
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            // 
            // PgnInicioEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppControleRestaurante.Properties.Resources.Captura_de_tela_2025_10_30_141450;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.btnCatalogo);
            this.Controls.Add(this.btnFinanças);
            this.DoubleBuffered = true;
            this.Name = "PgnInicioEmpresa";
            this.Text = "PgnInicioEmpresa";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFinanças;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Button btnFuncionarios;
    }
}