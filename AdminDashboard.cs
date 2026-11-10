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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        private string connectionString =
            "Server=localhost;Port=3306;Database=greenlife_db;Uid=root;Pwd=sql123456;";


        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }
        private void LoadDashboardData()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                // Total Sales
                MySqlCommand cmdSales = new MySqlCommand(
                    "SELECT IFNULL(SUM(TotalAmount),0) FROM Orders WHERE Status='Delivered'", con);
                lblTotalSales.Text = "Total Sales\nRs. " + cmdSales.ExecuteScalar().ToString();

                // Products in Stock
                MySqlCommand cmdProducts = new MySqlCommand(
                    "SELECT COUNT(*) FROM Products", con);
                lblProducts.Text = "Products in Stock\n" + cmdProducts.ExecuteScalar().ToString();

                // Active Orders
                MySqlCommand cmdOrders = new MySqlCommand(
                    "SELECT COUNT(*) FROM Orders WHERE Status='Pending'", con);
                lblOrders.Text = "Active Orders\n" + cmdOrders.ExecuteScalar().ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ProductManagement products = new ProductManagement();
            products.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            
            CustomerManagement customers = new CustomerManagement();
            customers.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrderManagement orders = new OrderManagement();
            orders.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void lblOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnOrders_MouseEnter(object sender, EventArgs e)
        {
        }

        private void viewProductReviews_Click(object sender, EventArgs e)
        {
            ProductReviews products = new ProductReviews();
            products.Show();
            this.Hide();
            
        }
    }
}
