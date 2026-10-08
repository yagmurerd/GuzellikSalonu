using MySql.Data.MySqlClient;
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
    public partial class FormPersonel : Form
    {
        int secilenID = 0;
        public FormPersonel()
        {
            InitializeComponent();
        }

        private void FormPersonel_Load(object sender, EventArgs e)
        {
            Listele();
            UzmanlikGetir();
        }

        void UzmanlikGetir()
        {
            MySqlDataAdapter da = new MySqlDataAdapter(
            "SELECT * FROM `uzmanliktablosu`",
            Db.Baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);

            comboUzmanlik.DisplayMember = "uzmanlikAdi";
            comboUzmanlik.ValueMember = "uzmanlikID";
            comboUzmanlik.DataSource = dt;
        }

        void Listele()
        {
            string sql = @"
    SELECT 
    p.personelID,
    p.adi,
    p.soyadi,
    u.uzmanlikAdi
    FROM `personeltablosu` p
    INNER JOIN `uzmanliktablosu` u
    ON p.uzmanlikID = u.uzmanlikID";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, Db.Baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }


        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
          //  txtUzmanlik.Clear();
            secilenID = 0;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Db.Baglanti.Open();

            MySqlCommand cmd = new MySqlCommand(
  "INSERT INTO `personeltablosu`(`adi`,`soyadi`,`uzmanlikID`) VALUES(@ad,@soyad,@u)",
  Db.Baglanti);

            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@u", comboUzmanlik.SelectedValue);

            cmd.ExecuteNonQuery();
            Db.Baglanti.Close();

            MessageBox.Show("Personel Eklendi.");
            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenID == 0)
            {
                MessageBox.Show("Personel Seç.");
                return;
            }

            Db.Baglanti.Open();

            MySqlCommand cmd = new MySqlCommand("UPDATE `personeltablosu` SET `adi`=@ad, `soyadi`=@soyad, `uzmanlikID`=@u WHERE `personelID`=@id",Db.Baglanti);

            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@u", comboUzmanlik.SelectedValue);
            cmd.Parameters.AddWithValue("@id", secilenID);

            cmd.ExecuteNonQuery();
            Db.Baglanti.Close();

            MessageBox.Show("Personel Güncellendi");
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenID == 0)
            {
                MessageBox.Show("Personel Seç. ");
                return; 
            }

            Db.Baglanti.Open();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM `personeltablosu` WHERE `personelID`=@id",Db.Baglanti);

            cmd.Parameters.AddWithValue("@id", secilenID);

            cmd.ExecuteNonQuery ();

            Db.Baglanti.Close();

            MessageBox.Show("Personel Silindi");
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

            secilenID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["personelID"].Value);

            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells["adi"].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells["soyadi"].Value.ToString();

            comboUzmanlik.Text = dataGridView1.Rows[e.RowIndex].Cells["uzmanlikAdi"].Value.ToString();
        }

        private void txtUzmanlik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
