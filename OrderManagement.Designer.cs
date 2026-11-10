namespace adproject
{
    partial class OrderManagement
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtOrderID = new TextBox();
            dgvOrders = new DataGridView();
            txtCustomer = new TextBox();
            label7 = new Label();
            cmbStatus = new ComboBox();
            btnUpdateStatus = new Button();
            btnClear = new Button();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            btnBack = new Button();
            rtbOrderItems = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 104);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Order ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 193);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 329);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Orders List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(496, 247);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(514, 168);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 5;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(24, 138);
            txtOrderID.Multiline = true;
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(191, 50);
            txtOrderID.TabIndex = 6;
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(24, 367);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(586, 395);
            dgvOrders.TabIndex = 7;
            dgvOrders.CellClick += dgvOrders_CellClick;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(327, 138);
            txtCustomer.Multiline = true;
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(236, 50);
            txtCustomer.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(327, 104);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 9;
            label7.Text = "Customer";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(24, 216);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(266, 28);
            cmbStatus.TabIndex = 10;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = SystemColors.ActiveCaption;
            btnUpdateStatus.Location = new Point(24, 266);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(134, 47);
            btnUpdateStatus.TabIndex = 11;
            btnUpdateStatus.Text = "✎ Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 128);
            btnClear.Location = new Point(225, 266);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 47);
            btnClear.TabIndex = 12;
            btnClear.Text = "⌫ Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 91);
            panel1.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(48, 25);
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
            label8.Location = new Point(109, 39);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 0;
            label8.Text = "Order Management";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(3, 7);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(41, 29);
            btnBack.TabIndex = 15;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // rtbOrderItems
            // 
            rtbOrderItems.Location = new Point(670, 367);
            rtbOrderItems.Name = "rtbOrderItems";
            rtbOrderItems.Size = new Size(266, 395);
            rtbOrderItems.TabIndex = 16;
            rtbOrderItems.Text = "";
            // 
            // OrderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 774);
            Controls.Add(rtbOrderItems);
            Controls.Add(panel1);
            Controls.Add(btnClear);
            Controls.Add(btnUpdateStatus);
            Controls.Add(cmbStatus);
            Controls.Add(label7);
            Controls.Add(txtCustomer);
            Controls.Add(dgvOrders);
            Controls.Add(txtOrderID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "OrderManagement";
            Text = "OrderManagement";
            Load += OrderManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtOrderID;
        private DataGridView dgvOrders;
        private TextBox txtCustomer;
        private Label label7;
        private ComboBox cmbStatus;
        private Button btnUpdateStatus;
        private Button btnClear;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private Button btnBack;
        private RichTextBox rtbOrderItems;
    }
}