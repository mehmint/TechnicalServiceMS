namespace TechnicalService.Forms
{
    partial class MusteriForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.dataGridViewMusteriler = new System.Windows.Forms.DataGridView();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Müşteri İşlemleri";

            // GroupBox
            this.groupBox1.Text = "Müşteri Bilgileri";
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Size = new System.Drawing.Size(300, 250);

            // Labels
            this.lblAd.Text = "Ad:";
            this.lblAd.Location = new System.Drawing.Point(20, 30);
            this.lblSoyad.Text = "Soyad:";
            this.lblSoyad.Location = new System.Drawing.Point(20, 60);
            this.lblTelefon.Text = "Telefon:";
            this.lblTelefon.Location = new System.Drawing.Point(20, 90);
            this.lblEmail.Text = "E-mail:";
            this.lblEmail.Location = new System.Drawing.Point(20, 120);
            this.lblAdres.Text = "Adres:";
            this.lblAdres.Location = new System.Drawing.Point(20, 150);

            // TextBoxes
            this.txtAd.Location = new System.Drawing.Point(100, 30);
            this.txtAd.Size = new System.Drawing.Size(180, 20);
            this.txtSoyad.Location = new System.Drawing.Point(100, 60);
            this.txtSoyad.Size = new System.Drawing.Size(180, 20);
            this.txtTelefon.Location = new System.Drawing.Point(100, 90);
            this.txtTelefon.Size = new System.Drawing.Size(180, 20);
            this.txtEmail.Location = new System.Drawing.Point(100, 120);
            this.txtEmail.Size = new System.Drawing.Size(180, 20);
            this.txtAdres.Location = new System.Drawing.Point(100, 150);
            this.txtAdres.Size = new System.Drawing.Size(180, 60);
            this.txtAdres.Multiline = true;

            // Button
            this.btnYeniMusteri.Text = "Yeni Müşteri Ekle";
            this.btnYeniMusteri.Location = new System.Drawing.Point(100, 220);
            this.btnYeniMusteri.Size = new System.Drawing.Size(180, 23);
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);

            // DataGridView
            this.dataGridViewMusteriler.Location = new System.Drawing.Point(320, 12);
            this.dataGridViewMusteriler.Size = new System.Drawing.Size(468, 426);
            this.dataGridViewMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Add controls to form
            this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblAd, this.txtAd,
                this.lblSoyad, this.txtSoyad,
                this.lblTelefon, this.txtTelefon,
                this.lblEmail, this.txtEmail,
                this.lblAdres, this.txtAdres,
                this.btnYeniMusteri
            });

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.groupBox1,
                this.dataGridViewMusteriler
            });
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.DataGridView dataGridViewMusteriler;

        #endregion
    }
}
