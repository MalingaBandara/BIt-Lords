﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string uname = txtUname.Text;
            string pass = txtPword.Text;

            if (uname == "user" && pass =="1234")
            {
                Form1 fm = new Form1();
                this.Hide();
                fm.Show();
            }
            else if(uname == "user1" &&    pass == "12345")
            {
                Form1 fm = new Form1();
                this.Hide();
                fm.Show();
            }
            else
            {
                MessageBox.Show("Password or UserName Not match");
            }




        }

        

        private void txtUname_Enter(object sender, EventArgs e)
        {
            if(txtUname.Text=="User Name")
            {
                txtUname.Text = "";
                txtUname.ForeColor = Color.Black;
            }
        }

        private void txtUname_Leave(object sender, EventArgs e)
        {
            if (txtUname.Text == "")
            {
                txtUname.Text = "User Name";
                txtUname.ForeColor = Color.Silver;
            }
        }

        private void txtPword_Enter(object sender, EventArgs e)
        {
            if (txtPword.Text == "Password")
            {
                txtPword.Text = "";
                txtPword.ForeColor = Color.Black;
                txtPword.PasswordChar = '\u25CF';
            }
        }

        private void txtPword_Leave(object sender, EventArgs e)
        {
            if (txtPword.Text == "")
            {
                txtPword.Text = "Password";
                txtPword.ForeColor = Color.Silver;
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

       

       

    }
}
