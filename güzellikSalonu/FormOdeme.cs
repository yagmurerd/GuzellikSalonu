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
    public partial class FormOdeme : Form
    {
        public FormOdeme()
        {
            InitializeComponent();
        }

        private void FormOdeme_Load(object sender, EventArgs e)
        {
            RandevuGetir();
            Listele();
        }

        void RandevuGetir()
        {
            string sql = @"
            SELECT 
             r.randevuID,
             CONCAT(r.randevuID,' - ', m.adi,' ',m.soyadi,' - ', h.hizmetAdi) AS Bilgi
             FROM `randevutablosu` r
             INNER JOIN `müsteritablosu` m ON r.MusteriID = m.müsteriID
             INNER JOIN `hizmettablosu` h ON r.HizmetID = h.hizmetID";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, Db.Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboRandevu.DisplayMember = "Bilgi";
            comboRandevu.ValueMember = "RandevuID";
            comboRandevu.DataSource = dt;
        }

        void Listele()
        {
            string sql = @"
             SELECT 
             o.odemeID,
             o.randevuID,
             o.tutar,
             o.odemeTipi,
             o.odemeTarihi
            FROM `ödemetablosu` o";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, Db.Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            Db.Baglanti.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO `ödemetablosu`(`randevuID`,`tutar`,`odemeTipi`,`odemeTarihi`) VALUES(@r,@t,@tip,@tarih)",Db.Baglanti);

            cmd.Parameters.AddWithValue("@r", comboRandevu.SelectedValue);
            cmd.Parameters.AddWithValue("@t", Convert.ToDecimal(txtTutar.Text));
            cmd.Parameters.AddWithValue("@tip", comboOdemeTipi.Text);
            cmd.Parameters.AddWithValue("@tarih", dateOdeme.Value.Date);

            cmd.ExecuteNonQuery();

            Db.Baglanti.Close();

            MessageBox.Show("Ödeme Kaydedildi.");
            Listele();

        }

        private void btnToplamGelir_Click(object sender, EventArgs e)
        {
            Db.Baglanti.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(SUM(tutar),0) FROM `ödemetablosu`",Db.Baglanti);

            decimal toplam = Convert.ToDecimal(cmd.ExecuteScalar());

            Db.Baglanti.Close();

            MessageBox.Show("Toplam Gelir: " + toplam + " TL ");
        }

        private void btnMusteriOdemeGetir_Click(object sender, EventArgs e)
        {
            string sql = @"
    SELECT
        CONCAT(m.adi,' ',m.soyadi) AS Musteri,
        r.Tarih,
        r.Saat,
        h.hizmetAdi AS Islem,
        o.tutar,
        o.odemeTipi,
        o.odemeTarihi
    FROM `ödemetablosu` o
    INNER JOIN `randevutablosu` r ON o.randevuID = r.randevuID
    INNER JOIN `müsteritablosu` m ON r.MusteriID = m.`müsteriID`
    INNER JOIN `hizmettablosu` h ON r.HizmetID = h.hizmetID
    WHERE CONCAT(m.adi,' ',m.soyadi) LIKE @musteri
    ORDER BY r.Tarih DESC";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, Db.Baglanti);
            da.SelectCommand.Parameters.AddWithValue("@musteri", "%" + txtMusteriAra.Text.Trim() + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;


            decimal toplam = 0;

            foreach (DataRow row in dt.Rows)
            {
                toplam += Convert.ToDecimal(row["tutar"]);
            }

            lblToplamOdeme.Text = "Toplam ödeme: " + toplam + " TL";
        }
    }
}
