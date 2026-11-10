namespace adproject
{
    partial class AdminDashboard
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            btnCustomers = new Button();
            btnOrders = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            lblOrders = new Label();
            lblProducts = new Label();
            lblTotalSales = new Label();
            panel1 = new Panel();
            label9 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            viewProductReviews = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(417, 22);
            label1.Name = "label1";
            label1.Size = new Size(240, 28);
            label1.TabIndex = 0;
            label1.Text = "Welcome back, Admin!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 215);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 147);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(3, 37);
            button1.Name = "button1";
            button1.Size = new Size(200, 47);
            button1.TabIndex = 4;
            button1.Text = "📦 Manage Products";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.ForestGreen;
            btnCustomers.ForeColor = SystemColors.ButtonHighlight;
            btnCustomers.Location = new Point(3, 101);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(200, 51);
            btnCustomers.TabIndex = 5;
            btnCustomers.Text = "👥 Manage Customers";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.ForestGreen;
            btnOrders.ForeColor = SystemColors.ButtonHighlight;
            btnOrders.Location = new Point(3, 178);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(200, 49);
            btnOrders.TabIndex = 6;
            btnOrders.Text = "\U0001f6d2 Manage Orders      ";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            btnOrders.MouseEnter += btnOrders_MouseEnter;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.ForestGreen;
            btnReports.ForeColor = SystemColors.ButtonHighlight;
            btnReports.Location = new Point(3, 248);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 51);
            btnReports.TabIndex = 7;
            btnReports.Text = "📊 Reports                 ";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.OrangeRed;
            btnLogout.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(10, 608);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(181, 45);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "🚪 Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.Location = new Point(29, 10);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(53, 20);
            lblOrders.TabIndex = 9;
            lblOrders.Text = "Orders";
            lblOrders.Click += lblOrders_Click;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Location = new Point(22, 10);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(66, 20);
            lblProducts.TabIndex = 10;
            lblProducts.Text = "Products";
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Location = new Point(27, 10);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(76, 20);
            lblTotalSales.TabIndex = 11;
            lblTotalSales.Text = "TotalSales";
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnCustomers);
            panel1.Controls.Add(btnOrders);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnLogout);
            panel1.Location = new Point(2, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 690);
            panel1.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(3, 17);
            label9.Name = "label9";
            label9.Size = new Size(138, 31);
            label9.TabIndex = 1;
            label9.Text = "☰ GreenLife";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(38, 48);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 2;
            label4.Text = "Admin Panel";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 86);
            panel2.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2026_02_01_152332;
            pictureBox1.Location = new Point(20, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = Properties.Resources.Screenshot_2026_02_01_152500;
            pictureBox2.Location = new Point(22, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 114);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Screenshot_2026_02_01_152533;
            pictureBox3.Location = new Point(27, 94);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(91, 114);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(lblOrders);
            panel3.Location = new Point(280, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(148, 257);
            panel3.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(lblProducts);
            panel4.Location = new Point(509, 110);
            panel4.Name = "panel4";
            panel4.Size = new Size(148, 257);
            panel4.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveBorder;
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(lblTotalSales);
            panel5.Location = new Point(764, 110);
            panel5.Name = "panel5";
            panel5.Size = new Size(148, 257);
            panel5.TabIndex = 21;
            // 
            // viewProductReviews
            // 
            viewProductReviews.BackColor = SystemColors.Info;
            viewProductReviews.Location = new Point(842, 28);
            viewProductReviews.Name = "viewProductReviews";
            viewProductReviews.Size = new Size(153, 60);
            viewProductReviews.TabIndex = 23;
            viewProductReviews.Text = "view Product Reviews";
            viewProductReviews.UseVisualStyleBackColor = false;
            viewProductReviews.Click += viewProductReviews_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1019, 774);
            Controls.Add(viewProductReviews);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button btnCustomers;
        private Button btnOrders;
        private Button btnReports;
        private Button btnLogout;
        private Label lblOrders;
        private Label lblProducts;
        private Label lblTotalSales;
        private Panel panel1;
        private Label label9;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button viewProductReviews;
    }
}