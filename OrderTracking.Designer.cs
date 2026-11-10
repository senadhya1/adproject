namespace adproject
{
    partial class OrderTracking
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
            dgvOrders = new DataGridView();
            pbProduct = new PictureBox();
            txtProductName = new TextBox();
            txtQty = new TextBox();
            txtPrice = new TextBox();
            txtSubtotal = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            btnBack = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 33);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "My Orders";
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(27, 300);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(675, 315);
            dgvOrders.TabIndex = 1;
            dgvOrders.CellClick += dgvOrders_CellClick;
            // 
            // pbProduct
            // 
            pbProduct.Location = new Point(39, 100);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(256, 189);
            pbProduct.TabIndex = 2;
            pbProduct.TabStop = false;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(332, 145);
            txtProductName.Multiline = true;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(168, 45);
            txtProductName.TabIndex = 3;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(690, 145);
            txtQty.Multiline = true;
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(174, 37);
            txtQty.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(332, 223);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(168, 55);
            txtPrice.TabIndex = 5;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(690, 223);
            txtSubtotal.Multiline = true;
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(174, 55);
            txtSubtotal.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 109);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 7;
            label2.Text = "Product Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnBack);
            panel3.Location = new Point(-5, -5);
            panel3.Name = "panel3";
            panel3.Size = new Size(973, 88);
            panel3.TabIndex = 27;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(17, 17);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(46, 29);
            btnBack.TabIndex = 21;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 193);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 28;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(700, 100);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 29;
            label4.Text = "Quentity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(700, 193);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 30;
            label5.Text = "Sub total";
            // 
            // OrderTracking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 672);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(txtSubtotal);
            Controls.Add(txtPrice);
            Controls.Add(txtQty);
            Controls.Add(txtProductName);
            Controls.Add(pbProduct);
            Controls.Add(dgvOrders);
            Name = "OrderTracking";
            Text = "OrderTracking";
            Load += OrderTracking_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvOrders;
        private PictureBox pbProduct;
        private TextBox txtProductName;
        private TextBox txtQty;
        private TextBox txtPrice;
        private TextBox txtSubtotal;
        private Label label2;
        private Panel panel3;
        private Button btnBack;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}