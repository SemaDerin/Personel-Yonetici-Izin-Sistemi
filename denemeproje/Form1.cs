using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void FormGetir(Form frm)
        {
            frm.MdiParent=this;
            frm.FormBorderStyle= FormBorderStyle.None;
            panel2.Controls.Add(frm);
            frm.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {


            FrmPersonelGiris fr= new FrmPersonelGiris();
            FormGetir(fr);
            //fr.Show();
            //this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            FrmYonetici fr= new FrmYonetici();
            FormGetir(fr);
            //fr.Show();
            //this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
