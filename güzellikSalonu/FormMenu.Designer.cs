namespace güzellikSalonu
{
    partial class Menü
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnHizmet = new System.Windows.Forms.Button();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnMüsteriGecmis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "GÜZELLİK SALONU";
            // 
            // btnMusteri
            // 
            this.btnMusteri.Location = new System.Drawing.Point(81, 106);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(145, 40);
            this.btnMusteri.TabIndex = 1;
            this.btnMusteri.Text = "Müşteri İşlemleri";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.Location = new System.Drawing.Point(81, 167);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(145, 48);
            this.btnPersonel.TabIndex = 2;
            this.btnPersonel.Text = "Personel İşlemleri";
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnHizmet
            // 
            this.btnHizmet.Location = new System.Drawing.Point(288, 167);
            this.btnHizmet.Name = "btnHizmet";
            this.btnHizmet.Size = new System.Drawing.Size(130, 48);
            this.btnHizmet.TabIndex = 3;
            this.btnHizmet.Text = "Hizmet İşlemleri";
            this.btnHizmet.UseVisualStyleBackColor = true;
            this.btnHizmet.Click += new System.EventHandler(this.btnHizmet_Click);
            // 
            // btnRandevu
            // 
            this.btnRandevu.Location = new System.Drawing.Point(288, 106);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(130, 44);
            this.btnRandevu.TabIndex = 4;
            this.btnRandevu.Text = "Randevu İşlemleri";
            this.btnRandevu.UseVisualStyleBackColor = true;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // btnOdeme
            // 
            this.btnOdeme.Location = new System.Drawing.Point(81, 245);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(145, 44);
            this.btnOdeme.TabIndex = 5;
            this.btnOdeme.Text = "Ödeme İşlemleri";
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(289, 245);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(129, 44);
            this.btnRapor.TabIndex = 6;
            this.btnRapor.Text = "Raporlar";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnMüsteriGecmis
            // 
            this.btnMüsteriGecmis.Location = new System.Drawing.Point(81, 317);
            this.btnMüsteriGecmis.Name = "btnMüsteriGecmis";
            this.btnMüsteriGecmis.Size = new System.Drawing.Size(136, 43);
            this.btnMüsteriGecmis.TabIndex = 7;
            this.btnMüsteriGecmis.Text = "Müşteri Geçmişi";
            this.btnMüsteriGecmis.UseVisualStyleBackColor = true;
            this.btnMüsteriGecmis.Click += new System.EventHandler(this.btnMüsteriGecmis_Click);
            // 
            // Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 408);
            this.Controls.Add(this.btnMüsteriGecmis);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.btnRandevu);
            this.Controls.Add(this.btnHizmet);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.label1);
            this.Name = "Menü";
            this.Text = "Menü";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnHizmet;
        private System.Windows.Forms.Button btnRandevu;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnMüsteriGecmis;
    }
}