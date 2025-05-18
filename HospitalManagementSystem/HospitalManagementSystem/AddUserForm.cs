using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private bool ValidateInput() 
        {
            string username = newUsernameTextBox.Text.Trim();
            string password = newPasswordTextBox.Text.Trim();
            string confirmPassword = confirmNewPasswordTextBox.Text.Trim();
            var adapter = new HospitalDatabaseDataSetTableAdapters.LoginTableAdapter();
            var result = adapter.GetDataByUsername(username);
            
            //if fields are empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //we use nvarchar(50), so make sure to respect it:
            if (username.Length > 50 || password.Length > 50)
            {
                MessageBox.Show("An input cannot be longer than 50 characters.", "Input Too Long", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //check if user already exists
            if (result.Rows.Count > 0)
            {
                MessageBox.Show("This user already exists.", "Trying to add user...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //for failed password confirmation
            if (password != confirmPassword)
            {
                MessageBox.Show("Please confirm your password correctly.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //Everything is fine
            return true;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            //input validation failed (the message is shown earlier)
            if (!ValidateInput())
                return;


            string username = newUsernameTextBox.Text.Trim();
            string password = newPasswordTextBox.Text.Trim();

            try
            {
                var adapter = new HospitalDatabaseDataSetTableAdapters.LoginTableAdapter();
                adapter.Insert(password, username);
                MessageBox.Show("New user added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show("Database error while adding user: " + error.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
