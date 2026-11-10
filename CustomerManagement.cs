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
    public partial class CustomerManagement : Form
    {
        public CustomerManagement()
        {
            InitializeComponent();
        }
        string connectionString =
            "Server=localhost;Port=3306;Database=greenlife_db;Uid=root;Pwd=sql123456;";

        int selectedCustomerId = 0;

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        private void LoadCustomers(string search = "")
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                c.CustomerID AS ID, 
                u.Name, 
                u.Email, 
                u.Phone, 
                c.Address
            FROM Customers c
            JOIN Users u ON c.UserID = u.UserID
            WHERE u.Name LIKE @search OR u.Email LIKE @search OR u.Phone LIKE @search";

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");



                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCustomers.DataSource = dt;
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

                selectedCustomerId = Convert.ToInt32(row.Cells["ID"].Value);
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCustomers(txtSearch.Text.Trim());
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == 0)
            {
                MessageBox.Show("Please select a customer first!");
                return;
            }

            OrderManagement orders = new OrderManagement();
            orders.Show();
            this.Hide();



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == 0)
            {
                MessageBox.Show("Please select a customer first!");
                return;
            }

            
            foreach (DataGridViewRow row in dgvCustomers.Rows)
            {
                if (Convert.ToInt32(row.Cells["ID"].Value) == selectedCustomerId)
                {
                    row.Cells["Name"].Value = txtName.Text;
                    row.Cells["Email"].Value = txtEmail.Text;
                    row.Cells["Phone"].Value = txtPhone.Text;
                    row.Cells["Address"].Value = txtAddress.Text;
                    break;
                }
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = @"UPDATE Customers SET 
                         Name=@name, Email=@email, Phone=@phone, Address=@address
                         WHERE CustomerID=@id";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@id", selectedCustomerId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Customer details updated successfully!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            selectedCustomerId = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard();
            admin.Show();     // open admin dashboard
            this.Hide();
        }
    }
}
