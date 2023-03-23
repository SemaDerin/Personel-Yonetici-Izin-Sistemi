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
    public partial class FrmYoneticiDetay : Form
    {
        public FrmYoneticiDetay()
        {
            InitializeComponent();
        }




        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-U510320A;Initial Catalog=tbl_sirket;Integrated Security=True");
        public string tf;
        public string tr;

        private void FrmYoneticiDetay_Load(object sender, EventArgs e)
        {

            LblTc.Text = tf;
            baglanti.Open();
            // AD Soyad Çekme
            SqlCommand komut = new SqlCommand("Select yoneticitc,yoneticiad,yoneticisoyad From Tbl_yonetici where yoneticitc= @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAd.Text = dr[1].ToString();
                LblSoyad.Text = dr[2].ToString();
                LblTc.Text = dr[0].ToString();
                
            }
            baglanti.Close();














        }

        private void button4_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            FrmYoneticiBilgiDuzenleme fr = new FrmYoneticiBilgiDuzenleme();
            fr.tr = LblTc.Text;

            fr.Show();













        }

        private void button1_Click(object sender, EventArgs e)
        {


            FrmizinGoruntule fr= new FrmizinGoruntule();
            fr.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            FrmPersonelKayit frm= new FrmPersonelKayit();
            frm.Show();


            












        }
    }
}
