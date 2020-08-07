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
            this.mUser = new System.Windows.Forms.Button();
            this.pOrder = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.porder1 = new project.Porder();
            this.products1 = new project.Products();
            this.home1 = new project.Home();
            this.manage_User1 = new project.Manage_User();
            this.panelSideMenu.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(70)))));
            this.panelSideMenu.Controls.Add(this.mUser);
            this.panelSideMenu.Controls.Add(this.pOrder);
            this.panelSideMenu.Controls.Add(this.button3);
            this.panelSideMenu.Controls.Add(this.products);
            this.panelSideMenu.Controls.Add(this.home);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(188, 462);
            this.panelSideMenu.TabIndex = 0;
            // 
            // mUser
            // 
            this.mUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(70)))));
            this.mUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.mUser.FlatAppearance.BorderSize = 0;
            this.mUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mUser.Image = ((System.Drawing.Image)(resources.GetObject("mUser.Image")));
            this.mUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mUser.Location = new System.Drawing.Point(0, 256);
            this.mUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mUser.Name = "mUser";
            this.mUser.Size = new System.Drawing.Size(188, 37);
            this.mUser.TabIndex = 5;
            this.mUser.Text = "Manage Users";
            this.mUser.UseVisualStyleBackColor = false;
            this.mUser.Click += new System.EventHandler(this.button5_Click);
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
            this.pOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pOrder.Name = "pOrder";
            this.pOrder.Size = new System.Drawing.Size(188, 37);
            this.pOrder.TabIndex = 4;
            this.pOrder.Text = "Purchase Order";
            this.pOrder.UseVisualStyleBackColor = false;
            this.pOrder.Click += new System.EventHandler(this.pOrder_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(70)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 182);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Search Products";
            this.button3.UseVisualStyleBackColor = false;
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
            this.products.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(188, 108);
            this.panelLogo.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContainer.Controls.Add(this.manage_User1);
            this.panelContainer.Controls.Add(this.porder1);
            this.panelContainer.Controls.Add(this.products1);
            this.panelContainer.Controls.Add(this.home1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(188, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(681, 462);
            this.panelContainer.TabIndex = 1;
            // 
            // porder1
            // 
            this.porder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.porder1.Location = new System.Drawing.Point(0, 0);
            this.porder1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.porder1.Name = "porder1";
            this.porder1.Size = new System.Drawing.Size(681, 462);
            this.porder1.TabIndex = 2;
            // 
            // products1
            // 
            this.products1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.products1.Location = new System.Drawing.Point(0, 0);
            this.products1.Margin = new System.Windows.Forms.Padding(2);
            this.products1.Name = "products1";
            this.products1.Size = new System.Drawing.Size(681, 462);
            this.products1.TabIndex = 1;
            this.products1.Load += new System.EventHandler(this.products1_Load);
            // 
            // home1
            // 
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(681, 462);
            this.home1.TabIndex = 0;
            // 
            // manage_User1
            // 
            this.manage_User1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manage_User1.Location = new System.Drawing.Point(0, 0);
            this.manage_User1.Name = "manage_User1";
            this.manage_User1.Size = new System.Drawing.Size(681, 462);
            this.manage_User1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(869, 462);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button mUser;
        private System.Windows.Forms.Button pOrder;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button products;
        private System.Windows.Forms.Panel panelContainer;
        private Products products1;
        private Home home1;
        private Porder porder1;
        private Manage_User manage_User1;
    }
}

