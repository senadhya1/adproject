namespace adproject
{
    partial class ProductManagement
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
            label7 = new Label();
            label8 = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtSupplier = new TextBox();
            txtCategory = new TextBox();
            txtStock = new TextBox();
            txtDiscount = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvProducts = new DataGridView();
            label9 = new Label();
            lblLowStock = new Label();
            btnBack = new Button();
            pbProduct = new PictureBox();
            btnBrowseImage = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(60, 12);
            label1.Name = "label1";
            label1.Size = new Size(205, 25);
            label1.TabIndex = 0;
            label1.Text = "Product Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Location = new Point(18, 349);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Name ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(18, 399);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Location = new Point(18, 445);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 3;
            label4.Text = "Supplier";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Location = new Point(18, 499);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Location = new Point(18, 542);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 5;
            label6.Text = "Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gainsboro;
            label7.Location = new Point(18, 588);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 6;
            label7.Text = "Discount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(377, 196);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 7;
            label8.Text = "Product List";
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 346);
            txtName.Name = "txtName";
            txtName.Size = new Size(132, 27);
            txtName.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(138, 392);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(132, 27);
            txtPrice.TabIndex = 9;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(138, 438);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(132, 27);
            txtSupplier.TabIndex = 10;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(138, 492);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(132, 27);
            txtCategory.TabIndex = 11;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(138, 542);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(132, 27);
            txtStock.TabIndex = 12;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(138, 588);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(132, 27);
            txtDiscount.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(26, 655);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 40);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "✚ Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Location = new Point(162, 595);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 40);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "↻ Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(26, 718);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 39);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "🗑 Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlDarkDark;
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(176, 718);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 39);
            btnClear.TabIndex = 17;
            btnClear.Text = "⌫ Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(377, 219);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(613, 538);
            dgvProducts.TabIndex = 18;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Wheat;
            label9.Location = new Point(515, 115);
            label9.Name = "label9";
            label9.Size = new Size(147, 20);
            label9.TabIndex = 19;
            label9.Text = "Low Stock Alert Area";
            label9.Click += label9_Click;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.BackColor = Color.Wheat;
            lblLowStock.Location = new Point(799, 115);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(58, 20);
            lblLowStock.TabIndex = 20;
            lblLowStock.Text = "label10";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(8, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(46, 29);
            btnBack.TabIndex = 21;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pbProduct
            // 
            pbProduct.Location = new Point(14, 42);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(267, 159);
            pbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProduct.TabIndex = 22;
            pbProduct.TabStop = false;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.BackColor = SystemColors.ActiveCaption;
            btnBrowseImage.Location = new Point(37, 275);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(213, 37);
            btnBrowseImage.TabIndex = 23;
            btnBrowseImage.Text = "Browse Image";
            btnBrowseImage.UseVisualStyleBackColor = false;
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(button1);
            panel1.ForeColor = Color.Wheat;
            panel1.Location = new Point(401, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 101);
            panel1.TabIndex = 24;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(23, 21);
            button1.Name = "button1";
            button1.Size = new Size(63, 56);
            button1.TabIndex = 26;
            button1.Text = "⚠ ";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pbProduct);
            panel2.Controls.Add(btnUpdate);
            panel2.Location = new Point(12, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 704);
            panel2.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnBack);
            panel3.Location = new Point(1, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1017, 74);
            panel3.TabIndex = 26;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 774);
            Controls.Add(panel3);
            Controls.Add(btnBrowseImage);
            Controls.Add(lblLowStock);
            Controls.Add(label9);
            Controls.Add(dgvProducts);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtDiscount);
            Controls.Add(txtStock);
            Controls.Add(txtCategory);
            Controls.Add(txtSupplier);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ProductManagement";
            Text = "ProductManagement";
            Load += ProductManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
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
        private Label label7;
        private Label label8;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtSupplier;
        private TextBox txtCategory;
        private TextBox txtStock;
        private TextBox txtDiscount;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvProducts;
        private Label label9;
        private Label lblLowStock;
        private Button btnBack;
        private PictureBox pbProduct;
        private Button btnBrowseImage;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
    }
}