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
    public partial class FormRandevuSorgula : Form
    {
        public FormRandevuSorgula()
        {
            InitializeComponent();
        }

        private void FormRandevuSorgula_Load(object sender, EventArgs e)
        {
            MusteriGetir();

            void MusteriGetir()
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT müsteriID, CONCAT(adi,' ',soyadi) AS adsoyad FROM müsteritablosu",Db.Baglanti);

                DataTable dt = new DataTable();
                da.Fill(dt);

                comboMusteri.DisplayMember = "adsoyad";
                comboMusteri.ValueMember = "müsteriID";
                comboMusteri.DataSource = dt;
            }
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {

            string sql = @"
            SELECT 
            r.randevuID,
            CONCAT(m.adi,' ',m.soyadi) AS Musteri,
            m.telefon,
            CONCAT(p.adi,' ',p.soyadi) AS Personel,
            h.hizmetAdi,
            r.Tarih,
            r.Saat
            FROM `randevutablosu` r
            INNER JOIN `müsteritablosu` m ON r.MusteriID = m.müsteriID
            INNER JOIN `personeltablosu` p ON r.PersonelID = p.personelID
            INNER JOIN `hizmettablosu` h ON r.HizmetID = h.hizmetID
            WHERE r.MusteriID = @id";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, Db.Baglanti);
            da.SelectCommand.Parameters.AddWithValue("@id", comboMusteri.SelectedValue);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
