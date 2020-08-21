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
    public partial class searchproduct : UserControl
    {
        public searchproduct()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            string prname = pname.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\posDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "DELETE from Product Where ProductName='"+prname+"' ";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product is Delete");
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
