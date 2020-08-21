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
            this.button1 = new System.Windows.Forms.Button();
            this.pOrder = new System.Windows.Forms.Button();
            this.sproducts = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.manageusers1 = new project.Home();
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
            this.panelSideMenu.Controls.Add(this.button1);
            this.panelSideMenu.Controls.Add(this.pOrder);
            this.panelSideMenu.Controls.Add(this.sproducts);
            this.panelSideMenu.Controls.Add(this.products);
            this.panelSideMenu.Controls.Add(this.home);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(251, 743);
            this.panelSideMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(70)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update Products";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pOrder
            // 
            this.pOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(70)))));
            this.pOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pOrder.FlatAppearance.BorderSize = 0;
            this.pOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pOrder.Image = ((System.Drawing.Image)(resources.GetObject("pOrder.Image")));
            this.pOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pOrder.Location = new System.Drawing.Point(0, 225);
            this.pOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pOrder.Name = "pOrder";
            this.pOrder.Size = new System.Drawing.Size(251, 46);
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
            this.sproducts.Location = new System.Drawing.Point(0, 179);
            this.sproducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sproducts.Name = "sproducts";
            this.sproducts.Size = new System.Drawing.Size(251, 46);
            this.sproducts.TabIndex = 3;
            this.sproducts.Text = "Delete Products";
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
            this.products.Location = new System.Drawing.Point(0, 133);
            this.products.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(251, 46);
            this.products.TabIndex = 2;
            this.products.Text = "Products";
            this.products.UseVisualStyleBackColor = false;
            this.products.Click += new System.EventHandler(this.button2_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(70)))));
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(0, 133);
            this.home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(251, 46);
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
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(251, 133);
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
            this.panelContainer.Location = new System.Drawing.Point(251, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1272, 743);
            this.panelContainer.TabIndex = 1;
            // 
            // manageusers1
            // 
            this.manageusers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageusers1.Location = new System.Drawing.Point(0, 0);
            this.manageusers1.Margin = new System.Windows.Forms.Padding(5);
            this.manageusers1.Name = "manageusers1";
            this.manageusers1.Size = new System.Drawing.Size(1272, 743);
            this.manageusers1.TabIndex = 4;
            this.manageusers1.Load += new System.EventHandler(this.manageusers1_Load);
            // 
            // searchproduct1
            // 
            this.searchproduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchproduct1.Location = new System.Drawing.Point(0, 0);
            this.searchproduct1.Margin = new System.Windows.Forms.Padding(5);
            this.searchproduct1.Name = "searchproduct1";
            this.searchproduct1.Size = new System.Drawing.Size(1272, 743);
            this.searchproduct1.TabIndex = 3;
            this.searchproduct1.Load += new System.EventHandler(this.searchproduct1_Load);
            // 
            // porder1
            // 
            this.porder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.porder1.Location = new System.Drawing.Point(0, 0);
            this.porder1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.porder1.Name = "porder1";
            this.porder1.Size = new System.Drawing.Size(1272, 743);
            this.porder1.TabIndex = 2;
            // 
            // products1
            // 
            this.products1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.products1.Location = new System.Drawing.Point(0, 0);
            this.products1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.products1.Name = "products1";
            this.products1.Size = new System.Drawing.Size(1272, 743);
            this.products1.TabIndex = 1;
            this.products1.Load += new System.EventHandler(this.products1_Load);
            // 
            // home1
            // 
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1272, 743);
            this.home1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1523, 743);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button pOrder;
        private System.Windows.Forms.Button sproducts;
        private System.Windows.Forms.Button products;
        private System.Windows.Forms.Panel panelContainer;
        private Products products1;
        private Home home1;
        private Porder porder1;
        private searchproduct searchproduct1;
        private Home manageusers1;
        private System.Windows.Forms.Button button1;
    }
}

