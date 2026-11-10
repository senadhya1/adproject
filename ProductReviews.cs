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
    public partial class ProductReviews : Form

    {

        private string connectionString =
              "Server=localhost;Port=3306;Database=greenlife_db;Uid=root;Pwd=sql123456;";


        public ProductReviews()
        {
            InitializeComponent();
        }

        private void ProductReviews_Load(object sender, EventArgs e)
        {
            SetupProductGrid();
            LoadProducts();
        }
        private void SetupProductGrid()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.RowTemplate.Height = 60;
            dgvProducts.Columns.Clear();

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ProductID", HeaderText = "product ID" });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Name", HeaderText = "Name" });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Price", HeaderText = "Price" });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Stock", HeaderText = "Stock" });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn() { Name = "AvgRating", HeaderText = "Avg Rating" });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ReviewCount", HeaderText = "Reviews" });
        }

        
        private void LoadProducts()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = @"
                    SELECT p.ProductID, p.Name, p.Price, p.StockQuantity,
                           IFNULL(AVG(r.Rating),0) AS AvgRating,
                           COUNT(r.ReviewID) AS ReviewCount
                    FROM products p
                    LEFT JOIN reviews r ON p.ProductID = r.ProductID
                    WHERE p.Name LIKE @name
                    GROUP BY p.ProductID, p.Name, p.Price, p.StockQuantity";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", "%" + txtSearchName.Text + "%");

                MySqlDataReader dr = cmd.ExecuteReader();
                dgvProducts.Rows.Clear();

                while (dr.Read())
                {
                    dgvProducts.Rows.Add(
                        dr["ProductID"],
                        dr["Name"],
                        dr["Price"],
                        dr["StockQuantity"],
                        Math.Round(Convert.ToDouble(dr["AvgRating"]), 1),
                        dr["ReviewCount"]
                    );
                }
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int productId = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value);
            LoadProductReviews(productId);
        }

        private void LoadProductReviews(int productId)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                // Product info
                string productQuery = @"SELECT Name, Price, StockQuantity, IFNULL(i.ImagePath,'') AS ImagePath
                                        FROM products p
                                        LEFT JOIN images i ON p.ProductID=i.ProductID AND i.IsPrimary=1
                                        WHERE p.ProductID=@pid";
                using (MySqlCommand cmd = new MySqlCommand(productQuery, con))
                {
                    cmd.Parameters.AddWithValue("@pid", productId);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            lblProductName.Text = dr["Name"].ToString();
                            lblPrice.Text = "Price: " + dr["Price"].ToString();
                            lblStock.Text = "Stock: " + dr["StockQuantity"].ToString();

                            string path = dr["ImagePath"].ToString();
                            pbProduct.Image = (!string.IsNullOrEmpty(path) && File.Exists(path)) ? Image.FromFile(path) : null;
                        }
                    }
                }

                // Reviews
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
                            string name = dr["CustomerName"].ToString();
                            string comment = dr["Comment"].ToString();
                            string date = Convert.ToDateTime(dr["ReviewDate"]).ToString("yyyy-MM-dd");

                            rtbReviews.AppendText($"{stars} by {name} on {date}\n{comment}\n------------------------\n");
                        }
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard();
            admin.Show();     // open admin dashboard
            this.Hide();
        }
    }
}
