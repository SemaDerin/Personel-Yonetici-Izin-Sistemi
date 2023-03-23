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
    public partial class FrmPersonelGiris : Form
    {
        public FrmPersonelGiris()
        {
            InitializeComponent();
        }


        public string Tc;


        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-U510320A;Initial Catalog=tbl_sirket;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPersonelGiris_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_personel where personeltc=@p1 and personelsifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {


                FrmPersonelDetay fr = new FrmPersonelDetay();
                fr.Tc = MskTc.Text;

                fr.Show();
                

                this.Hide();



            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre ");




            }
            baglanti.Close();
        }
    }
}
