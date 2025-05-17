using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class LoginForm : Form
    {
        // Username → (Salt, PasswordHash)
        private readonly Dictionary<string, (string Salt, string Hash)> _users = new Dictionary<string, (string Salt, string Hash)>()
        {
            { "admin", ("s@lt123", HashPassword("admin123", "s@lt123")) },
            { "doctor", ("d0cs@lt", HashPassword("docpass", "d0cs@lt")) }
        };

        private const int MaxLoginAttempts = 3;
        private int _loginAttempts = 0;

        public LoginForm()
        {
            InitializeComponent();
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            if (_loginAttempts >= MaxLoginAttempts)
            {
                MessageBox.Show("Too many failed attempts.");
                Application.Exit();
                return;
            }

            if (_users.TryGetValue(username, out var userData))
            {
                string inputHash = HashPassword(password, userData.Salt);
                if (inputHash == userData.Hash)
                {
                    _loginAttempts = 0;
                    //MessageBox.Show("Login successful!");
                    this.Hide();
                    ManagementForm mainForm = new ManagementForm();
                    mainForm.ShowDialog();
                    this.Close();
                    return;
                }
            }

            _loginAttempts++;
            MessageBox.Show($"Invalid credentials. Attempts left: {MaxLoginAttempts - _loginAttempts}");
        }

        private static string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
                return Convert.ToBase64String(bytes);
            }
        }

        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                passwordTextBox.PasswordChar = '\0';
                showPasswordButton.Text = "Hide Password";
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
                showPasswordButton.Text = "Show Password";

            }
        }
    }
}
