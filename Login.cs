using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace adproject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string connectionString = "Server=localhost;Port=3306;Database=greenlife_db;Uid=root;Pwd=sql123456;";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validation: required fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (password.Length < 8 || !Regex.IsMatch(password, @"[A-Z]") || !Regex.IsMatch(password, @"[a-z]"))
            {
                MessageBox.Show("Password must be at least 8 characters long and include both uppercase and lowercase letters.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    // Get Role + UserID
                    string query = @"
                        SELECT u.UserID, u.Role, c.CustomerID
                        FROM users u
                        LEFT JOIN customers c ON c.UserID = u.UserID
                        WHERE u.Username = @user AND u.PasswordHash = @pass";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password);

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string role = dr["Role"].ToString();

                                if (role.ToLower() == "admin")
                                {
                                    AdminDashboard admin = new AdminDashboard();
                                    admin.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    int loggedCustomerId = Convert.ToInt32(dr["CustomerID"]);
                                    CustomerDashboard customer = new CustomerDashboard(loggedCustomerId);
                                    customer.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
                        
                    
                
            
            
        
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }
    }
    }

        
    

            
         
