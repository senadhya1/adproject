namespace adproject
{
    partial class ProductReviews
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
            btnSearch = new Button();
            txtSearchName = new TextBox();
            dgvProducts = new DataGridView();
            pbProduct = new PictureBox();
            rtbReviews = new RichTextBox();
            lblProductName = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            btnBack = new Button();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(382, 120);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 47);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(32, 119);
            txtSearchName.Multiline = true;
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(322, 48);
            txtSearchName.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 184);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(644, 403);
            dgvProducts.TabIndex = 3;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // pbProduct
            // 
            pbProduct.Location = new Point(742, 119);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(228, 215);
            pbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProduct.TabIndex = 4;
            pbProduct.TabStop = false;
            // 
            // rtbReviews
            // 
            rtbReviews.Location = new Point(690, 432);
            rtbReviews.Name = "rtbReviews";
            rtbReviews.Size = new Size(310, 155);
            rtbReviews.TabIndex = 5;
            rtbReviews.Text = "";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(726, 368);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(0, 20);
            lblProductName.TabIndex = 6;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(800, 368);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 20);
            lblPrice.TabIndex = 7;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(885, 368);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(0, 20);
            lblStock.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(49, 29);
            btnBack.TabIndex = 9;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1027, 91);
            panel1.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(58, 25);
            label9.Name = "label9";
            label9.Size = new Size(55, 38);
            label9.TabIndex = 1;
            label9.Text = "📦";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.ForestGreen;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(130, 39);
            label8.Name = "label8";
            label8.Size = new Size(125, 20);
            label8.TabIndex = 0;
            label8.Text = "Product Reviews";
            // 
            // ProductReviews
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 685);
            Controls.Add(panel1);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblProductName);
            Controls.Add(rtbReviews);
            Controls.Add(pbProduct);
            Controls.Add(dgvProducts);
            Controls.Add(txtSearchName);
            Controls.Add(btnSearch);
            Name = "ProductReviews";
            Text = "ProductReviews";
            Load += ProductReviews_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearchName;
        private DataGridView dgvProducts;
        private PictureBox pbProduct;
        private RichTextBox rtbReviews;
        private Label lblProductName;
        private Label lblPrice;
        private Label lblStock;
        private Button btnBack;
        private Panel panel1;
        private Label label9;
        private Label label8;
    }
}