using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

       

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (currentPswTextBox.Text.Equals(/*databasePassword*/))
            {
                if (newPswTextBox.Text.Equals(confirmPswTextBox.Text))
                {
                    //set database psw to new password
                }
                else
                {
                    MessageBox.Show("Password Confirmation Must MAtch the New Password!");
                }
            }
            else
            {
                MessageBox.Show("Permission denied. \n You must have the current password in order to change.")
            }
        }
    }
}
