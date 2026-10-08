namespace güzellikSalonu
{
    partial class FormRapor
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
            this.btnGunluk = new System.Windows.Forms.Button();
            this.btnGelir = new System.Windows.Forms.Button();
            this.btnPahali = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateGunluk = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGunlukGelir = new System.Windows.Forms.Button();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTarihlerArasiGelir = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGunluk
            // 
            this.btnGunluk.Location = new System.Drawing.Point(93, 12);
            this.btnGunluk.Name = "btnGunluk";
            this.btnGunluk.Size = new System.Drawing.Size(176, 63);
            this.btnGunluk.TabIndex = 0;
            this.btnGunluk.Text = "Günlük Randevular";
            this.btnGunluk.UseVisualStyleBackColor = true;
            this.btnGunluk.Click += new System.EventHandler(this.btnGunluk_Click);
            // 
            // btnGelir
            // 
            this.btnGelir.Location = new System.Drawing.Point(93, 93);
            this.btnGelir.Name = "btnGelir";
            this.btnGelir.Size = new System.Drawing.Size(176, 53);
            this.btnGelir.TabIndex = 1;
            this.btnGelir.Text = "Toplam Gelir";
            this.btnGelir.UseVisualStyleBackColor = true;
            this.btnGelir.Click += new System.EventHandler(this.btnGelir_Click);
            // 
            // btnPahali
            // 
            this.btnPahali.Location = new System.Drawing.Point(93, 167);
            this.btnPahali.Name = "btnPahali";
            this.btnPahali.Size = new System.Drawing.Size(176, 54);
            this.btnPahali.TabIndex = 2;
            this.btnPahali.Text = "En Pahalı Hizmet";
            this.btnPahali.UseVisualStyleBackColor = true;
            this.btnPahali.Click += new System.EventHandler(this.btnPahali_Click);
            // 
            // btnStok
            // 
            this.btnStok.Location = new System.Drawing.Point(93, 241);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(176, 62);
            this.btnStok.TabIndex = 3;
            this.btnStok.Text = "Stokta Olan Ürünler";
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 344);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 218);
            this.dataGridView1.TabIndex = 4;
            // 
            // dateGunluk
            // 
            this.dateGunluk.Location = new System.Drawing.Point(608, 72);
            this.dateGunluk.Name = "dateGunluk";
            this.dateGunluk.Size = new System.Drawing.Size(200, 22);
            this.dateGunluk.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Günlük Gelir ";
            // 
            // btnGunlukGelir
            // 
            this.btnGunlukGelir.Location = new System.Drawing.Point(905, 54);
            this.btnGunlukGelir.Name = "btnGunlukGelir";
            this.btnGunlukGelir.Size = new System.Drawing.Size(129, 62);
            this.btnGunlukGelir.TabIndex = 7;
            this.btnGunlukGelir.Text = "Günlük Gelir";
            this.btnGunlukGelir.UseVisualStyleBackColor = true;
            this.btnGunlukGelir.Click += new System.EventHandler(this.btnGunlukGelir_Click);
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Location = new System.Drawing.Point(599, 161);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(200, 22);
            this.dateBaslangic.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // dateBitis
            // 
            this.dateBitis.Location = new System.Drawing.Point(599, 221);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(200, 22);
            this.dateBitis.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bitiş Tarihi";
            // 
            // btnTarihlerArasiGelir
            // 
            this.btnTarihlerArasiGelir.Location = new System.Drawing.Point(905, 167);
            this.btnTarihlerArasiGelir.Name = "btnTarihlerArasiGelir";
            this.btnTarihlerArasiGelir.Size = new System.Drawing.Size(137, 71);
            this.btnTarihlerArasiGelir.TabIndex = 12;
            this.btnTarihlerArasiGelir.Text = "Tarihler Arası Gelir";
            this.btnTarihlerArasiGelir.UseVisualStyleBackColor = true;
            this.btnTarihlerArasiGelir.Click += new System.EventHandler(this.btnTarihlerArasiGelir_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(763, 297);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(44, 16);
            this.lblSonuc.TabIndex = 13;
            this.lblSonuc.Text = "label4";
            // 
            // FormRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 574);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnTarihlerArasiGelir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateBitis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateBaslangic);
            this.Controls.Add(this.btnGunlukGelir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateGunluk);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.btnPahali);
            this.Controls.Add(this.btnGelir);
            this.Controls.Add(this.btnGunluk);
            this.Name = "FormRapor";
            this.Text = "Rapor Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGunluk;
        private System.Windows.Forms.Button btnGelir;
        private System.Windows.Forms.Button btnPahali;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateGunluk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGunlukGelir;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTarihlerArasiGelir;
        private System.Windows.Forms.Label lblSonuc;
    }
}