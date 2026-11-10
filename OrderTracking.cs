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
    public partial class OrderTracking : Form
    {
        string connectionString =
            "Server=localhost;Port=3306;Database=greenlife_db;Uid=root;Pwd=sql123456;";

        private int customerId;

        public OrderTracking(int custId)
        {
            InitializeComponent();
            customerId = custId;
        }

        private void OrderTracking_Load(object sender, EventArgs e)
        {
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.Columns.Clear();

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "OrderID",
                HeaderText = "OrderID",
                DataPropertyName = "OrderID"
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "OrderDate",
                HeaderText = "Date",
                DataPropertyName = "OrderDate"
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "TotalAmount",
                HeaderText = "Total",
                DataPropertyName = "TotalAmount"
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status"
            });

            dgvOrders.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "ViewDetails",
                HeaderText = "",
                Text = "VIEW DETAILS",
                UseColumnTextForButtonValue = true
            });

            dgvOrders.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "CancelOrder",
                HeaderText = "",
                Text = "CANCEL ORDER",
                UseColumnTextForButtonValue = true
            });

            LoadOrders();
        }

        private void LoadOrders()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                    SELECT OrderID, OrderDate, TotalAmount, Status
                    FROM orders
                    WHERE CustomerID = @cid
                    ORDER BY OrderDate DESC";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cid", customerId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOrders.DataSource = dt;
            }
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int orderId = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value);

            // VIEW DETAILS
            if (e.ColumnIndex == dgvOrders.Columns["ViewDetails"].Index)
            {
                LoadOrderDetails(orderId);
            }

            // CANCEL ORDER
            if (e.ColumnIndex == dgvOrders.Columns["CancelOrder"].Index)
            {
                string status = dgvOrders.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                if (status == "Pending" || status == "Processing")
                {
                    CancelOrder(orderId);
                }
                else
                {
                    MessageBox.Show("Only Pending or Processing orders can be cancelled.");
                }
            }
        }



        private void CancelOrder(int orderId)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = "UPDATE orders SET Status = 'Cancelled' WHERE OrderID = @oid";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@oid", orderId);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Order Cancelled Successfully!");
                    LoadOrders(); // Refresh grid
                }
                else
                {
                    MessageBox.Show("Failed to cancel order.");
                }
            }
        }

        private void LoadOrderDetails(int orderId)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                    SELECT p.Name, ci.Quantity, p.Price, (ci.Quantity * p.Price) AS Subtotal,
                           i.ImagePath
                    FROM cart_items ci
                    JOIN products p ON ci.ProductID = p.ProductID
                    LEFT JOIN images i ON p.ProductID = i.ProductID AND i.IsPrimary = 1
                    WHERE ci.OrderID = @oid
                    LIMIT 1";   

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@oid", orderId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtProductName.Text = reader["Name"].ToString();
                    txtQty.Text = reader["Quantity"].ToString();
                    txtPrice.Text = reader["Price"].ToString();
                    txtSubtotal.Text = reader["Subtotal"].ToString();

                    string imgPath = reader["ImagePath"].ToString();
                    if (File.Exists(imgPath))
                    {
                        pbProduct.Image = Image.FromFile(imgPath);
                    }
                }

                reader.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerDashboard dashboard = new CustomerDashboard(customerId);
            dashboard.Show();
            this.Close();
        }
    }

}
