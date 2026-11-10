namespace adproject
{
    partial class ProductSearch
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbCategory = new ComboBox();
            txtName = new TextBox();
            txtMinPrice = new TextBox();
            txtMaxPrice = new TextBox();
            dgvProducts = new DataGridView();
            btnSearch = new Button();
            panel1 = new Panel();
            label7 = new Label();
            btnBack = new Button();
            rtbNewReview = new RichTextBox();
            cmbRating = new ComboBox();
            lblAddReview = new Label();
            btnSubmitReview = new Button();
            rtbReviews = new RichTextBox();
            lblReviewCount = new Label();
            lblRating = new Label();
            pbProduct = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(115, 39);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Search Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 122);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Name -";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 305);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Price - ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 211);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 3;
            label4.Text = "🗂 Category - ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 305);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 4;
            label5.Text = "Min";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(395, 305);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 5;
            label6.Text = "Max";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(188, 211);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(432, 28);
            cmbCategory.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(188, 119);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(516, 50);
            txtName.TabIndex = 7;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new Point(215, 292);
            txtMinPrice.Multiline = true;
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new Size(132, 44);
            txtMinPrice.TabIndex = 8;
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Location = new Point(465, 292);
            txtMaxPrice.Multiline = true;
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Size = new Size(155, 47);
            txtMaxPrice.TabIndex = 9;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 369);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(632, 389);
            dgvProducts.TabIndex = 10;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(725, 120);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(62, 46);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "🔍 Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBack);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 78);
            panel1.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(54, 25);
            label7.Name = "label7";
            label7.Size = new Size(55, 38);
            label7.TabIndex = 1;
            label7.Text = "🔍";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(50, 29);
            btnBack.TabIndex = 17;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // rtbNewReview
            // 
            rtbNewReview.Location = new Point(59, 492);
            rtbNewReview.Name = "rtbNewReview";
            rtbNewReview.Size = new Size(239, 70);
            rtbNewReview.TabIndex = 29;
            rtbNewReview.Text = "";
            // 
            // cmbRating
            // 
            cmbRating.FormattingEnabled = true;
            cmbRating.Location = new Point(59, 409);
            cmbRating.Name = "cmbRating";
            cmbRating.Size = new Size(151, 28);
            cmbRating.TabIndex = 28;
            // 
            // lblAddReview
            // 
            lblAddReview.AutoSize = true;
            lblAddReview.Location = new Point(59, 449);
            lblAddReview.Name = "lblAddReview";
            lblAddReview.Size = new Size(111, 20);
            lblAddReview.TabIndex = 27;
            lblAddReview.Text = "Write a Review:";
            // 
            // btnSubmitReview
            // 
            btnSubmitReview.Location = new Point(176, 443);
            btnSubmitReview.Name = "btnSubmitReview";
            btnSubmitReview.Size = new Size(136, 36);
            btnSubmitReview.TabIndex = 21;
            btnSubmitReview.Text = "Add Review";
            btnSubmitReview.UseVisualStyleBackColor = true;
            btnSubmitReview.Click += btnSubmitReview_Click;
            // 
            // rtbReviews
            // 
            rtbReviews.Location = new Point(59, 283);
            rtbReviews.Name = "rtbReviews";
            rtbReviews.Size = new Size(221, 120);
            rtbReviews.TabIndex = 26;
            rtbReviews.Text = "";
            // 
            // lblReviewCount
            // 
            lblReviewCount.AutoSize = true;
            lblReviewCount.BackColor = SystemColors.HighlightText;
            lblReviewCount.Location = new Point(59, 249);
            lblReviewCount.Name = "lblReviewCount";
            lblReviewCount.Size = new Size(50, 20);
            lblReviewCount.TabIndex = 25;
            lblReviewCount.Text = "label7";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.BackColor = SystemColors.HighlightText;
            lblRating.Location = new Point(59, 217);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(50, 20);
            lblRating.TabIndex = 24;
            lblRating.Text = "label6";
            // 
            // pbProduct
            // 
            pbProduct.BackColor = Color.Transparent;
            pbProduct.Location = new Point(59, 29);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(210, 176);
            pbProduct.TabIndex = 23;
            pbProduct.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HighlightText;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(rtbNewReview);
            panel3.Controls.Add(pbProduct);
            panel3.Controls.Add(btnSubmitReview);
            panel3.Controls.Add(lblAddReview);
            panel3.Controls.Add(cmbRating);
            panel3.Controls.Add(lblRating);
            panel3.Controls.Add(lblReviewCount);
            panel3.Controls.Add(rtbReviews);
            panel3.Location = new Point(669, 211);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 582);
            panel3.TabIndex = 22;
            // 
            // ProductSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1019, 805);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(btnSearch);
            Controls.Add(dgvProducts);
            Controls.Add(txtMaxPrice);
            Controls.Add(txtMinPrice);
            Controls.Add(txtName);
            Controls.Add(cmbCategory);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ProductSearch";
            Text = "ProductSearch";
            Load += ProductSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbCategory;
        private TextBox txtName;
        private TextBox txtMinPrice;
        private TextBox txtMaxPrice;
        private DataGridView dgvProducts;
        private Button btnSearch;
        private Panel panel1;
        private Label label7;
        private Button btnBack;
        private RichTextBox rtbNewReview;
        private ComboBox cmbRating;
        private Label lblAddReview;
        private Button btnSubmitReview;
        private RichTextBox rtbReviews;
        private Label lblReviewCount;
        private Label lblRating;
        private PictureBox pbProduct;
        private Panel panel3;
    }
}