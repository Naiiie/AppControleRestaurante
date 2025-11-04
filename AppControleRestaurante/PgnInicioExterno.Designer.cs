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
            this.btnMensagens = new System.Windows.Forms.Button();
            this.btncatalogo = new System.Windows.Forms.Button();
            this.pictureIn2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIn2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMensagens
            // 
            this.btnMensagens.BackgroundImage = global::AppControleRestaurante.Properties.Resources.Captura_de_tela_2025_10_30_161901;
            this.btnMensagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMensagens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(198)))));
            this.btnMensagens.Location = new System.Drawing.Point(666, 83);
            this.btnMensagens.Name = "btnMensagens";
            this.btnMensagens.Size = new System.Drawing.Size(93, 79);
            this.btnMensagens.TabIndex = 5;
            this.btnMensagens.UseVisualStyleBackColor = true;
            this.btnMensagens.Click += new System.EventHandler(this.btnMensagens_Click);
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
            this.pictureIn2.Location = new System.Drawing.Point(1, 12);
            this.pictureIn2.Name = "pictureIn2";
            this.pictureIn2.Size = new System.Drawing.Size(800, 467);
            this.pictureIn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIn2.TabIndex = 0;
            this.pictureIn2.TabStop = false;
            // 
            // PgnInicioExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMensagens);
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
        private System.Windows.Forms.Button btnMensagens;
    }
}