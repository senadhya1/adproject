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
    public partial class ProductManagement : Form


    {

        string connectionString =
             "Server=localhost;Port=3306;Database=greenlife_db;Uid=root;Pwd=sql123456;";

        int selectedProductId = 0;
        int lowStockThreshold = 5;

        string imagePath = "";

        public ProductManagement()
        {
            InitializeComponent();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            LoadProducts();
            CheckLowStock();
        }
        private void LoadProducts()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                DataTable dtProducts = new DataTable();
                DataTable dtImages = new DataTable();

                new MySqlDataAdapter(
                    "SELECT ProductID, Name, Category, Price, StockQuantity, Supplier, Discount FROM Products",
                    con).Fill(dtProducts);

                new MySqlDataAdapter(
                    "SELECT ProductID, ImagePath, IsPrimary FROM Images",
                    con).Fill(dtImages);

                // Create table for DataGridView
                DataTable dtFinal = new DataTable();
                dtFinal.Columns.Add("ID", typeof(int));
                dtFinal.Columns.Add("Name");
                dtFinal.Columns.Add("Category");
                dtFinal.Columns.Add("Price");
                dtFinal.Columns.Add("StockQuantity");
                dtFinal.Columns.Add("Supplier");
                dtFinal.Columns.Add("Discount");
                dtFinal.Columns.Add("Image", typeof(Image)); 

                foreach (DataRow p in dtProducts.Rows)
                {
                    DataRow row = dtFinal.NewRow();

                    row["ID"] = p["ProductID"];
                    row["Name"] = p["Name"];
                    row["Category"] = p["Category"];
                    row["Price"] = p["Price"];
                    row["StockQuantity"] = p["StockQuantity"];
                    row["Supplier"] = p["Supplier"];
                    row["Discount"] = p["Discount"];

                    
                    var imgRow = dtImages.AsEnumerable()
                        .FirstOrDefault(i =>
                            i.Field<int>("ProductID") == Convert.ToInt32(p["ProductID"]) &&
                            i.Field<bool>("IsPrimary"));

                    if (imgRow != null && System.IO.File.Exists(imgRow["ImagePath"].ToString()))
                    {
                        row["Image"] = Image.FromFile(imgRow["ImagePath"].ToString());
                    }
                    else
                    {
                        row["Image"] = null;
                    }

                    dtFinal.Rows.Add(row);
                }

                dgvProducts.DataSource = dtFinal;

              
                DataGridViewImageColumn imgCol =
                    (DataGridViewImageColumn)dgvProducts.Columns["Image"];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

                dgvProducts.RowTemplate.Height = 80;
            }
        }


        //  LOW STOCK ALERT 
        private void CheckLowStock()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT Name, StockQuantity FROM Products WHERE StockQuantity <= @threshold";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@threshold", lowStockThreshold);

                MySqlDataReader reader = cmd.ExecuteReader();

                string alert = "";
                while (reader.Read())
                {
                    alert += reader["Name"].ToString() + " - StockQuantity: " + reader["StockQuantity"].ToString() + "\n";
                }

                if (alert == "")
                    lblLowStock.Text = "No low stock items.";
                else
                    lblLowStock.Text = "Low Stock Alert:\n" + alert;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string productSql = @"INSERT INTO Products
                (Name, Category, Price, StockQuantity, Supplier, Discount)
                VALUES (@n,@c,@p,@s,@sup,@d);
                SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(productSql, con);
                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@c", txtCategory.Text);
                cmd.Parameters.AddWithValue("@p", txtPrice.Text);
                cmd.Parameters.AddWithValue("@s", txtStock.Text);
                cmd.Parameters.AddWithValue("@sup", txtSupplier.Text);
                cmd.Parameters.AddWithValue("@d", txtDiscount.Text);

                int productId = Convert.ToInt32(cmd.ExecuteScalar());

                if (!string.IsNullOrEmpty(imagePath))
                {
                    string imgSql = @"INSERT INTO Images (ProductID, ImagePath, IsPrimary)
                                      VALUES (@pid,@img,1)";
                    MySqlCommand imgCmd = new MySqlCommand(imgSql, con);
                    imgCmd.Parameters.AddWithValue("@pid", productId);
                    imgCmd.Parameters.AddWithValue("@img", imagePath);
                    imgCmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Product added successfully");
            ClearFields();
            CheckLowStock();

            LoadProducts();
        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedProductId == 0) return;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string productSql = @"UPDATE Products SET
                Name=@n, Category=@c, Price=@p,
                StockQuantity=@s, Supplier=@sup, Discount=@d
                WHERE ProductID=@id";

                MySqlCommand cmd = new MySqlCommand(productSql, con);
                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@c", txtCategory.Text);
                cmd.Parameters.AddWithValue("@p", txtPrice.Text);
                cmd.Parameters.AddWithValue("@s", txtStock.Text);
                cmd.Parameters.AddWithValue("@sup", txtSupplier.Text);
                cmd.Parameters.AddWithValue("@d", txtDiscount.Text);
                cmd.Parameters.AddWithValue("@id", selectedProductId);
                cmd.ExecuteNonQuery();

                if (!string.IsNullOrEmpty(imagePath))
                {
                    string imgSql = @"UPDATE Images 
                                      SET ImagePath=@img 
                                      WHERE ProductID=@id AND IsPrimary=1";

                    MySqlCommand imgCmd = new MySqlCommand(imgSql, con);
                    imgCmd.Parameters.AddWithValue("@img", imagePath);
                    imgCmd.Parameters.AddWithValue("@id", selectedProductId);
                    imgCmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Product updated successfully");
            ClearFields();
            CheckLowStock();
            LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0) return;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                MySqlCommand imgCmd =
                    new MySqlCommand("DELETE FROM Images WHERE ProductID=@id", con);
                imgCmd.Parameters.AddWithValue("@id", selectedProductId);
                imgCmd.ExecuteNonQuery();

                MySqlCommand prodCmd =
                    new MySqlCommand("DELETE FROM Products WHERE ProductID=@id", con);
                prodCmd.Parameters.AddWithValue("@id", selectedProductId);
                prodCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product deleted successfully");
            ClearFields();
            LoadProducts();
            CheckLowStock();


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtSupplier.Clear();
            txtDiscount.Clear();
            pbProduct.Image = null;
            imagePath = "";
            selectedProductId = 0;
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
            selectedProductId = Convert.ToInt32(row.Cells["ID"].Value);

            txtName.Text = row.Cells["Name"].Value.ToString();
            txtCategory.Text = row.Cells["Category"].Value.ToString();
            txtPrice.Text = row.Cells["Price"].Value.ToString();
            txtStock.Text = row.Cells["StockQuantity"].Value.ToString();
            txtSupplier.Text = row.Cells["Supplier"].Value.ToString();
            txtDiscount.Text = row.Cells["Discount"].Value.ToString();

            pbProduct.Image = row.Cells["Image"].Value as Image;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard();
            admin.Show();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pbProduct.Image = Image.FromFile(imagePath);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
