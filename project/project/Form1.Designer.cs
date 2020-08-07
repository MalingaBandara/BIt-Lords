namespace project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.pOrder = new System.Windows.Forms.Button();
            this.sproducts = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.manageusers1 = new project.Manageusers();
            this.searchproduct1 = new project.searchproduct();
            this.porder1 = new project.Porder();
            this.products1 = new project.Products();
            this.home1 = new project.Home();
            this.panelSideMenu.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(70)))));
            this.panelSideMenu.Controls.Add(this.button5);
            this.panelSideMenu.Controls.Add(this.pOrder);
            this.panelSideMenu.Controls.Add(this.sproducts);
            this.panelSideMenu.Controls.Add(this.products);
            this.panelSideMenu.Controls.Add(this.home);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(188, 604);
            this.panelSideMenu.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(70)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 256);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 37);
            this.button5.TabIndex = 5;
            this.button5.Text = "Manage Users";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pOrder
            // 
            this.pOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(70)))));
            this.pOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pOrder.FlatAppearance.BorderSize = 0;
            this.pOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pOrder.Image = ((System.Drawing.Image)(resources.GetObject("pOrder.Image")));
            this.pOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pOrder.Location = new System.Drawing.Point(0, 219);
            this.pOrder.Margin = new System.Windows.Forms.Padding(2);
            this.pOrder.Name = "pOrder";
            this.pOrder.Size = new System.Drawing.Size(188, 37);
            this.pOrder.TabIndex = 4;
            this.pOrder.Text = "Purchase Order";
            this.pOrder.UseVisualStyleBackColor = false;
            this.pOrder.Click += new System.EventHandler(this.pOrder_Click);
            // 
            // sproducts
            // 
            this.sproducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(70)))));
            this.sproducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.sproducts.FlatAppearance.BorderSize = 0;
            this.sproducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sproducts.Image = ((System.Drawing.Image)(resources.GetObject("sproducts.Image")));
            this.sproducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sproducts.Location = new System.Drawing.Point(0, 182);
            this.sproducts.Margin = new System.Windows.Forms.Padding(2);
            this.sproducts.Name = "sproducts";
            this.sproducts.Size = new System.Drawing.Size(188, 37);
            this.sproducts.TabIndex = 3;
            this.sproducts.Text = "Search Products";
            this.sproducts.UseVisualStyleBackColor = false;
            this.sproducts.Click += new System.EventHandler(this.sproducts_Click);
            // 
            // products
            // 
            this.products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(70)))));
            this.products.Dock = System.Windows.Forms.DockStyle.Top;
            this.products.FlatAppearance.BorderSize = 0;
            this.products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products.Image = ((System.Drawing.Image)(resources.GetObject("products.Image")));
            this.products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.products.Location = new System.Drawing.Point(0, 145);
            this.products.Margin = new System.Windows.Forms.Padding(2);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(188, 37);
            this.products.TabIndex = 2;
            this.products.Text = "Products";
            this.products.UseVisualStyleBackColor = false;
            this.products.Click += new System.EventHandler(this.button2_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(70)))));
            this.home.Dock = System.Windows.Forms.DockStyle.Top;
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(0, 108);
            this.home.Margin = new System.Windows.Forms.Padding(2);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(188, 37);
            this.home.TabIndex = 1;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(70)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(188, 108);
            this.panelLogo.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContainer.Controls.Add(this.manageusers1);
            this.panelContainer.Controls.Add(this.searchproduct1);
            this.panelContainer.Controls.Add(this.porder1);
            this.panelContainer.Controls.Add(this.products1);
            this.panelContainer.Controls.Add(this.home1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(188, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(954, 604);
            this.panelContainer.TabIndex = 1;
            // 
            // manageusers1
            // 
            this.manageusers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageusers1.Location = new System.Drawing.Point(0, 0);
            this.manageusers1.Name = "manageusers1";
            this.manageusers1.Size = new System.Drawing.Size(954, 604);
            this.manageusers1.TabIndex = 4;
            this.manageusers1.Load += new System.EventHandler(this.manageusers1_Load);
            // 
            // searchproduct1
            // 
            this.searchproduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchproduct1.Location = new System.Drawing.Point(0, 0);
            this.searchproduct1.Name = "searchproduct1";
            this.searchproduct1.Size = new System.Drawing.Size(954, 604);
            this.searchproduct1.TabIndex = 3;
            this.searchproduct1.Load += new System.EventHandler(this.searchproduct1_Load);
            // 
            // porder1
            // 
            this.porder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.porder1.Location = new System.Drawing.Point(0, 0);
            this.porder1.Margin = new System.Windows.Forms.Padding(2);
            this.porder1.Name = "porder1";
            this.porder1.Size = new System.Drawing.Size(954, 604);
            this.porder1.TabIndex = 2;
            // 
            // products1
            // 
            this.products1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.products1.Location = new System.Drawing.Point(0, 0);
            this.products1.Margin = new System.Windows.Forms.Padding(2);
            this.products1.Name = "products1";
            this.products1.Size = new System.Drawing.Size(954, 604);
            this.products1.TabIndex = 1;
            this.products1.Load += new System.EventHandler(this.products1_Load);
            // 
            // home1
            // 
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(954, 604);
            this.home1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1142, 604);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Point of sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button pOrder;
        private System.Windows.Forms.Button sproducts;
        private System.Windows.Forms.Button products;
        private System.Windows.Forms.Panel panelContainer;
        private Products products1;
        private Home home1;
        private Porder porder1;
        private searchproduct searchproduct1;
        private Manageusers manageusers1;
    }
}

