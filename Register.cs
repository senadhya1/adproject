using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adproject
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private string connectionString = "Server=localhost;Port=3306;Database=greenlife_db;Uid=root;Pwd=sql123456;";
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();

            // Check required fields
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Password does not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password strength validation
            if (password.Length < 8 ||
                !Regex.IsMatch(password, @"[A-Z]") ||
                !Regex.IsMatch(password, @"[a-z]"))
            {
                MessageBox.Show("Password must be at least 8 characters long and include both uppercase and lowercase letters.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Email format validation
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Phone number validation (exactly 10 digits)
            if (!Regex.IsMatch(phone, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    // Insert into Users table
                    string queryUsers = "INSERT INTO Users (Username, PasswordHash, Role, Name, Email, Phone) " +
                                        "VALUES (@username, @password, 'Customer', @name, @email, @phone)";

                    MySqlCommand cmdUsers = new MySqlCommand(queryUsers, con);
                    cmdUsers.Parameters.AddWithValue("@username", username);
                    cmdUsers.Parameters.AddWithValue("@password", password); 
                    cmdUsers.Parameters.AddWithValue("@name", fullName);
                    cmdUsers.Parameters.AddWithValue("@email", email);
                    cmdUsers.Parameters.AddWithValue("@phone", phone);
                    cmdUsers.ExecuteNonQuery();

                    int userId = (int)cmdUsers.LastInsertedId;

                    // Insert into Customers table
                    string queryCustomers = "INSERT INTO Customers (UserID, Address) VALUES (@userId, @address)";
                    MySqlCommand cmdCustomers = new MySqlCommand(queryCustomers, con);
                    cmdCustomers.Parameters.AddWithValue("@userId", userId);
                    cmdCustomers.Parameters.AddWithValue("@address", address);
                    cmdCustomers.ExecuteNonQuery();

                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Go back to Login form
                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
