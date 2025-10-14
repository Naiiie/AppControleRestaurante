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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PgnInicioEmpresa));
            this.pictureIn1 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btncatalogo = new System.Windows.Forms.Button();
            this.btnFinanças = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIn1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureIn1
            // 
            this.pictureIn1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureIn1.Image = ((System.Drawing.Image)(resources.GetObject("pictureIn1.Image")));
            this.pictureIn1.Location = new System.Drawing.Point(12, 0);
            this.pictureIn1.Name = "pictureIn1";
            this.pictureIn1.Size = new System.Drawing.Size(803, 462);
            this.pictureIn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIn1.TabIndex = 0;
            this.pictureIn1.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.SlateGray;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(47, 450);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(47, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 450);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // btncatalogo
            // 
            this.btncatalogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncatalogo.BackColor = System.Drawing.SystemColors.InfoText;
            this.btncatalogo.Image = ((System.Drawing.Image)(resources.GetObject("btncatalogo.Image")));
            this.btncatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncatalogo.Location = new System.Drawing.Point(517, 0);
            this.btncatalogo.Name = "btncatalogo";
            this.btncatalogo.Size = new System.Drawing.Size(60, 65);
            this.btncatalogo.TabIndex = 3;
            this.btncatalogo.UseVisualStyleBackColor = false;
            this.btncatalogo.Click += new System.EventHandler(this.btncatalogo_Click);
            // 
            // btnFinanças
            // 
            this.btnFinanças.Image = global::AppControleRestaurante.Properties.Resources.Captura_de_tela_2025_10_14_102820;
            this.btnFinanças.Location = new System.Drawing.Point(635, 0);
            this.btnFinanças.Name = "btnFinanças";
            this.btnFinanças.Size = new System.Drawing.Size(63, 65);
            this.btnFinanças.TabIndex = 4;
            this.btnFinanças.UseVisualStyleBackColor = true;
            this.btnFinanças.Click += new System.EventHandler(this.btnFinanças_Click);
            // 
            // PgnInicioEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinanças);
            this.Controls.Add(this.btncatalogo);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pictureIn1);
            this.Name = "PgnInicioEmpresa";
            this.Text = "PgnInicioEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureIn1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureIn1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btncatalogo;
        private System.Windows.Forms.Button btnFinanças;
    }
}