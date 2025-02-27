namespace Computer_Shop_Management_System.PAL
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnDashbord = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTimeAndDate = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.userControlBrand1 = new Computer_Shop_Management_System.PAL.UserControlBrand();
            this.userControlDashbord1 = new Computer_Shop_Management_System.PAL.UserControlDashbord();
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.guna2MouseStateHandler1 = new Guna.UI2.WinForms.Guna2MouseStateHandler(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.pnlMove);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Controls.Add(this.btnBrand);
            this.panel1.Controls.Add(this.btnDashbord);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 560);
            this.panel1.TabIndex = 0;
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.White;
            this.pnlMove.Location = new System.Drawing.Point(15, 197);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(6, 38);
            this.pnlMove.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Computer_Shop_Management_System.Properties.Resources.logout_30;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(17, 508);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "        Log Out";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::Computer_Shop_Management_System.Properties.Resources.user_30;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(20, 464);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(200, 38);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "   Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::Computer_Shop_Management_System.Properties.Resources.report_30;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(20, 420);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 38);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "     Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Image = global::Computer_Shop_Management_System.Properties.Resources.order_30;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(20, 376);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(200, 38);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "     Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::Computer_Shop_Management_System.Properties.Resources.product_30;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(20, 332);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(200, 38);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "      Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = global::Computer_Shop_Management_System.Properties.Resources.category_30;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(20, 288);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(200, 38);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "        Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.FlatAppearance.BorderSize = 0;
            this.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrand.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnBrand.ForeColor = System.Drawing.Color.White;
            this.btnBrand.Image = global::Computer_Shop_Management_System.Properties.Resources.brand_30;
            this.btnBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrand.Location = new System.Drawing.Point(20, 244);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(200, 38);
            this.btnBrand.TabIndex = 0;
            this.btnBrand.Text = "  Brand\r\n";
            this.btnBrand.UseVisualStyleBackColor = true;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnDashbord
            // 
            this.btnDashbord.FlatAppearance.BorderSize = 0;
            this.btnDashbord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashbord.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnDashbord.ForeColor = System.Drawing.Color.White;
            this.btnDashbord.Image = global::Computer_Shop_Management_System.Properties.Resources.dashboard_gauge_30;
            this.btnDashbord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashbord.Location = new System.Drawing.Point(20, 197);
            this.btnDashbord.Name = "btnDashbord";
            this.btnDashbord.Size = new System.Drawing.Size(200, 38);
            this.btnDashbord.TabIndex = 0;
            this.btnDashbord.Text = "          Dashboard";
            this.btnDashbord.UseVisualStyleBackColor = true;
            this.btnDashbord.Click += new System.EventHandler(this.btnDashbord_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer Shop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Computer_Shop_Management_System.Properties.Resources.computer_white_icon;
            this.pictureBox1.Location = new System.Drawing.Point(82, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 3;
            this.guna2Elipse1.TargetControl = this.pnlMove;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.panel2.Controls.Add(this.lblTimeAndDate);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(234, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 61);
            this.panel2.TabIndex = 0;
            // 
            // lblTimeAndDate
            // 
            this.lblTimeAndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeAndDate.AutoSize = true;
            this.lblTimeAndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTimeAndDate.ForeColor = System.Drawing.Color.White;
            this.lblTimeAndDate.Location = new System.Drawing.Point(708, 21);
            this.lblTimeAndDate.Name = "lblTimeAndDate";
            this.lblTimeAndDate.Size = new System.Drawing.Size(35, 28);
            this.lblTimeAndDate.TabIndex = 0;
            this.lblTimeAndDate.Text = "(?)";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(175, 21);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(35, 28);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "(?)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(234, 525);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 35);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Copyright © 2025. All Rights Resrved. Pahan Sanjana";
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.userControlBrand1);
            this.pnlCenter.Controls.Add(this.userControlDashbord1);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(234, 61);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(747, 464);
            this.pnlCenter.TabIndex = 0;
            // 
            // userControlBrand1
            // 
            this.userControlBrand1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlBrand1.BackColor = System.Drawing.Color.White;
            this.userControlBrand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlBrand1.Location = new System.Drawing.Point(0, 0);
            this.userControlBrand1.Name = "userControlBrand1";
            this.userControlBrand1.Size = new System.Drawing.Size(747, 464);
            this.userControlBrand1.TabIndex = 0;
            this.userControlBrand1.Visible = false;
            // 
            // userControlDashbord1
            // 
            this.userControlDashbord1.BackColor = System.Drawing.Color.White;
            this.userControlDashbord1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashbord1.Location = new System.Drawing.Point(0, 0);
            this.userControlDashbord1.Name = "userControlDashbord1";
            this.userControlDashbord1.Size = new System.Drawing.Size(747, 464);
            this.userControlDashbord1.TabIndex = 0;
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 560);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Shop Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FromMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashbord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMove;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTimeAndDate;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Timer timerDateAndTime;
        private UserControlDashbord userControlDashbord1;
        private Guna.UI2.WinForms.Guna2MouseStateHandler guna2MouseStateHandler1;
        private UserControlBrand userControlBrand1;
    }
}