using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class LoginForm : Form
    {
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
                bool isAdmin = username.Equals("admin");// the user is an admin, they will be able to add users
                loginAttempts = 0;
                this.Hide();
                ManagementForm mainForm = new ManagementForm(isAdmin);
                mainForm.ShowDialog();
                this.Close();
                return;
            }

            if (MaxLoginAttempts - loginAttempts > 1)
            {
                MessageBox.Show($"Invalid credentials. Attempts left: {MaxLoginAttempts - loginAttempts}");
            }
            else
            {
                MessageBox.Show("Invalid credentials. Last Attempt");

            }
            loginAttempts++;

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
