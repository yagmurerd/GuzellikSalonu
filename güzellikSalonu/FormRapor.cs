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
    public partial class FormRapor : Form
    {
        public FormRapor()
        {
            InitializeComponent();
        }

        void VeriGetir(string sql)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(sql, Db.Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnGunluk_Click(object sender, EventArgs e)
        {
            VeriGetir(@"
         SELECT 
         r.randevuID,
         CONCAT(m.adi,' ',m.soyadi) AS Musteri,
         CONCAT(p.adi,' ',p.soyadi) AS Personel,
             h.hizmetAdi,
             r.tarih,
             r.saat
         FROM `randevutablosu` r
         INNER JOIN `müsteritablosu` m ON r.MusteriID=m.müsteriID
         INNER JOIN `personeltablosu` p ON r.PersonelID=p.personelID
         INNER JOIN `hizmettablosu` h ON r.HizmetID=h.hizmetID
         WHERE r.tarih = CURDATE()");



        }

        private void btnGelir_Click(object sender, EventArgs e)
        {
            VeriGetir("SELECT odemeTipi, SUM(tutar) AS ToplamGelir FROM `ödemetablosu` GROUP BY odemeTipi");
        }

        private void btnPahali_Click(object sender, EventArgs e)
        {
            VeriGetir("SELECT * FROM `hizmettablosu` ORDER BY ucret DESC LIMIT 1");
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            VeriGetir("SELECT * FROM `ürüntablosu` WHERE `stokKontrolü`='Stokta Var'");
        }

        private void btnGunlukGelir_Click(object sender, EventArgs e)
        {
            Db.Baglanti.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(SUM(tutar),0) FROM `ödemetablosu` WHERE `odemeTarihi`=@tarih", Db.Baglanti);

            cmd.Parameters.AddWithValue("@tarih", dateGunluk.Value.Date);

            decimal toplam = Convert.ToDecimal(cmd.ExecuteScalar());

            Db.Baglanti.Close();

            lblSonuc.Text = "Günlük Gelir: " + toplam + " TL";
        }

        private void btnTarihlerArasiGelir_Click(object sender, EventArgs e)
        {
            Db.Baglanti.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(SUM(tutar),0) FROM `ödemetablosu` WHERE `odemeTarihi` BETWEEN @baslangic AND @bitis",Db.Baglanti);

            cmd.Parameters.AddWithValue("@baslangic", dateBaslangic.Value.Date);
            cmd.Parameters.AddWithValue("@bitis", dateBitis.Value.Date);

            decimal toplam = Convert.ToDecimal(cmd.ExecuteScalar());

            Db.Baglanti.Close();

            lblSonuc.Text = "Seçilen Tarihler Arası Gelir: " + toplam + " TL";

            string sql = "SELECT * FROM `ödemetablosu` WHERE `odemeTarihi` BETWEEN @baslangic AND @bitis";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, Db.Baglanti);
            da.SelectCommand.Parameters.AddWithValue("@baslangic", dateBaslangic.Value.Date);
            da.SelectCommand.Parameters.AddWithValue("@bitis", dateBitis.Value.Date);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
