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
    public partial class FrmPersonelDetay : Form
    {
        public FrmPersonelDetay()
        {
            InitializeComponent();
        }




        public string Tc;
        public string Tx;
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-U510320A;Initial Catalog=tbl_sirket;Integrated Security=True");


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmizin fr = new Frmizin();
            fr.Tx = LblTc.Text;
            

            fr.Show();
            







        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmPersonelDetay_Load(object sender, EventArgs e)
        {
            
            LblTc.Text = Tc;
            baglanti.Open();
            // AD Soyad Çekme
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

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void LblSoyad_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {



            FrmBilgiGuncelle fr= new FrmBilgiGuncelle();
            fr.ty= LblTc.Text;
            fr.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Application.Exit();


        }
    }
}
