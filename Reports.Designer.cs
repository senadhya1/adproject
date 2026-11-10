namespace adproject
{
    partial class Reports
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
            menuStrip1 = new MenuStrip();
            salesToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            customerOrdersToolStripMenuItem = new ToolStripMenuItem();
            dtFrom = new DateTimePicker();
            dtTo = new DateTimePicker();
            btnGenerate = new Button();
            btnExportCSV = new Button();
            button3 = new Button();
            dgvReport = new DataGridView();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            btnBack = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 116);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Reports";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 203);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 481);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 2;
            label3.Text = "Report Preview Area";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 270);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 3;
            label4.Text = "To";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(383, 301);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Rockwell Nova Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { salesToolStripMenuItem, stockToolStripMenuItem, customerOrdersToolStripMenuItem });
            menuStrip1.Location = new Point(137, 116);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(255, 32);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "Sales";
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(57, 28);
            salesToolStripMenuItem.Text = "Sales";
            salesToolStripMenuItem.Click += salesToolStripMenuItem_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(58, 28);
            stockToolStripMenuItem.Text = "Stock";
            stockToolStripMenuItem.Click += stockToolStripMenuItem_Click;
            // 
            // customerOrdersToolStripMenuItem
            // 
            customerOrdersToolStripMenuItem.Name = "customerOrdersToolStripMenuItem";
            customerOrdersToolStripMenuItem.Size = new Size(127, 28);
            customerOrdersToolStripMenuItem.Text = "Customer Orders";
            customerOrdersToolStripMenuItem.Click += customerOrdersToolStripMenuItem_Click;
            // 
            // dtFrom
            // 
            dtFrom.Location = new Point(101, 201);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(374, 27);
            dtFrom.TabIndex = 6;
            // 
            // dtTo
            // 
            dtTo.Location = new Point(101, 267);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(374, 27);
            dtTo.TabIndex = 7;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.LightSteelBlue;
            btnGenerate.Location = new Point(28, 324);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(528, 55);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "\U0001f9fe Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnExportCSV
            // 
            btnExportCSV.BackColor = SystemColors.Info;
            btnExportCSV.Location = new Point(28, 390);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(528, 58);
            btnExportCSV.TabIndex = 9;
            btnExportCSV.Text = "📤 Export CSV";
            btnExportCSV.UseVisualStyleBackColor = false;
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // button3
            // 
            button3.Location = new Point(583, 390);
            button3.Name = "button3";
            button3.Size = new Size(121, 29);
            button3.TabIndex = 10;
            button3.Text = "EXPORT PDF";
            button3.UseVisualStyleBackColor = true;
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(28, 523);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(543, 239);
            dgvReport.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 95);
            panel1.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(12, 23);
            label9.Name = "label9";
            label9.Size = new Size(55, 38);
            label9.TabIndex = 1;
            label9.Text = "📊";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.ForestGreen;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(73, 37);
            label8.Name = "label8";
            label8.Size = new Size(136, 20);
            label8.TabIndex = 0;
            label8.Text = "Reports & Analytics";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(735, 159);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 16;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 774);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Controls.Add(dgvReport);
            Controls.Add(button3);
            Controls.Add(btnExportCSV);
            Controls.Add(btnGenerate);
            Controls.Add(dtTo);
            Controls.Add(dtFrom);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Reports";
            Text = "Reports";
            Load += Reports_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem customerOrdersToolStripMenuItem;
        private DateTimePicker dtFrom;
        private DateTimePicker dtTo;
        private Button btnGenerate;
        private Button btnExportCSV;
        private Button button3;
        private DataGridView dgvReport;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private Button btnBack;
    }
}