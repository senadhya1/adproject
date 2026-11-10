namespace adproject
{
    partial class Cart_Checkout
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
            btnPlaceOrder = new Button();
            btnContinue = new Button();
            dgvCart = new DataGridView();
            lblTotalAmount = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(63, 39);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Shopping Cart";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 14);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Total Amount";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = SystemColors.ActiveCaption;
            btnPlaceOrder.Location = new Point(49, 489);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(774, 70);
            btnPlaceOrder.TabIndex = 2;
            btnPlaceOrder.Text = "🛍️ Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.ForestGreen;
            btnContinue.ForeColor = SystemColors.ButtonHighlight;
            btnContinue.Location = new Point(49, 602);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(774, 59);
            btnContinue.TabIndex = 3;
            btnContinue.Text = "\U0001f6d2 Continue Shopping";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(49, 185);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(774, 186);
            dgvCart.TabIndex = 4;
            dgvCart.CellClick += dgvCart_CellClick;
            dgvCart.CellContentClick += dgvCart_CellContentClick;
            dgvCart.CellValueChanged += dgvCart_CellValueChanged;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(218, 14);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(15, 20);
            lblTotalAmount.TabIndex = 5;
            lblTotalAmount.Text = "-";
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 88);
            panel1.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(3, 25);
            label7.Name = "label7";
            label7.Size = new Size(55, 38);
            label7.TabIndex = 1;
            label7.Text = "\U0001f6d2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 18;
            label3.Text = "Your Cart Items";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblTotalAmount);
            panel2.Location = new Point(49, 413);
            panel2.Name = "panel2";
            panel2.Size = new Size(774, 50);
            panel2.TabIndex = 19;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(913, 96);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 20;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Cart_Checkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 774);
            Controls.Add(btnBack);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(dgvCart);
            Controls.Add(btnContinue);
            Controls.Add(btnPlaceOrder);
            Controls.Add(panel2);
            Name = "Cart_Checkout";
            Text = "Cart_Checkout";
            Load += Cart_Checkout_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnPlaceOrder;
        private Button btnContinue;
        private DataGridView dgvCart;
        private Label lblTotalAmount;
        private Panel panel1;
        private Label label7;
        private Label label3;
        private Panel panel2;
        private Button btnBack;
    }
}