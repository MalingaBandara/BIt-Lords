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
    public partial class Manageusers : UserControl
    {
        public Manageusers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("enter required feild");
            }
            else
            {

                string username = textBox2.Text;
                string password = textBox3.Text;

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\manageuser.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO mu VALUES('" + username + "','" + password + "')";
                SqlCommand cmd = new SqlCommand(qry, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data inserted Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }



            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\manageuser.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "Select * From mu";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "mu");
            dataGridView1.DataSource = ds.Tables["mu"];
        }
    }
}
