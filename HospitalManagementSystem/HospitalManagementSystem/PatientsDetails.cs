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
    public partial class PatientsDetails : Form
    {
        private int Row;
        public PatientsDetails()
        {
            InitializeComponent();
        }
        public PatientsDetails(int row)
        {
            InitializeComponent();
            Row = row;
        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDatabaseDataSet);

        }

        private void PatientsDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.hospitalDatabaseDataSet.Patients);
            patientsBindingSource.Position = Row;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagementForm mainForm = new ManagementForm(true);
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
