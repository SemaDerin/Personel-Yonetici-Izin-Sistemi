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
    public partial class FrmBilgiGuncelle : Form
    {
        public FrmBilgiGuncelle()
        {
            InitializeComponent();
        }



        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-U510320A;Initial Catalog=tbl_sirket;Integrated Security=True");
        public string ty;
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmBilgiGuncelle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            MskTc.Text = ty;
            SqlCommand komut = new SqlCommand("Select * From Tbl_personel where personeltc=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", MskTc.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                MskTc.Text = dr[0].ToString();
                TxtPozisyon.Text = dr[3].ToString();
                TxtSifre.Text = dr[4].ToString();

            }
            baglanti.Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_personel set personelad= @p1,personelsoyad=@p2,personelpozisyon=@p3,personelsifre=@p4 where personeltc=@p5", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtPozisyon.Text);
            komut.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p5", MskTc.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi");













        }
    }
}
