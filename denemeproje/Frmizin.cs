using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace denemeproje
{
    public partial class Frmizin : Form
    {
        public Frmizin()
        {
            InitializeComponent();
        }



        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-U510320A;Initial Catalog=tbl_sirket;Integrated Security=True");
        public string Tx;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frmizin_Load(object sender, EventArgs e)
        {


            baglanti.Open();

            // AD Soyad Çekme
            LblTc.Text = Tx;
            SqlCommand komut = new SqlCommand("Select personeltc,personelad,personelsoyad,personelpozisyon From Tbl_personel where personeltc= @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAd.Text = dr[1].ToString();
                LblSoyad.Text = dr[2].ToString();
                LblTc.Text = dr[0].ToString();
                LblPozisyon.Text = dr[3].ToString();
            }

            baglanti.Close();




        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Btnizin_Click(object sender, EventArgs e)
        {

            baglanti.Open();


            DateTime startDate = dtStart.Value;
            int totalDays = int.Parse(MskGun.Text);

            // Sadece Pazartesi, Çarşamba ve Cuma günleri sayılacak şekilde iş günleri listesi oluşturuluyor
            List<DayOfWeek> workDays = new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Wednesday, DayOfWeek.Friday };

            // Başlangıç tarihinden itibaren iş günleri içerisindeki ilk gün bulunuyor
            DateTime nextWorkDay = startDate;
            while (!workDays.Contains(nextWorkDay.DayOfWeek))
            {
                nextWorkDay = nextWorkDay.AddDays(1);
            }

            // Toplam izin günleri hesaplanıyor
            int usedDays = 0;
            while (usedDays < totalDays)
            {
                if (workDays.Contains(nextWorkDay.DayOfWeek))
                {
                    usedDays++;
                }
                nextWorkDay = nextWorkDay.AddDays(1);
            }

            // İşe dönüş tarihi Pazartesi, Çarşamba veya Cuma günlerinden biri olacak şekilde ayarlanıyor
            while (!workDays.Contains(nextWorkDay.DayOfWeek))
            {
                nextWorkDay = nextWorkDay.AddDays(1);
            }

            // İşe dönüş tarihi hesaplanıp ekrana yazdırılıyor
            LblDonus.Text = nextWorkDay.ToString("dd.MM.yyyy");


         



            SqlCommand command = new SqlCommand("INSERT INTO Tbl_izin (personelad,personelsoyad, personeltc, izingunu, donustarihi) VALUES (@personelad, @personelsoyad, @personeltc, @izingunleri, @donustarih)", baglanti);

            command.Parameters.AddWithValue("@personelad", LblAd.Text);
            command.Parameters.AddWithValue("@personelsoyad", LblSoyad.Text);
            command.Parameters.AddWithValue("@personeltc", LblTc.Text);



            command.Parameters.AddWithValue("@izingunleri", totalDays);
            command.Parameters.AddWithValue("@donustarih", nextWorkDay.ToString("yyyy-MM-dd"));

            LblMesaj.Text = "Şirketimiz iyi tatiller diler. Dönüş Tarihiniz :";

            command.ExecuteNonQuery();
            baglanti.Close();









        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPozisyon_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MskTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LblDonus_Click(object sender, EventArgs e)
        {

        }
    }
}
