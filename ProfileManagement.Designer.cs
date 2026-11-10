namespace adproject
{
    partial class ProfileManagement
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
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnUpdateProfile = new Button();
            txtAddress = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            btnBack = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 39);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "My Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 181);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "\U0001f9d1‍💼 Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 271);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "📞 Contact";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 231);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 3;
            label4.Text = "📧 Email";
            // 
            // txtName
            // 
            txtName.Location = new Point(161, 168);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(676, 54);
            txtName.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(161, 271);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(161, 231);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(676, 27);
            txtEmail.TabIndex = 6;
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.BackColor = SystemColors.ActiveCaption;
            btnUpdateProfile.Location = new Point(77, 498);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(799, 45);
            btnUpdateProfile.TabIndex = 7;
            btnUpdateProfile.Text = "UPDATE PROFILE";
            btnUpdateProfile.UseVisualStyleBackColor = false;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(161, 315);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(676, 113);
            txtAddress.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 315);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 9;
            label5.Text = "✅ Address";
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(-2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 106);
            panel1.TabIndex = 14;
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
            label9.Text = "👤";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Info;
            label6.Location = new Point(31, 18);
            label6.Name = "label6";
            label6.Size = new Size(538, 20);
            label6.TabIndex = 15;
            label6.Text = "Note: All fields are required. Make sure to fill in all information before updating.";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(46, 583);
            panel2.Name = "panel2";
            panel2.Size = new Size(905, 54);
            panel2.TabIndex = 16;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(888, 124);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 18;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ProfileManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 774);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(btnUpdateProfile);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Name = "ProfileManagement";
            Text = "ProfileManagement";
            Load += ProfileManagement_Load;
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
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Button btnUpdateProfile;
        private TextBox txtAddress;
        private Label label5;
        private Panel panel1;
        private Label label9;
        private Label label6;
        private Panel panel2;
        private Button btnBack;
    }
}