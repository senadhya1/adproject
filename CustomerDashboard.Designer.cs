namespace adproject
{
    partial class CustomerDashboard
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
            btnSearchProducts = new Button();
            btnMyOrders = new Button();
            btnProfile = new Button();
            btnLogout = new Button();
            dgvProducts = new DataGridView();
            btnOrderTracking = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            btnSubmitReview = new Button();
            pbProduct = new PictureBox();
            lblRating = new Label();
            lblReviewCount = new Label();
            rtbReviews = new RichTextBox();
            lblAddReview = new Label();
            cmbRating = new ComboBox();
            rtbNewReview = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 198);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 1;
            label2.Text = " Latest Products ";
            // 
            // btnSearchProducts
            // 
            btnSearchProducts.Location = new Point(689, 12);
            btnSearchProducts.Name = "btnSearchProducts";
            btnSearchProducts.Size = new Size(55, 29);
            btnSearchProducts.TabIndex = 2;
            btnSearchProducts.Text = "🔍";
            btnSearchProducts.UseVisualStyleBackColor = true;
            btnSearchProducts.Click += btnSearchProducts_Click;
            // 
            // btnMyOrders
            // 
            btnMyOrders.Location = new Point(750, 12);
            btnMyOrders.Name = "btnMyOrders";
            btnMyOrders.Size = new Size(57, 29);
            btnMyOrders.TabIndex = 3;
            btnMyOrders.Text = "\U0001f6d2";
            btnMyOrders.UseVisualStyleBackColor = true;
            btnMyOrders.Click += btnMyOrders_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(813, 12);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(53, 29);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "👤";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 128, 128);
            btnLogout.Location = new Point(889, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "🚪Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 242);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(557, 317);
            dgvProducts.TabIndex = 6;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // btnOrderTracking
            // 
            btnOrderTracking.BackColor = SystemColors.ActiveCaption;
            btnOrderTracking.Location = new Point(820, 113);
            btnOrderTracking.Name = "btnOrderTracking";
            btnOrderTracking.Size = new Size(149, 44);
            btnOrderTracking.TabIndex = 7;
            btnOrderTracking.Text = " 📍Order Tracking";
            btnOrderTracking.UseVisualStyleBackColor = false;
            btnOrderTracking.Click += btnOrderTracking_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 66);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(189, 10);
            label3.Name = "label3";
            label3.Size = new Size(239, 28);
            label3.TabIndex = 9;
            label3.Text = "Welcome to GreenLife!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(189, 51);
            label4.Name = "label4";
            label4.Size = new Size(306, 20);
            label4.TabIndex = 10;
            label4.Text = "Browse our latest products and special offers";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(8, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(799, 98);
            panel2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(820, 84);
            label5.Name = "label5";
            label5.Size = new Size(154, 20);
            label5.TabIndex = 12;
            label5.Text = "Track your Order Here";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HighlightText;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Location = new Point(633, 218);
            panel3.Name = "panel3";
            panel3.Size = new Size(365, 640);
            panel3.TabIndex = 13;
            // 
            // btnSubmitReview
            // 
            btnSubmitReview.Location = new Point(811, 657);
            btnSubmitReview.Name = "btnSubmitReview";
            btnSubmitReview.Size = new Size(136, 36);
            btnSubmitReview.TabIndex = 13;
            btnSubmitReview.Text = "Add Review";
            btnSubmitReview.UseVisualStyleBackColor = true;
            btnSubmitReview.Click += btnSubmitReview_Click_1;
            // 
            // pbProduct
            // 
            pbProduct.BackColor = SystemColors.Window;
            pbProduct.Location = new Point(694, 242);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(210, 176);
            pbProduct.TabIndex = 14;
            pbProduct.TabStop = false;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.BackColor = SystemColors.HighlightText;
            lblRating.Location = new Point(694, 436);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(50, 20);
            lblRating.TabIndex = 15;
            lblRating.Text = "label6";
            // 
            // lblReviewCount
            // 
            lblReviewCount.AutoSize = true;
            lblReviewCount.BackColor = SystemColors.HighlightText;
            lblReviewCount.Location = new Point(694, 456);
            lblReviewCount.Name = "lblReviewCount";
            lblReviewCount.Size = new Size(50, 20);
            lblReviewCount.TabIndex = 16;
            lblReviewCount.Text = "label7";
            // 
            // rtbReviews
            // 
            rtbReviews.Location = new Point(694, 479);
            rtbReviews.Name = "rtbReviews";
            rtbReviews.Size = new Size(221, 120);
            rtbReviews.TabIndex = 17;
            rtbReviews.Text = "";
            // 
            // lblAddReview
            // 
            lblAddReview.AutoSize = true;
            lblAddReview.Location = new Point(694, 662);
            lblAddReview.Name = "lblAddReview";
            lblAddReview.Size = new Size(111, 20);
            lblAddReview.TabIndex = 18;
            lblAddReview.Text = "Write a Review:";
            // 
            // cmbRating
            // 
            cmbRating.FormattingEnabled = true;
            cmbRating.Location = new Point(694, 605);
            cmbRating.Name = "cmbRating";
            cmbRating.Size = new Size(151, 28);
            cmbRating.TabIndex = 19;
            // 
            // rtbNewReview
            // 
            rtbNewReview.Location = new Point(694, 699);
            rtbNewReview.Name = "rtbNewReview";
            rtbNewReview.Size = new Size(239, 120);
            rtbNewReview.TabIndex = 20;
            rtbNewReview.Text = "";
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 870);
            Controls.Add(label5);
            Controls.Add(rtbNewReview);
            Controls.Add(btnOrderTracking);
            Controls.Add(cmbRating);
            Controls.Add(lblAddReview);
            Controls.Add(btnSubmitReview);
            Controls.Add(rtbReviews);
            Controls.Add(lblReviewCount);
            Controls.Add(lblRating);
            Controls.Add(pbProduct);
            Controls.Add(panel3);
            Controls.Add(dgvProducts);
            Controls.Add(btnProfile);
            Controls.Add(btnMyOrders);
            Controls.Add(btnSearchProducts);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "CustomerDashboard";
            Text = "CustomerDashboard";
            Load += CustomerDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSearchProducts;
        private Button btnMyOrders;
        private Button btnProfile;
        private Button btnLogout;
        private DataGridView dgvProducts;
        private Button btnOrderTracking;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private Button btnSubmitReview;
        private PictureBox pbProduct;
        private Label lblRating;
        private Label lblReviewCount;
        private RichTextBox rtbReviews;
        private Label lblAddReview;
        private ComboBox cmbRating;
        private RichTextBox rtbNewReview;
    }
}