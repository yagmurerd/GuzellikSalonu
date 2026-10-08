using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace güzellikSalonu
{
    public partial class FormMusteri : Form
    {
        int secilenID = 0;

        public FormMusteri()
        {
            InitializeComponent();
        }

        private void FormMusteri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM müsteritablosu", Db.Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtAdres.Clear();
            txtTelefon.Clear();
            secilenID = 0;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Db.Baglanti.Open();

           MySqlCommand cmd = new MySqlCommand("INSERT INTO `müsteritablosu`(`adi`,`soyadi`,`dogumTarihi`,`telefon`,`adres`) VALUES(@ad,@soyad,@dogum,@tel,@adres)", Db.Baglanti);

            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@dogum", dateDogum.Value.Date);
            cmd.Parameters.AddWithValue("@tel", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@adres", txtAdres.Text);

            cmd.ExecuteNonQuery();
            Db.Baglanti.Close();

            MessageBox.Show("Müşteri Eklendi.");
            Listele();
            Temizle();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenID == 0)
            {
                MessageBox.Show("Lütfen Tablodan Müşteri Seç.");
                return;
            }

            Db.Baglanti.Open();

            MySqlCommand cmd = new MySqlCommand("UPDATE `müsteritablosu` SET `adi`=@ad, `soyadi`=@soyad, `dogumTarihi`=@dogum, `telefon`=@tel, `adres`=@adres WHERE `müsteriID`=@id", Db.Baglanti);

            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@dogum", dateDogum.Value.Date);
            cmd.Parameters.AddWithValue("@tel", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
            cmd.Parameters.AddWithValue("@id", secilenID);

            cmd.ExecuteNonQuery();
            Db.Baglanti.Close();

            MessageBox.Show("Müşteri Güncellendi.");
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(secilenID == 0)
            {
                MessageBox.Show("Lütfen Tablodan Müşteri Seç.");
                return;
            }

            Db.Baglanti.Open();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM `müsteritablosu` WHERE `müsteriID`=@id",Db.Baglanti);

            cmd.Parameters.AddWithValue("@id", secilenID);
            cmd.ExecuteNonQuery();

            Db.Baglanti.Close();

            MessageBox.Show("Müşteri Silindi");
            Listele();
            Temizle();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            secilenID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["müsteriID"].Value);
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells["adi"].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells["soyadi"].Value.ToString();
            txtTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.Rows[e.RowIndex].Cells["adres"].Value.ToString();
        }
    }
}
