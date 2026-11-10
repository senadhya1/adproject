using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adproject
{
    public partial class Reports : Form
    {

        string connectionString =
            "Server=localhost;Port=3306;Database=greenlife_db;Uid=root;Pwd=sql123456;";

        string selectedReport = "";


        public Reports()
        {
            InitializeComponent();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedReport = "sales";
            MessageBox.Show("Sales Report selected");
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedReport = "stock";
            MessageBox.Show("Stock Report selected");
        }

        private void customerOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedReport = "customerOrders";
            MessageBox.Show("Customer Orders Report selected");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (selectedReport == "")
            {
                MessageBox.Show("Please select a report type!");
                return;
            }

            if (selectedReport == "sales")
                LoadSalesReport();
            else if (selectedReport == "stock")
                LoadStockReport();
            else if (selectedReport == "customerOrders")
                LoadCustomerOrdersReport();
        }

        private void LoadSalesReport()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                    SELECT 
                        OrderID,
                        CustomerID,
                        OrderDate,
                        TotalAmount,
                       Status
                    FROM Orders
                    WHERE OrderDate BETWEEN @from AND @to";

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@from", dtFrom.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@to", dtTo.Value.Date);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReport.DataSource = dt;
            }
        }

        private void LoadStockReport()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                    SELECT 
                        ProductID,
                        Name,
                        Category,
                        StockQuantity,
                        Price
                    FROM Products";

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReport.DataSource = dt;
            }
        }

        // ================= CUSTOMER ORDERS REPORT =================

        private void LoadCustomerOrdersReport()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                    SELECT 
                        o.OrderID,
                        o.OrderDate,
                        o.TotalAmount,
                        o.Status,
                        c.CustomerID
                    FROM Orders o
                    JOIN Customers c ON o.CustomerID = c.CustomerID
                    WHERE o.OrderDate BETWEEN @from AND @to";

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@from", dtFrom.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@to", dtTo.Value.Date);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReport.DataSource = dt;
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            // Check if DataGridView has data
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to export!");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            sfd.FileName = "report.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportToCSV(dgvReport, sfd.FileName);
                MessageBox.Show("CSV exported successfully!");
            }

        }

        private void ExportToCSV(DataGridView dgv, string filePath)
        {
            StringBuilder sb = new StringBuilder();

            // ===== Column Headers =====
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                sb.Append(dgv.Columns[i].HeaderText);
                if (i < dgv.Columns.Count - 1)
                    sb.Append(",");
            }
            sb.AppendLine();

            // ===== Rows =====
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    sb.Append(row.Cells[i].Value?.ToString());
                    if (i < dgv.Columns.Count - 1)
                        sb.Append(",");
                }
                sb.AppendLine();
            }

            File.WriteAllText(filePath, sb.ToString());
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard();
            admin.Show();    // Open Admin Dashboard
            this.Close();
        }
    }
}
    

    

