namespace güzellikSalonu
{
    partial class FormMüsteriGecmis
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
            this.comboMüsteri = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnGecmisGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMüsteri
            // 
            this.comboMüsteri.FormattingEnabled = true;
            this.comboMüsteri.Location = new System.Drawing.Point(48, 52);
            this.comboMüsteri.Name = "comboMüsteri";
            this.comboMüsteri.Size = new System.Drawing.Size(304, 24);
            this.comboMüsteri.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(781, 170);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(152, 244);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(0, 16);
            this.lblToplam.TabIndex = 2;
            // 
            // btnGecmisGetir
            // 
            this.btnGecmisGetir.Location = new System.Drawing.Point(48, 128);
            this.btnGecmisGetir.Name = "btnGecmisGetir";
            this.btnGecmisGetir.Size = new System.Drawing.Size(242, 51);
            this.btnGecmisGetir.TabIndex = 3;
            this.btnGecmisGetir.Text = "Müşteri Geçmişini Getir";
            this.btnGecmisGetir.UseVisualStyleBackColor = true;
            this.btnGecmisGetir.Click += new System.EventHandler(this.btnGecmisGetir_Click);
            // 
            // FormMüsteriGecmis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.btnGecmisGetir);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboMüsteri);
            this.Name = "FormMüsteriGecmis";
            this.Text = "FormMüsteriGecmis";
            this.Load += new System.EventHandler(this.FormMüsteriGecmis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMüsteri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnGecmisGetir;
    }
}