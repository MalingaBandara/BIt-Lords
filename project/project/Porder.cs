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
            sum = 0;
            lblcal.Text = null;


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
        double sum = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            
            

            if (textBox1.Text=="" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("enter required feild");
            }

            else
            {

                int barcode = int.Parse(textBox1.Text);
                string product = textBox2.Text;
                string description = textBox3.Text;
                double price = double.Parse(textBox4.Text);
                double quantity = double.Parse(textBox6.Text);
                string suppiler = textBox7.Text;

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\orderproducts.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO orderp VALUES('" + product + "','" + barcode + "','" + price + "','" + description  + "','" + quantity + "','" + suppiler + "')";
                SqlCommand cmd = new SqlCommand(qry,con);

                sum += price * quantity;

                lblcal.Text = sum.ToString();
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
           

            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
        }
        
       


        
          
       


        private void button1_Click(object sender, EventArgs e)
        {
            string conString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\orderproducts.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "Select * From orderp";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "orderp");
            DD.DataSource = ds.Tables["orderp"];
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Porder_Load(object sender, EventArgs e)
        {

        }
    }
    }

