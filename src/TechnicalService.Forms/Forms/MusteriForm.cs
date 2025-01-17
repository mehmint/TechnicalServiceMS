using System;
using System.Windows.Forms;
using TechnicalService.Core.Entities;

namespace TechnicalService.Forms
{
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            MusterileriListele();
        }

        private void MusterileriListele()
        {
            // TODO: Veritabanından müşterileri çekeceğiz
            dataGridViewMusteriler.Refresh();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            // Yeni müşteri ekleme işlemleri
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Ad ve soyad alanları zorunludur!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var yeniMusteri = new Musteri
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon = txtTelefon.Text,
                Email = txtEmail.Text,
                Adres = txtAdres.Text,
                KayitTarihi = DateTime.Now
            };

            // TODO: Veritabanına kaydedeceğiz
            MessageBox.Show("Müşteri başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ControllerTemizle();
            MusterileriListele();
        }

        private void ControllerTemizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtAdres.Clear();
        }
    }
}
