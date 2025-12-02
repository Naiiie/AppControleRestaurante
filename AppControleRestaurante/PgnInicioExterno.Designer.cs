namespace AppControleRestaurante
{
    partial class PgnInicioExterno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PgnInicioExterno));
            this.btnLancaPedido = new System.Windows.Forms.Button();
            this.btncatalogo = new System.Windows.Forms.Button();
            this.pictureIn2 = new System.Windows.Forms.PictureBox();
            this.btnSair3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIn2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLancaPedido
            // 
            this.btnLancaPedido.BackgroundImage = global::AppControleRestaurante.Properties.Resources.Captura_de_tela_2025_12_01_162513;
            this.btnLancaPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancaPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(207)))), ((int)(((byte)(200)))));
            this.btnLancaPedido.Location = new System.Drawing.Point(695, 97);
            this.btnLancaPedido.Name = "btnLancaPedido";
            this.btnLancaPedido.Size = new System.Drawing.Size(60, 67);
            this.btnLancaPedido.TabIndex = 6;
            this.btnLancaPedido.UseVisualStyleBackColor = true;
            this.btnLancaPedido.Click += new System.EventHandler(this.btnLancaPedido_Click);
            // 
            // btncatalogo
            // 
            this.btncatalogo.AllowDrop = true;
            this.btncatalogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(198)))));
            this.btncatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(198)))));
            this.btncatalogo.Image = ((System.Drawing.Image)(resources.GetObject("btncatalogo.Image")));
            this.btncatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncatalogo.Location = new System.Drawing.Point(676, 22);
            this.btncatalogo.Name = "btncatalogo";
            this.btncatalogo.Size = new System.Drawing.Size(94, 69);
            this.btncatalogo.TabIndex = 4;
            this.btncatalogo.UseVisualStyleBackColor = false;
            this.btncatalogo.Click += new System.EventHandler(this.btncatalogo_Click);
            // 
            // pictureIn2
            // 
            this.pictureIn2.Image = ((System.Drawing.Image)(resources.GetObject("pictureIn2.Image")));
            this.pictureIn2.Location = new System.Drawing.Point(-1, 0);
            this.pictureIn2.Name = "pictureIn2";
            this.pictureIn2.Size = new System.Drawing.Size(804, 450);
            this.pictureIn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIn2.TabIndex = 0;
            this.pictureIn2.TabStop = false;
            // 
            // btnSair3
            // 
            this.btnSair3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(207)))), ((int)(((byte)(200)))));
            this.btnSair3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair3.Font = new System.Drawing.Font("Noto Sans Georgian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair3.Location = new System.Drawing.Point(12, 22);
            this.btnSair3.Name = "btnSair3";
            this.btnSair3.Size = new System.Drawing.Size(75, 46);
            this.btnSair3.TabIndex = 7;
            this.btnSair3.Text = "Sair";
            this.btnSair3.UseVisualStyleBackColor = false;
            this.btnSair3.Click += new System.EventHandler(this.btnSair3_Click);
            // 
            // PgnInicioExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair3);
            this.Controls.Add(this.btnLancaPedido);
            this.Controls.Add(this.btncatalogo);
            this.Controls.Add(this.pictureIn2);
            this.Name = "PgnInicioExterno";
            this.Text = "PgnInicioExterno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureIn2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureIn2;
        private System.Windows.Forms.Button btncatalogo;
        private System.Windows.Forms.Button btnLancaPedido;
        private System.Windows.Forms.Button btnSair3;
    }
}