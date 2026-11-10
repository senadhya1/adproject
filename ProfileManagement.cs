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
    public partial class ProfileManagement : Form
    {

        string connectionString =
            "Server=localhost;Port=3306;Database=greenlife_db;Uid=root;Pwd=sql123456;";

        private int customerId;

        public ProfileManagement(int custId)
        {
            InitializeComponent();

            customerId = custId;
        }


        private void ProfileManagement_Load(object sender, EventArgs e)
        {
            LoadCustomerProfile();

        }

        private void LoadCustomerProfile()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                    SELECT Name, Email, Phone, Address
                    FROM customers
                    WHERE CustomerID = @cid";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cid", customerId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtName.Text = reader["Name"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                }

                reader.Close();
            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPhone.Text) ||
                string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                    UPDATE customers
                    SET Name = @name,
                        Email = @email,
                        Phone = @phone,
                        Address = @address
                    WHERE CustomerID = @cid";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@cid", customerId);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Profile updated successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to update profile.");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerDashboard dashboard = new CustomerDashboard(customerId);
            dashboard.Show();
            this.Hide();
        }
    }

}

