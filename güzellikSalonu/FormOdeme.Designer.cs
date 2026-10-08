namespace güzellikSalonu
{
    partial class FormOdeme
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboRandevu = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.dateOdeme = new System.Windows.Forms.DateTimePicker();
            this.comboOdemeTipi = new System.Windows.Forms.ComboBox();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnToplamGelir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMusteriAra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMusteriOdemeGetir = new System.Windows.Forms.Button();
            this.lblToplamOdeme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Randevu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tutar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ödeme Tipi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarih:";
            // 
            // comboRandevu
            // 
            this.comboRandevu.FormattingEnabled = true;
            this.comboRandevu.Location = new System.Drawing.Point(185, 35);
            this.comboRandevu.Name = "comboRandevu";
            this.comboRandevu.Size = new System.Drawing.Size(121, 24);
            this.comboRandevu.TabIndex = 4;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(200, 90);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 22);
            this.txtTutar.TabIndex = 5;
            // 
            // dateOdeme
            // 
            this.dateOdeme.Location = new System.Drawing.Point(200, 195);
            this.dateOdeme.Name = "dateOdeme";
            this.dateOdeme.Size = new System.Drawing.Size(200, 22);
            this.dateOdeme.TabIndex = 6;
            // 
            // comboOdemeTipi
            // 
            this.comboOdemeTipi.FormattingEnabled = true;
            this.comboOdemeTipi.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı"});
            this.comboOdemeTipi.Location = new System.Drawing.Point(185, 140);
            this.comboOdemeTipi.Name = "comboOdemeTipi";
            this.comboOdemeTipi.Size = new System.Drawing.Size(121, 24);
            this.comboOdemeTipi.TabIndex = 7;
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Location = new System.Drawing.Point(35, 254);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(104, 46);
            this.btnOdemeAl.TabIndex = 8;
            this.btnOdemeAl.Text = "Ödeme Al";
            this.btnOdemeAl.UseVisualStyleBackColor = true;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // btnToplamGelir
            // 
            this.btnToplamGelir.Location = new System.Drawing.Point(200, 247);
            this.btnToplamGelir.Name = "btnToplamGelir";
            this.btnToplamGelir.Size = new System.Drawing.Size(163, 53);
            this.btnToplamGelir.TabIndex = 9;
            this.btnToplamGelir.Text = "Toplam Gelir";
            this.btnToplamGelir.UseVisualStyleBackColor = true;
            this.btnToplamGelir.Click += new System.EventHandler(this.btnToplamGelir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(921, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // txtMusteriAra
            // 
            this.txtMusteriAra.Location = new System.Drawing.Point(706, 38);
            this.txtMusteriAra.Name = "txtMusteriAra";
            this.txtMusteriAra.Size = new System.Drawing.Size(100, 22);
            this.txtMusteriAra.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Müşteri Ad Soyad";
            // 
            // btnMusteriOdemeGetir
            // 
            this.btnMusteriOdemeGetir.Location = new System.Drawing.Point(904, 26);
            this.btnMusteriOdemeGetir.Name = "btnMusteriOdemeGetir";
            this.btnMusteriOdemeGetir.Size = new System.Drawing.Size(127, 46);
            this.btnMusteriOdemeGetir.TabIndex = 13;
            this.btnMusteriOdemeGetir.Text = "Ödeme Getir";
            this.btnMusteriOdemeGetir.UseVisualStyleBackColor = true;
            this.btnMusteriOdemeGetir.Click += new System.EventHandler(this.btnMusteriOdemeGetir_Click);
            // 
            // lblToplamOdeme
            // 
            this.lblToplamOdeme.AutoSize = true;
            this.lblToplamOdeme.Location = new System.Drawing.Point(720, 114);
            this.lblToplamOdeme.Name = "lblToplamOdeme";
            this.lblToplamOdeme.Size = new System.Drawing.Size(44, 16);
            this.lblToplamOdeme.TabIndex = 14;
            this.lblToplamOdeme.Text = "label6";
            // 
            // FormOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 495);
            this.Controls.Add(this.lblToplamOdeme);
            this.Controls.Add(this.btnMusteriOdemeGetir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMusteriAra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnToplamGelir);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.comboOdemeTipi);
            this.Controls.Add(this.dateOdeme);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.comboRandevu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormOdeme";
            this.Text = "Ödeme Paneli";
            this.Load += new System.EventHandler(this.FormOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboRandevu;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.DateTimePicker dateOdeme;
        private System.Windows.Forms.ComboBox comboOdemeTipi;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Button btnToplamGelir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMusteriAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMusteriOdemeGetir;
        private System.Windows.Forms.Label lblToplamOdeme;
    }
}