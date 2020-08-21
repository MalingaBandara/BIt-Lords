namespace project
{
    partial class searchproduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddf = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ddf)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // pname
            // 
            this.pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pname.Location = new System.Drawing.Point(230, 130);
            this.pname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(309, 36);
            this.pname.TabIndex = 1;
            this.pname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Delete Products";
            // 
            // ddf
            // 
            this.ddf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ddf.Location = new System.Drawing.Point(40, 345);
            this.ddf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ddf.Name = "ddf";
            this.ddf.RowHeadersWidth = 51;
            this.ddf.Size = new System.Drawing.Size(1121, 322);
            this.ddf.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // searchproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ddf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "searchproduct";
            this.Size = new System.Drawing.Size(1272, 743);
            ((System.ComponentModel.ISupportInitialize)(this.ddf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ddf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
