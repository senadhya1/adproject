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
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;

namespace adproject
{
    public partial class CustomerDashboard : Form
    {
        string connectionString =
            "Server=localhost;Port=3306;Database=greenlife_db;Uid=root;Pwd=sql123456;";

        private int loggedCustomerId;

        public CustomerDashboard(int customerId)
        {
            InitializeComponent();

            loggedCustomerId = customerId;
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            SetupProductGrid();
            LoadProducts();
            cmbRating.Items.Clear();
            cmbRating.Items.AddRange(new string[] { "1", "2", "3", "4", "5" });
            cmbRating.SelectedIndex = 4; // default 5 stars

            pbProduct.Visible = false;
            lblRating.Visible = false;
            lblReviewCount.Visible = false;
            rtbReviews.Visible = false;
            lblAddReview.Visible = false;   // Label "Write a review:"
            rtbNewReview.Visible = false;   // RichTextBox for comment
            cmbRating.Visible = false;      // ComboBox for rating
            btnSubmitReview.Visible = false;
        }
        private void LoadProductReviews(int productId)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                // ----- Average Rating + Count -----
                double avgRating = 0;
                int reviewCount = 0;

                string ratingQuery = @"
            SELECT 
                IFNULL(AVG(Rating),0) AS AvgRating,
                COUNT(*) AS ReviewCount
            FROM reviews
            WHERE ProductID = @pid";

                using (MySqlCommand ratingCmd = new MySqlCommand(ratingQuery, con))
                {
                    ratingCmd.Parameters.AddWithValue("@pid", productId);
                    using (MySqlDataReader dr = ratingCmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            avgRating = Convert.ToDouble(dr["AvgRating"]);
                            reviewCount = Convert.ToInt32(dr["ReviewCount"]);
                        }
                    }
                }

                lblRating.Text = "⭐ Rating: " + Math.Round(avgRating, 1) + " / 5";
                lblReviewCount.Text = "📝 " + reviewCount + " Reviews";

                // ----- Fetch Review Comments with Customer Name -----
                string reviewQuery = @"
            SELECT r.Rating, r.Comment, r.ReviewDate, c.Name AS CustomerName
            FROM reviews r
            INNER JOIN customers c ON r.CustomerID = c.CustomerID
            WHERE r.ProductID = @pid
            ORDER BY r.ReviewDate DESC";

                using (MySqlCommand reviewCmd = new MySqlCommand(reviewQuery, con))
                {
                    reviewCmd.Parameters.AddWithValue("@pid", productId);
                    using (MySqlDataReader reviewDr = reviewCmd.ExecuteReader())
                    {
                        rtbReviews.Clear();

                        while (reviewDr.Read())
                        {
                            int rating = Convert.ToInt32(reviewDr["Rating"]);
                            string stars = new string('⭐', rating);
                            string customerName = reviewDr["CustomerName"].ToString();
                            string comment = reviewDr["Comment"].ToString();
                            string date = Convert.ToDateTime(reviewDr["ReviewDate"]).ToString("yyyy-MM-dd");

                            rtbReviews.AppendText(
                                $"{stars}  by {customerName} on {date}" + Environment.NewLine +
                                comment + Environment.NewLine +
                                "------------------------" + Environment.NewLine
                            );
                        }
                    }
                }
            }
        }

        private void LoadProducts()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                    SELECT 
                        p.ProductID,
                        p.Name,
                        p.Price,
                        p.StockQuantity,
                        IFNULL(i.ImagePath,'') AS ImagePath
                    FROM products p
                    LEFT JOIN images i 
                        ON p.ProductID = i.ProductID AND i.IsPrimary = 1
                    WHERE p.StockQuantity > 0";

                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();

                dgvProducts.Rows.Clear();

                while (dr.Read())
                {
                    dgvProducts.Rows.Add(
                        dr["ProductID"],
                        dr["Name"],
                        dr["Price"],
                        dr["StockQuantity"],
                        dr["ImagePath"]
                    );
                }
            }
        }

        private void SetupProductGrid()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();
            dgvProducts.RowTemplate.Height = 60;

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductID",
                Visible = false
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Name",
                HeaderText = "Product"
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Price",
                HeaderText = "Price"
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Stock",
                HeaderText = "Stock"
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ImagePath",
                Visible = false   // 🔹 from images table
            });

            dgvProducts.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "AddToCart",
                Text = "Add to Cart",
                UseColumnTextForButtonValue = true
            });
        }



        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
            ProductSearch ps = new ProductSearch(loggedCustomerId);
            ps.Show();
            this.Hide();
        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            Cart_Checkout cart = new Cart_Checkout(loggedCustomerId);
            cart.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileManagement profile = new ProfileManagement(loggedCustomerId);
            profile.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnOrderTracking_Click(object sender, EventArgs e)
        {
            OrderTracking ot = new OrderTracking(loggedCustomerId);
            ot.Show();
            this.Hide();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int productId = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value);
            string imgPath = dgvProducts.Rows[e.RowIndex].Cells["ImagePath"].Value.ToString();

            LoadImage(imgPath);
            LoadProductReviews(productId);
            pbProduct.Visible = true;
            lblAddReview.Visible = true;
            rtbNewReview.Visible = true;
            cmbRating.Visible = true;
            btnSubmitReview.Visible = true;
            lblRating.Visible = true;
            lblReviewCount.Visible = true;
            rtbReviews.Visible = true;

            if (e.ColumnIndex == dgvProducts.Columns["AddToCart"].Index)
            {
                AddToCart(productId);
            }

        }
        private void LoadImage(string path)
        {
            try
            {
                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    pbProduct.Image = Image.FromFile(path);
                }
                else
                {
                    pbProduct.Image = null;
                }
            }
            catch
            {
                pbProduct.Image = null;
            }
        }
        private void AddToCart(int productId)
        {
            // Ask quantity using InputBox
            string input = Interaction.InputBox("Enter quantity:", "Quantity", "1");

            if (!int.TryParse(input, out int qtyToAdd) || qtyToAdd <= 0)
            {
                MessageBox.Show("Invalid quantity. Please enter a valid number.");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                // Only check cart items that are NOT yet ordered
                string checkQuery = @"
            SELECT Quantity
            FROM cart_items
            WHERE CustomerID = @cid 
              AND ProductID = @pid
              AND OrderID IS NULL";

                MySqlCommand checkCmd = new MySqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@cid", loggedCustomerId);
                checkCmd.Parameters.AddWithValue("@pid", productId);

                object result = checkCmd.ExecuteScalar();

                if (result != null)
                {
                    // Update quantity
                    int currentQty = Convert.ToInt32(result);
                    int newQty = currentQty + qtyToAdd;

                    string updateQuery = @"
                UPDATE cart_items
                SET Quantity = @qty
                WHERE CustomerID = @cid 
                  AND ProductID = @pid
                  AND OrderID IS NULL";

                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);
                    updateCmd.Parameters.AddWithValue("@qty", newQty);
                    updateCmd.Parameters.AddWithValue("@cid", loggedCustomerId);
                    updateCmd.Parameters.AddWithValue("@pid", productId);

                    updateCmd.ExecuteNonQuery();
                }
                else
                {
                    // Insert new row (with OrderID = NULL)
                    string insertQuery = @"
                INSERT INTO cart_items (CustomerID, ProductID, Quantity, OrderID)
                VALUES (@cid, @pid, @qty, NULL)";

                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, con);
                    insertCmd.Parameters.AddWithValue("@cid", loggedCustomerId);
                    insertCmd.Parameters.AddWithValue("@pid", productId);
                    insertCmd.Parameters.AddWithValue("@qty", qtyToAdd);

                    insertCmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Product added to cart!");
        }





        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmitReview_Click_1(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);

            if (!int.TryParse(cmbRating.SelectedItem?.ToString(), out int rating))
            {
                MessageBox.Show("Please select a valid rating (1-5).");
                return;
            }

            string comment = rtbNewReview.Text.Trim();
            if (string.IsNullOrEmpty(comment))
            {
                MessageBox.Show("Please enter a review comment.");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                    INSERT INTO reviews(ProductID, CustomerID, Rating, Comment, ReviewDate)
                    VALUES(@pid, @cid, @rating, @comment, NOW())";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pid", productId);
                    cmd.Parameters.AddWithValue("@cid", loggedCustomerId);
                    cmd.Parameters.AddWithValue("@rating", rating);
                    cmd.Parameters.AddWithValue("@comment", comment);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Review submitted successfully!");

            rtbNewReview.Clear();
            cmbRating.SelectedIndex = 4; // default 5 stars

            LoadProductReviews(productId);
        }
    }

}
