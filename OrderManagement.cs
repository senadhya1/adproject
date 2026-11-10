using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
        }

        string connectionString =
            "Server=localhost;Port=3306;Database=greenlife_db;Uid=root;Pwd=sql123456;";

        int selectedOrderId = 0;

        private void OrderManagement_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
        private void LoadOrders()
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
                    ORDER BY OrderDate DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOrders.DataSource = dt;
            }
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 

            DataGridViewRow row = dgvOrders.Rows[e.RowIndex];

            // Get selected order details
            selectedOrderId = Convert.ToInt32(row.Cells["OrderID"].Value);
            txtOrderID.Text = selectedOrderId.ToString();

            int customerId = Convert.ToInt32(row.Cells["CustomerID"].Value);
            txtCustomer.Text = GetCustomerName(customerId);

            cmbStatus.Text = row.Cells["Status"].Value.ToString();

            // Load order items into RichTextBox
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = @"
            SELECT 
                p.Name AS ProductName,
                ci.Quantity,
                p.Price,
                (ci.Quantity * p.Price) AS Subtotal
            FROM cart_items ci
            JOIN products p ON ci.ProductID = p.ProductID
            WHERE ci.OrderID = @orderId";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@orderId", selectedOrderId);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    rtbOrderItems.Clear();

                    if (!dr.HasRows)
                    {
                        rtbOrderItems.Text = "No products found for this order.";
                        return;
                    }

                    rtbOrderItems.AppendText("Products in this order:\n");
                    rtbOrderItems.AppendText("----------------------------------\n");

                    decimal total = 0;

                    while (dr.Read())
                    {
                        string productName = dr["ProductName"].ToString();
                        int quantity = Convert.ToInt32(dr["Quantity"]);
                        decimal price = Convert.ToDecimal(dr["Price"]);
                        decimal subtotal = Convert.ToDecimal(dr["Subtotal"]);

                        total += subtotal;

                        rtbOrderItems.AppendText(
                            $"{productName} | Qty: {quantity} | Price: Rs. {price:0.00} | Subtotal: Rs. {subtotal:0.00}\n"
                        );
                    }

                    rtbOrderItems.AppendText("----------------------------------\n");
                    rtbOrderItems.AppendText($"Total: Rs. {total:0.00}");
                }
            }

        }

        private string GetCustomerName(int customerId)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT Name FROM Users WHERE UserID = (SELECT UserID FROM Customers WHERE CustomerID = @custId)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@custId", customerId);

                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "Unknown";
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == 0)
            {
                MessageBox.Show("Please select an order first!");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = @"UPDATE Orders 
                                 SET Status=@status 
                                 WHERE OrderID=@id";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("@id", selectedOrderId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Order status updated successfully!");
            LoadOrders();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            selectedOrderId = 0;
            txtOrderID.Clear();
            txtCustomer.Clear();
            cmbStatus.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
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
