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
    public partial class Cart_Checkout : Form
    {

        string connectionString =
              "Server=localhost;Port=3306;Database=greenlife_db;Uid=root;Pwd=sql123456;";

        private int customerId;



        public Cart_Checkout(int custId)
        {
            InitializeComponent();
            customerId = custId;
        }

        private void Cart_Checkout_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadCart();
        }

        private void SetupGrid()
        {
            dgvCart.AutoGenerateColumns = false;
            dgvCart.Columns.Clear();

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "CartItemID",
                HeaderText = "CartItemID",
                Visible = false,
                DataPropertyName = "CartItemID"
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Product",
                HeaderText = "Product",
                DataPropertyName = "Product"
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Qty",
                HeaderText = "Qty",
                DataPropertyName = "Qty"
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "Price"
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Subtotal",
                HeaderText = "Subtotal",
                DataPropertyName = "Subtotal"
            });

            dgvCart.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "Update",
                Text = "Update",
                UseColumnTextForButtonValue = true
            });

            dgvCart.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "Remove",
                Text = "Remove",
                UseColumnTextForButtonValue = true
            });
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.MultiSelect = true; // if you want multiple items

        }
        private void LoadCart()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = @"
    SELECT 
        ci.CartItemID,
        p.ProductID,
        p.Name AS Product,
        ci.Quantity AS Qty,
        p.Price,
        (ci.Quantity * p.Price) AS Subtotal
    FROM cart_items ci
    JOIN products p ON ci.ProductID = p.ProductID
    WHERE ci.CustomerID = @customerId
      AND ci.OrderID IS NULL";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@customerId", customerId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCart.DataSource = dt;
            }

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }

            lblTotalAmount.Text = "Total Amount: Rs. " + total.ToString("0.00");

        }

        private void dgvCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // if (e.ColumnIndex == 1) // Qty column
            {
                //     int qty = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["Qty"].Value);
                //     decimal price = Convert.ToDecimal(dgvCart.Rows[e.RowIndex].Cells["Price"].Value);

                //     dgvCart.Rows[e.RowIndex].Cells["Subtotal"].Value = qty * price;
                //     UpdateTotal();
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            {
                if (dgvCart.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select at least one cart item to place an order.");
                    return;
                }

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    MySqlTransaction tran = con.BeginTransaction();

                    try
                    {
                        
                        List<int> selectedCartIds = new List<int>();
                        foreach (DataGridViewRow row in dgvCart.SelectedRows)
                        {
                            int cartItemId = Convert.ToInt32(row.Cells["CartItemID"].Value);
                            selectedCartIds.Add(cartItemId);
                        }

                        if (selectedCartIds.Count == 0)
                        {
                            MessageBox.Show("No valid items selected.");
                            return;
                        }

                        
                        string idList = string.Join(",", selectedCartIds); 
                        string totalQuery = $@"
                SELECT SUM(ci.Quantity * p.Price) AS Total
                FROM cart_items ci
                JOIN products p ON ci.ProductID = p.ProductID
                WHERE ci.CartItemID IN ({idList})";

                        MySqlCommand totalCmd = new MySqlCommand(totalQuery, con, tran);
                        object result = totalCmd.ExecuteScalar();
                        decimal totalAmount = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                        if (totalAmount == 0)
                        {
                            MessageBox.Show("Selected items total is zero!");
                            return;
                        }

                        string orderQuery = @"
                INSERT INTO orders (CustomerID, OrderDate, Status, TotalAmount)
                VALUES (@cid, NOW(), 'Pending', @total);
                SELECT LAST_INSERT_ID();";

                        MySqlCommand orderCmd = new MySqlCommand(orderQuery, con, tran);
                        orderCmd.Parameters.AddWithValue("@cid", customerId);
                        orderCmd.Parameters.AddWithValue("@total", totalAmount);

                        int orderId = Convert.ToInt32(orderCmd.ExecuteScalar());

                        
                        string cartUpdate = $@"
                UPDATE cart_items
                SET OrderID = @oid
                WHERE CartItemID IN ({idList})";

                        MySqlCommand cartCmd = new MySqlCommand(cartUpdate, con, tran);
                        cartCmd.Parameters.AddWithValue("@oid", orderId);
                        cartCmd.ExecuteNonQuery();

                        
                        string stockUpdate = $@"
                UPDATE products p
                JOIN cart_items ci ON p.ProductID = ci.ProductID
                SET p.StockQuantity = p.StockQuantity - ci.Quantity
                WHERE ci.CartItemID IN ({idList})";

                        MySqlCommand stockCmd = new MySqlCommand(stockUpdate, con, tran);
                        stockCmd.ExecuteNonQuery();

                        
                        tran.Commit();
                        MessageBox.Show("Selected items ordered successfully!");
                        LoadCart();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Order failed: " + ex.Message);
                    }
                }
            }
            }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            ProductSearch ps = new ProductSearch(customerId);
            ps.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerDashboard dashboard = new CustomerDashboard(customerId);
            dashboard.Show();   // open customer dashboard
            this.Close();
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int cartItemId = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["CartItemID"].Value);

            if (dgvCart.Columns[e.ColumnIndex].Name == "Update")
            {
                int newQty = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["Qty"].Value);
                if (newQty <= 0)
                {
                    MessageBox.Show("Quantity must be at least 1.");
                    return;
                }
                UpdateCartItem(cartItemId, newQty);
            }

            if (dgvCart.Columns[e.ColumnIndex].Name == "Remove")
            {
                RemoveCartItem(cartItemId);
            }
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }
            private void UpdateCartItem(int cartItemId, int qty)
        {
            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string updateQuery = @"
            UPDATE cart_items
            SET Quantity = @qty
            WHERE CartItemID = @id";

                MySqlCommand cmd = new MySqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@id", cartItemId);

                cmd.ExecuteNonQuery();
            }

            LoadCart();
        }

        private void RemoveCartItem(int cartItemId)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string deleteQuery = @"
            DELETE FROM cart_items
            WHERE CartItemID = @id";

                MySqlCommand cmd = new MySqlCommand(deleteQuery, con);
                cmd.Parameters.AddWithValue("@id", cartItemId);

                cmd.ExecuteNonQuery();
            }

            LoadCart();
        }
    }
    
}