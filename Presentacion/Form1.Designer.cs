namespace Presentacion
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvArt = new System.Windows.Forms.DataGridView();
            this.PicArt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicArt)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvArt
            // 
            this.DgvArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DgvArt.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArt.Location = new System.Drawing.Point(45, 22);
            this.DgvArt.Name = "DgvArt";
            this.DgvArt.RowHeadersWidth = 51;
            this.DgvArt.RowTemplate.Height = 24;
            this.DgvArt.Size = new System.Drawing.Size(738, 177);
            this.DgvArt.TabIndex = 0;
            this.DgvArt.SelectionChanged += new System.EventHandler(this.DgvArt_SelectionChanged);
            // 
            // PicArt
            // 
            this.PicArt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PicArt.Location = new System.Drawing.Point(270, 366);
            this.PicArt.Name = "PicArt";
            this.PicArt.Size = new System.Drawing.Size(277, 303);
            this.PicArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicArt.TabIndex = 1;
            this.PicArt.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 794);
            this.Controls.Add(this.PicArt);
            this.Controls.Add(this.DgvArt);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvArt;
        private System.Windows.Forms.PictureBox PicArt;
    }
}

