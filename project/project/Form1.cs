using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetActivePanale(products1);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetActivePanale(home1);

        }

        public void SetActivePanale(UserControl control)
        {
            home1.Visible = false;
            products1.Visible = false;
            porder1.Visible = false;
            sproducts1.Visible = false;

            control.Visible = true; 
        }

        private void products1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetActivePanale(home1);
        }

        private void pOrder_Click(object sender, EventArgs e)
        {
            SetActivePanale(porder1);
        }

        private void sproducts_Click(object sender, EventArgs e)
        {
            SetActivePanale(sproducts1);
        }
    }
}
