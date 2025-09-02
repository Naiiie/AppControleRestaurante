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
            this.pictureIn2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIn2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureIn2
            // 
            this.pictureIn2.Image = ((System.Drawing.Image)(resources.GetObject("pictureIn2.Image")));
            this.pictureIn2.Location = new System.Drawing.Point(0, -5);
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
            this.Controls.Add(this.pictureIn2);
            this.Name = "PgnInicioExterno";
            this.Text = "PgnInicioExterno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureIn2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureIn2;
    }
}