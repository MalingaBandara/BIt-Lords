using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bar = int.Parse(txtBCode.Text);
            string Pname = txtPname.Text;
            string descriptikon = txtDes.Text;
            string category = txtcate.Text;
            float OPrice = float.Parse(txtOP.Text);
            float MPrice = float.Parse(txtMP.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\posDB.mdf;Integrated Security=True;Connect Timeout=30");
            string update = "UPDATE Product SET Barcode='"+bar+"',Description='"+ descriptikon + "',Category='"+category+"',OriginalPrice='"+OPrice+"',MarkupPrice='"+MPrice+ "' WHERE ProductName='"+Pname+"' ";
            SqlCommand cmd = new SqlCommand(update, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product is Register");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\posDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "Select * From Product";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "orderp");
            ddf.DataSource = ds.Tables["orderp"];
        }
    }
}
