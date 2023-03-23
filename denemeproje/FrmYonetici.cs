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
    public partial class FrmYonetici : Form
    {
        public FrmYonetici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-U510320A;Initial Catalog=tbl_sirket;Integrated Security=True");
        public string tf;
        private void BtnGiris_Click(object sender, EventArgs e)
        {


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_yonetici where yoneticitc=@p1 and yoneticisifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {


                FrmYoneticiDetay  fr = new FrmYoneticiDetay();
                fr.tf = MskTc.Text;


                fr.Show();
               


                this.Hide();

            }

            else
            {
                MessageBox.Show("Hatalı TC & Şifre ");




            }
        }

        private void FrmYonetici_Load(object sender, EventArgs e)
        {

        }
    }

}