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
    public partial class FormRandevu : Form
    {
        int secilenID = 0;

        public FormRandevu()
        {
            InitializeComponent();
        }


        private void FormRandevu_Load(object sender, EventArgs e)
        {
            //MusteriGetir();
            PersonelGetir();
            HizmetGetir();
            Listele();
        }

        //void MusteriGetir()
        //{
        //    MySqlDataAdapter da = new MySqlDataAdapter("SELECT müsteriID, CONCAT(adi,' ',soyadi) AS adisoyadi FROM müsteritablosu",Db.Baglanti);

        //    DataTable dt = new DataTable();
        //    da.Fill(dt);

        //    comboMusteri.DisplayMember = "adisoyadi";
        //    comboMusteri.ValueMember = "müsteriID";
        //    comboMusteri.DataSource = dt;

        //}

        void PersonelGetir()
        {
            MySqlDataAdapter da = new MySqlDataAdapter(
            @"SELECT 
             p.personelID,
            CONCAT(p.adi,' ',p.soyadi,' - ',u.uzmanlikAdi) AS PersonelBilgi FROM `personeltablosu` p
             INNER JOIN `uzmanliktablosu` u 
             ON p.uzmanlikID = u.uzmanlikID", Db.Baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);

            comboPersonel.DisplayMember = "PersonelBilgi";
            comboPersonel.ValueMember = "personelID";
            comboPersonel.DataSource = dt;
        }

        void HizmetGetir()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT hizmetID, CONCAT(hizmetAdi,' - ',ucret,' TL') AS HizmetBilgi FROM `hizmettablosu`", Db.Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboHizmet.DisplayMember = "HizmetBilgi";
            comboHizmet.ValueMember = "HizmetID";
            comboHizmet.DataSource = dt;
        }

        void Listele()
        {
            string sql = @"
             SELECT 
             r.RandevuID,
             CONCAT(m.adi,' ',m.soyadi) AS Musteri,
             m.telefon,
             CONCAT(p.adi,' ',p.soyadi) AS Personel,
               h.hizmetAdi,
               r.Tarih, 
               r.Saat
             FROM randevutablosu r
             INNER JOIN müsteritablosu m ON r.MusteriID = m.müsteriID
             INNER JOIN personeltablosu p ON r.PersonelID = p.personelID
             INNER JOIN hizmettablosu h ON r.HizmetID = h.hizmetID";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, Db.Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMusteri.Text.Trim() == "" || txtTelefon.Text.Trim() == "" || txtSaat.Text.Trim() == "")
            {
                MessageBox.Show("Müşteri adı, telefon ve saat boş bırakılamaz.");
                return;
            }

            Db.Baglanti.Open();

            int musteriID;

            MySqlCommand bul = new MySqlCommand(
            "SELECT `müsteriID` FROM `müsteritablosu` WHERE CONCAT(adi,' ',soyadi)=@adsoyad",
            Db.Baglanti);

            bul.Parameters.AddWithValue("@adsoyad", txtMusteri.Text.Trim());

            object musteriSonuc = bul.ExecuteScalar();

            if (musteriSonuc != null)
            {
                musteriID = Convert.ToInt32(musteriSonuc);
            }
            else
            {
                string[] parcalar = txtMusteri.Text.Trim().Split(' ');

                string ad = parcalar[0];
                string soyad = parcalar.Length > 1 ? parcalar[1] : "";

                MySqlCommand ekle = new MySqlCommand("INSERT INTO `müsteritablosu`(`adi`,`soyadi`,`telefon`,`adres`) VALUES(@ad,@soyad,@tel,'-')", Db.Baglanti);

                ekle.Parameters.AddWithValue("@ad", ad);
                ekle.Parameters.AddWithValue("@soyad", soyad);
                ekle.Parameters.AddWithValue("@tel", txtTelefon.Text);
                ekle.ExecuteNonQuery();

                musteriID = Convert.ToInt32(new MySqlCommand("SELECT LAST_INSERT_ID()", Db.Baglanti).ExecuteScalar());
            }

            MySqlCommand kontrol = new MySqlCommand("SELECT COUNT(*) FROM `randevutablosu` WHERE PersonelID=@p AND Tarih=@t AND Saat=@s",Db.Baglanti);

            kontrol.Parameters.AddWithValue("@p", comboPersonel.SelectedValue);
            kontrol.Parameters.AddWithValue("@t", dateTarih.Value.Date);
            kontrol.Parameters.AddWithValue("@s", txtSaat.Text);

            int cakisma = Convert.ToInt32(kontrol.ExecuteScalar());

            if (cakisma > 0)
            {
                MessageBox.Show("Bu personelin bu tarih ve saatte randevusu var!");
                Db.Baglanti.Close();
                return;
            }

            MySqlCommand cmd = new MySqlCommand("INSERT INTO `randevutablosu`(MusteriID,PersonelID,HizmetID,Tarih,Saat) VALUES(@m,@p,@h,@t,@s)",Db.Baglanti);

            cmd.Parameters.AddWithValue("@m", musteriID);
            cmd.Parameters.AddWithValue("@p", comboPersonel.SelectedValue);
            cmd.Parameters.AddWithValue("@h", comboHizmet.SelectedValue);
            cmd.Parameters.AddWithValue("@t", dateTarih.Value.Date);
            cmd.Parameters.AddWithValue("@s", txtSaat.Text);

            cmd.ExecuteNonQuery();

            Db.Baglanti.Close();
            Listele();

            MessageBox.Show("Randevu alındı.");
           
        }
    
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenID == 0)
            {
                MessageBox.Show("Tablodan Randevu Seçiniz.");
                return;
            }

            Db.Baglanti.Open();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM randevutablosu WHERE RandevuID=@id", Db.Baglanti);

            cmd.Parameters.AddWithValue("@id", secilenID);

            cmd.ExecuteNonQuery();

            Db.Baglanti.Close();

            MessageBox.Show("Randevu Silindi");
            Listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            secilenID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["RandevuID"].Value);

        }
    }
}
