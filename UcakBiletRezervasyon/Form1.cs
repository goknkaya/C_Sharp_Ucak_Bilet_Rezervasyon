using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            lbKayit.Items.Add("Rota: " + cmbNereden.Text + " -> " + cmbNereye.Text + "// Tarih: "+dtpTarih.Text+"// Saat: "+maskSaat.Text+"// Yolcu Bilgileri: Ad: "+txtAdSoyad.Text+"// TC Kimlik No: "+maskTC.Text+ "// Telefon Numarası: "+maskTel.Text);
            MessageBox.Show("Yolcu başarıyla eklendi.");
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            label9.Text = cmbNereye.Text;
            cmbNereye.Text = cmbNereden.Text;
            cmbNereden.Text = label9.Text;
        }
    }
}
