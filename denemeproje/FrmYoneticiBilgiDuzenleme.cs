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
    public partial class FrmYoneticiBilgiDuzenleme : Form
    {
        public FrmYoneticiBilgiDuzenleme()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-U510320A;Initial Catalog=tbl_sirket;Integrated Security=True");
        public string tr;

        private void FrmYoneticiBilgiDuzenleme_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            MskTc.Text = tr;
            SqlCommand komut = new SqlCommand("Select * From Tbl_yonetici where yoneticitc=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", MskTc.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                MskTc.Text = dr[0].ToString();
                TxtPozisyon.Text = dr[4].ToString();
                TxtSifre.Text = dr[3].ToString();

            }
            baglanti.Close();



















        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_yonetici set yoneticiad= @p1,yoneticisoyad=@p2,pozisyon=@p3,yoneticisifre=@p4 where yoneticitc=@p5", baglanti);
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
