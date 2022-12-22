namespace Katmanli_Mimari
{
    partial class frmYonlendir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYonlendir));
            this.btnDesSayfasi = new System.Windows.Forms.Button();
            this.btnOgrenciSayfasi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDesSayfasi
            // 
            this.btnDesSayfasi.BackColor = System.Drawing.Color.Crimson;
            this.btnDesSayfasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDesSayfasi.ForeColor = System.Drawing.Color.White;
            this.btnDesSayfasi.Location = new System.Drawing.Point(53, 38);
            this.btnDesSayfasi.Name = "btnDesSayfasi";
            this.btnDesSayfasi.Size = new System.Drawing.Size(240, 216);
            this.btnDesSayfasi.TabIndex = 0;
            this.btnDesSayfasi.Text = "Ders Sayfasına Git";
            this.btnDesSayfasi.UseVisualStyleBackColor = false;
            this.btnDesSayfasi.Click += new System.EventHandler(this.btnDesSayfasi_Click);
            // 
            // btnOgrenciSayfasi
            // 
            this.btnOgrenciSayfasi.BackColor = System.Drawing.Color.Crimson;
            this.btnOgrenciSayfasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.btnOgrenciSayfasi.ForeColor = System.Drawing.Color.White;
            this.btnOgrenciSayfasi.Location = new System.Drawing.Point(310, 38);
            this.btnOgrenciSayfasi.Name = "btnOgrenciSayfasi";
            this.btnOgrenciSayfasi.Size = new System.Drawing.Size(215, 216);
            this.btnOgrenciSayfasi.TabIndex = 1;
            this.btnOgrenciSayfasi.Text = "Ögrenci Sayfasına Git";
            this.btnOgrenciSayfasi.UseVisualStyleBackColor = false;
            this.btnOgrenciSayfasi.Click += new System.EventHandler(this.btnOgrenciSayfasi_Click);
            // 
            // frmYonlendir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(609, 299);
            this.Controls.Add(this.btnOgrenciSayfasi);
            this.Controls.Add(this.btnDesSayfasi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmYonlendir";
            this.Text = "Yönlendirme Sayfası";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDesSayfasi;
        private System.Windows.Forms.Button btnOgrenciSayfasi;
    }
}