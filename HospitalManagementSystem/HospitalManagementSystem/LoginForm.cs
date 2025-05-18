using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class LoginForm : Form
    {
        // Simple username → password mapping
        private readonly Dictionary<string, string> users = new Dictionary<string, string>()
        {
            { "admin", "admin123" },
            { "doctor", "docpass" }
        };

        private const int MaxLoginAttempts = 3;
        private int loginAttempts = 0;

        public LoginForm()
        {
            InitializeComponent();
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            if (loginAttempts >= MaxLoginAttempts)
            {
                MessageBox.Show("Too many failed attempts.");
                Application.Exit();
                return;
            }

            var loginAdapter = new HospitalDatabaseDataSetTableAdapters.LoginTableAdapter();
            var result = loginAdapter.GetDataByUsernameAndPassword(username, password);
            if (result.Rows.Count > 0)
            {
                loginAttempts = 0;
                this.Hide();
                ManagementForm mainForm = new ManagementForm();
                mainForm.ShowDialog();
                this.Close();
                return;
            }

            loginAttempts++;
            if (MaxLoginAttempts > 0)
            {
                MessageBox.Show($"Invalid credentials. Attempts left: {MaxLoginAttempts - loginAttempts}");
            }
            else
            {
                MessageBox.Show("Invalid credentials. Last Attempt");

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
