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

namespace adproject
{
    public partial class ProductSearch : Form
    {
        string connectionString =
            "Server=localhost;Port=3306;Database=greenlife_db;Uid=root;Pwd=sql123456;";

        private int loggedCustomerId;



        public ProductSearch(int customerId)
        {
            InitializeComponent();
            loggedCustomerId = customerId;
        }

        private void ProductSearch_Load(object sender, EventArgs e)
        {

            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.RowTemplate.Height = 80;

            // CREATE COLUMNS MANUALLY
            dgvProducts.Columns.Clear();

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductID",
                Visible = false
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Discount",
                HeaderText = "Discount (%)"
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Name",
                HeaderText = "Name"
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

            dgvProducts.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "AddToCart",
                HeaderText = "",
                Text = "Add to Cart",
                UseColumnTextForButtonValue = true
            });
            

            LoadCategories();
            LoadProducts();

            lblAddReview.Visible = false;
            rtbNewReview.Visible = false;
            cmbRating.Visible = false;
            btnSubmitReview.Visible = false;
            lblRating.Visible = false;
            lblReviewCount.Visible = false;
            rtbReviews.Visible = false;

            // Initialize rating ComboBox
            cmbRating.Items.Clear();
            cmbRating.Items.AddRange(new string[] { "1", "2", "3", "4", "5" });
            cmbRating.SelectedIndex = 4;
        }


        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All");

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT DISTINCT Category FROM Products", con);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbCategory.Items.Add(dr["Category"].ToString());
                }
            }

            cmbCategory.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

               
                string query = @"
            SELECT 
                p.ProductID,
                p.Discount,
                p.Name,
                p.Price,
                p.StockQuantity
               
            FROM Products p
            WHERE p.Name LIKE @name
            AND (@category = 'All' OR p.Category = @category)
            AND p.Price BETWEEN @minPrice AND @maxPrice";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", "%" + txtName.Text + "%");
                cmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@minPrice",
                    string.IsNullOrEmpty(txtMinPrice.Text) ? 0 : Convert.ToDecimal(txtMinPrice.Text));
                cmd.Parameters.AddWithValue("@maxPrice",
                    string.IsNullOrEmpty(txtMaxPrice.Text) ? 999999 : Convert.ToDecimal(txtMaxPrice.Text));

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvProducts.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    
                    dgvProducts.Rows.Add(
                        row["ProductID"],
                        row["Discount"],
                        row["Name"],
                        row["Price"],
                        row["StockQuantity"],
                        
                        "Add to Cart"
                    );
                }
            }
        }
        private void LoadImage(string path)
        {
            try
            {
                if (!string.IsNullOrEmpty(path) && System.IO.File.Exists(path))
                {
                    pbProduct.Image = Image.FromFile(path);
                    pbProduct.SizeMode = PictureBoxSizeMode.Zoom; 
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

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 

            int productId = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value);

            
            string imgPath = "";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = @"SELECT IFNULL(ImagePath,'') 
                     FROM images 
                     WHERE ProductID=@pid AND IsPrimary=1";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@pid", productId);
                imgPath = cmd.ExecuteScalar()?.ToString() ?? "";
            }

            LoadImage(imgPath);

            //  review controls
            lblAddReview.Visible = true;
            rtbNewReview.Visible = true;
            cmbRating.Visible = true;
            btnSubmitReview.Visible = true;
            lblRating.Visible = true;
            lblReviewCount.Visible = true;
            rtbReviews.Visible = true;

            //  Load reviews under the picture
            LoadProductReviews(productId);

            
            if (e.ColumnIndex == dgvProducts.Columns["AddToCart"].Index)
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    // 1. Check if already in cart
                    string checkQuery = @"
                SELECT Quantity
                FROM cart_items
                WHERE CustomerID = @cust
                  AND ProductID = @prod
                  AND OrderID IS NULL";

                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@cust", loggedCustomerId);
                    checkCmd.Parameters.AddWithValue("@prod", productId);

                    object result = checkCmd.ExecuteScalar();

                    if (result != null)
                    {
                        // 2. Update quantity if exists
                        int currentQty = Convert.ToInt32(result);
                        int newQty = currentQty + 1;

                        string updateQuery = @"
                    UPDATE cart_items
                    SET Quantity = @qty
                    WHERE CustomerID = @cust
                      AND ProductID = @prod
                      AND OrderID IS NULL";

                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);
                        updateCmd.Parameters.AddWithValue("@qty", newQty);
                        updateCmd.Parameters.AddWithValue("@cust", loggedCustomerId);
                        updateCmd.Parameters.AddWithValue("@prod", productId);

                        updateCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // 3. Insert if not exists
                        string insertQuery = @"
                    INSERT INTO cart_items (CustomerID, ProductID, Quantity)
                    VALUES (@cust, @prod, 1)";

                        MySqlCommand insertCmd = new MySqlCommand(insertQuery, con);
                        insertCmd.Parameters.AddWithValue("@cust", loggedCustomerId);
                        insertCmd.Parameters.AddWithValue("@prod", productId);

                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product added to cart!");
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerDashboard dashboard = new CustomerDashboard(loggedCustomerId);
            dashboard.Show();   // open customer dashboard
            this.Close();
        }

        private void LoadProductReviews(int productId)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                // Avg rating + review count
                double avgRating = 0;
                int reviewCount = 0;
                string ratingQuery = @"SELECT IFNULL(AVG(Rating),0) AS AvgRating, COUNT(*) AS ReviewCount FROM reviews WHERE ProductID=@pid";
                using (MySqlCommand cmd = new MySqlCommand(ratingQuery, con))
                {
                    cmd.Parameters.AddWithValue("@pid", productId);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
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

                
                string reviewQuery = @"
                    SELECT r.Rating, r.Comment, r.ReviewDate, c.Name AS CustomerName
                    FROM reviews r
                    INNER JOIN customers c ON r.CustomerID=c.CustomerID
                    WHERE r.ProductID=@pid
                    ORDER BY r.ReviewDate DESC";

                using (MySqlCommand cmd = new MySqlCommand(reviewQuery, con))
                {
                    cmd.Parameters.AddWithValue("@pid", productId);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        rtbReviews.Clear();
                        while (dr.Read())
                        {
                            int rating = Convert.ToInt32(dr["Rating"]);
                            string stars = new string('⭐', rating);
                            string customerName = dr["CustomerName"].ToString();
                            string comment = dr["Comment"].ToString();
                            string date = Convert.ToDateTime(dr["ReviewDate"]).ToString("yyyy-MM-dd");

                            rtbReviews.AppendText($"{stars}  by {customerName} on {date}\n{comment}\n------------------------\n");
                        }
                    }
                }
            }
        }

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) { MessageBox.Show("Select a product first."); return; }

            int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);
            if (!int.TryParse(cmbRating.SelectedItem?.ToString(), out int rating)) { MessageBox.Show("Select rating 1-5."); return; }

            string comment = rtbNewReview.Text.Trim();
            if (string.IsNullOrEmpty(comment)) { MessageBox.Show("Enter review comment."); return; }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = @"INSERT INTO reviews(ProductID,CustomerID,Rating,Comment,ReviewDate)
                                 VALUES(@pid,@cid,@rating,@comment,NOW())";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@pid", productId);
                cmd.Parameters.AddWithValue("@cid", loggedCustomerId);
                cmd.Parameters.AddWithValue("@rating", rating);
                cmd.Parameters.AddWithValue("@comment", comment);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Review submitted successfully!");
            rtbNewReview.Clear();
            cmbRating.SelectedIndex = 4;
            LoadProductReviews(productId);
        }

        
    }

}
