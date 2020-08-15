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
    public partial class Porder : UserControl
    {
        public Porder()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox6.Text == "" && textBox7.Text == "")
            {
                MessageBox.Show("enter required feild");
            }

            else
            {
                int barcode = int.Parse(textBox1.Text);
                string product = textBox2.Text;
                string description = textBox3.Text;
                int price = int.Parse(textBox4.Text);
                int quantity = int.Parse(textBox6.Text);
                string suppiler = textBox7.Text;

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\orderproducts.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO orderp VALUES('" + product + "','" + barcode + "','" + price + "','" + description  + "','" + quantity + "','" + suppiler + "')";
                SqlCommand cmd = new SqlCommand(qry,con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data inserted Successfully");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
        }
    }

