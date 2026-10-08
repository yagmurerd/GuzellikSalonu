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
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            new FormMusteri().Show();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            new FormPersonel().Show();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            new FormRandevu().Show();
        }

        private void btnHizmet_Click(object sender, EventArgs e)
        {
            new FormHizmet().Show();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            new FormOdeme().Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            new FormRapor().Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMüsteriGecmis_Click(object sender, EventArgs e)
        {
            FormMüsteriGecmis frm = new FormMüsteriGecmis();
            frm.Show();
        }
    }
}
