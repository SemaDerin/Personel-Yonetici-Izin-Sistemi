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
    public partial class FrmizinGoruntule : Form
    {
        public FrmizinGoruntule()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-U510320A;Initial Catalog=tbl_sirket;Integrated Security=True");

        private void FrmizinGoruntule_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_izin", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {

        }
    }
}
