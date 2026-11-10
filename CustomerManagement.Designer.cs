namespace adproject
{
    partial class CustomerManagement
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvCustomers = new DataGridView();
            btnViewOrders = new Button();
            btnUpdate = new Button();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btnClear = new Button();
            panel1 = new Panel();
            label9 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.ForestGreen;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(77, 39);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 1;
            label2.Text = "Search Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 246);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = "Customer List";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 140);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(650, 48);
            txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(679, 140);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(53, 48);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "🔍";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(359, 282);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(648, 365);
            dgvCustomers.TabIndex = 5;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // btnViewOrders
            // 
            btnViewOrders.BackColor = SystemColors.ActiveBorder;
            btnViewOrders.Location = new Point(855, 98);
            btnViewOrders.Name = "btnViewOrders";
            btnViewOrders.Size = new Size(152, 46);
            btnViewOrders.TabIndex = 6;
            btnViewOrders.Text = "📦VIEW ORDERS";
            btnViewOrders.UseVisualStyleBackColor = false;
            btnViewOrders.Click += btnViewOrders_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Location = new Point(12, 638);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(157, 39);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "✎UPDATE DETAILS";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(20, 246);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(298, 43);
            txtName.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(18, 332);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 43);
            txtEmail.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(20, 407);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(298, 43);
            txtPhone.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(18, 514);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 100);
            txtAddress.TabIndex = 11;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 128);
            btnClear.Location = new Point(188, 638);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(76, 39);
            btnClear.TabIndex = 12;
            btnClear.Text = "⌫ Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 91);
            panel1.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(16, 25);
            label9.Name = "label9";
            label9.Size = new Size(55, 38);
            label9.TabIndex = 1;
            label9.Text = "👥";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 679);
            label4.Name = "label4";
            label4.Size = new Size(334, 20);
            label4.TabIndex = 14;
            label4.Text = "Click on a row to select and edit customer details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 211);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 15;
            label5.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 309);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 16;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 384);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 17;
            label7.Text = "Contact";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 475);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 18;
            label8.Text = "Address";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(18, 714);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 774);
            Controls.Add(btnBack);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnClear);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(btnUpdate);
            Controls.Add(btnViewOrders);
            Controls.Add(dgvCustomers);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "CustomerManagement";
            Text = "CustomerManagement";
            Load += CustomerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvCustomers;
        private Button btnViewOrders;
        private Button btnUpdate;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Button btnClear;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnBack;
    }
}