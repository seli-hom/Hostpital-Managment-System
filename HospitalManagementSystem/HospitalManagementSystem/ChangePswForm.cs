using System;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ChangePswForm : Form
    {
        private string username;

        public ChangePswForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void updatePswButton_Click(object sender, EventArgs e)
        {
            string oldPassword = oldPswTextBox.Text.Trim();
            string newPassword = newPasswordTextBox.Text.Trim();
            string confirmPassword = confirmNewPasswordTextBox.Text.Trim();

            //Validate the input from user
            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Password fields cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Please match passwords.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //for NVArchar(50)
            if (newPassword.Length > 50)
            {
                MessageBox.Show("Password cannot exceed 50 characters!", "Too Big", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var adapter = new HospitalDatabaseDataSetTableAdapters.LoginTableAdapter(); //get adapter to call its methods
                var result = adapter.GetDataByUsernameAndPassword(username, oldPassword);

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Old password is incorrect.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                //everything is good:
                adapter.UpdatePassword(newPassword, username);
               
                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Close();
            }
            catch (Exception eroor)
            {
                MessageBox.Show("Error changing password: " + eroor.Message, "Database Problen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
