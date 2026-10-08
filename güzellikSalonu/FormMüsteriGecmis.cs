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
    public partial class FormMüsteriGecmis : Form
    {
        public FormMüsteriGecmis()
        {
            InitializeComponent();
        }

        void MusteriGetir()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT `müsteriID`, CONCAT(`adi`,' ',`soyadi`) AS adsoyad FROM `müsteritablosu`",Db.Baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);

            comboMüsteri.DisplayMember = "adsoyad";
            comboMüsteri.ValueMember = "müsteriID";
            comboMüsteri.DataSource = dt;
        }

        private void btnGecmisGetir_Click(object sender, EventArgs e)
        {
            string sql = @"
            SELECT
             r.Tarih,
             r.Saat,
             h.hizmetAdi AS YapilanIslem,
            CONCAT(p.adi,' ',p.soyadi) AS Personel,
             o.tutar,
             o.odemeTipi
             FROM `randevutablosu` r

             INNER JOIN `hizmettablosu` h
             ON r.HizmetID = h.hizmetID

             INNER JOIN `personeltablosu` p
             ON r.PersonelID = p.personelID

             LEFT JOIN `ödemetablosu` o
             ON r.randevuID = o.randevuID

             WHERE r.MusteriID = @id

             ORDER BY r.Tarih DESC";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, Db.Baglanti);

            da.SelectCommand.Parameters.AddWithValue("@id", comboMüsteri.SelectedValue);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            decimal toplam = 0;

            foreach (DataRow row in dt.Rows)
            {
                if (row["tutar"] != DBNull.Value)
                {
                    toplam += Convert.ToDecimal(row["tutar"]);
                }
            }

            lblToplam.Text = "Toplam Ödeme: " + toplam + " TL";
        }

        private void FormMüsteriGecmis_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }
    }
}
