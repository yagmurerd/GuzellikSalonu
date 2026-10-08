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
    public partial class FormHizmet : Form
    {
        int secilenID = 0;
        public FormHizmet()
        {
            InitializeComponent();
        }

        private void FormHizmet_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `hizmettablosu`", Db.Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Temizle()
        {
            txtHizmetAdi.Clear();
            txtSure.Clear();
            txtUcret.Clear();
            secilenID = 0;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Db.Baglanti.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO `hizmettablosu`(`hizmetAdi`,`sure`,`ucret`) VALUES(@ad,@sure,@ucret)",Db.Baglanti);

            cmd.Parameters.AddWithValue("@ad", txtHizmetAdi.Text);
            cmd.Parameters.AddWithValue("@sure", txtSure.Text);
            cmd.Parameters.AddWithValue("@ucret", txtUcret.Text);

            cmd.ExecuteNonQuery();
            Db.Baglanti.Close();

            MessageBox.Show("Hizmet Eklendi.");
            Listele();
            Temizle();


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenID == 0)
            {
                MessageBox.Show("Hizmet Seç.");
                return;
            }

            Db.Baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `hizmettablosu` SET `hizmetAdi`=@ad, `sure`=@sure, `ucret`=@ucret WHERE `hizmetID`=@id",Db.Baglanti);

            cmd.Parameters.AddWithValue("@ad",txtHizmetAdi.Text);
            cmd.Parameters.AddWithValue("@sure", txtSure.Text);
            cmd.Parameters.AddWithValue("@ucret", txtUcret.Text);
            cmd.Parameters.AddWithValue("@id", secilenID);

            cmd.ExecuteNonQuery();
            Db.Baglanti.Close();

            MessageBox.Show("Hizmet Güncellendi.");
            Listele();
            Temizle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenID == 0)
            {
                MessageBox.Show("Hizmet Seç.");
                return;
            }

            Db.Baglanti.Open();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM `hizmettablosu` WHERE `hizmetID`=@id",Db.Baglanti);

            cmd.Parameters.AddWithValue("@id", secilenID);


            cmd.ExecuteNonQuery ();

            Db.Baglanti.Close();

            MessageBox.Show("Hizmet Silindi.");
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

            secilenID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["hizmetID"].Value);
            txtHizmetAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["hizmetAdi"].Value.ToString();
            txtSure.Text = dataGridView1.Rows[e.RowIndex].Cells["sure"].Value.ToString();
            txtUcret.Text = dataGridView1.Rows[e.RowIndex].Cells["ucret"].Value.ToString();

        }
    }
}
