﻿using System;
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
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            if (txtid.Text == "" || txtBCode.Text == "" || txtDes.Text == "" || txtPname.Text == "" || txtcate.Text == "" || txtOP.Text == "" || txtMP.Text == "")
            {
                MessageBox.Show("enter required feild");
            }
            else
            {
                int id = int.Parse(txtid.Text);
                int bar = int.Parse(txtBCode.Text);
                string Pname = txtPname.Text;
                string descriptikon = txtDes.Text;
                string category = txtcate.Text;
                float OPrice = float.Parse(txtOP.Text);
                float MPrice = float.Parse(txtMP.Text);

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\posDB.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO Product(ProductId,Barcode,ProductName,Description,Category,OriginalPrice,MarkupPrice) VALUES('" + id + "','" + bar + "','" + Pname + "','" + descriptikon + "','" + category + "','" + OPrice + "','" + MPrice + "')";
                SqlCommand cmd = new SqlCommand(qry, con);

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
        }

        private void txtPname_SelectedIndexChnged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string conString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\posDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "Select * From Product";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "orderp");
            ddf.DataSource = ds.Tables["orderp"];
        }

        private void Products_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtid.Text = null;
            txtBCode.Text = null;
            txtPname.Text = null;
            txtDes.Text = null;
            txtcate.Text= null;
            txtOP.Text = null;
            txtMP.Text = null;

        }
    }
}
