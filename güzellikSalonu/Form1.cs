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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            FormRandevu frm = new FormRandevu();
            frm.Show();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            FormRandevuSorgula frm = new FormRandevuSorgula();
            frm.Show();
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            Menü frm = new Menü();
            frm.Show();

        }
    }
}
