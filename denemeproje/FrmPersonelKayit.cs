using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeproje
{
    public partial class FrmPersonelKayit : Form
    {
        public FrmPersonelKayit()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-U510320A;Initial Catalog=tbl_sirket;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPersonelKayit_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_personel (personelad, personelsoyad,personeltc, personelpozisyon, personelsifre)values(@p1,@p2,@p3,@p4,@p5) ", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTc.Text);
            komut.Parameters.AddWithValue("@p4", TxtPozisyon.Text);
            komut.Parameters.AddWithValue("@p5", TxtSifre.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kayıt Yapıldı");














        }

        private void TxtAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
