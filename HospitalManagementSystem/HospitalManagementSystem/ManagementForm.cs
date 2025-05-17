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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalManagementSystem
{
    public partial class ManagementForm : Form
    {

        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["HospitalDBConnectionString"].ConnectionString;

        public ManagementForm()
        {
            InitializeComponent();
        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDatabaseDataSet);
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.hospitalDatabaseDataSet.Appointments);
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this.hospitalDatabaseDataSet.Doctors);
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.hospitalDatabaseDataSet.Patients);

            //Set Default Language
            languageComboBox.SelectedIndex = 0;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (languageComboBox.SelectedIndex == 0)
            {
                logoutButton.Text = "Logout";
                patientsTabPage.Text = "Patients";
                doctorsTabPage.Text = "Doctors";
                appointmentsTabPage.Text = "Appointments";
                recordsTabPage.Text = "Records";
                filterAgeButton.Text = "Find patients older than...";
                patientAgeLabel.Text = "Age";
                findPatientBtn.Text = "Find Patient";
                patientIdLabelPatients.Text = "Patient ID";
                displayButton.Text = "Display all patients";
                findDoctorBtn.Text = "Find Doctor";
                doctorNameLabel.Text = "Doctor Name";
                doctorIdLabelDoctors.Text = "Doctor Id";
                findAvailableDocBtn.Text = "Find Available Doctor";
                displayAllDoctorssBtn.Text = "Display All Doctors";
                viewTodayBtn.Text = "Display today's Appointments";
                displayAppintmentsBtn.Text = "Display all Appointments";
                patientInfo.Text = "Patient's Information";
                //patientIdLabelRecords.Text = "Id du Patient";
                doctorInfo.Text = "Doctor's Information";
                transferPatientButton.Text = "Transfer Patient To doctor";
            }
            if (languageComboBox.SelectedIndex == 1)
            {
                logoutButton.Text = "Se deconnecter";
                patientsTabPage.Text = "Patients";
                doctorsTabPage.Text = "Docteurs";
                appointmentsTabPage.Text = "Rendez-Vous";
                recordsTabPage.Text = "Dossiers";
                filterAgeButton.Text = "Trouve les patients plus grand que...";
                patientAgeLabel.Text = "Age";
                findPatientBtn.Text = "Trouver le patient";
                patientIdLabelPatients.Text = "Id du Patient.";
                displayButton.Text = "Voir tous les patients";
                findDoctorBtn.Text = "Trouver un docteur";
                doctorNameLabel.Text = "Nom";
                doctorIdLabelDoctors.Text = "Id du docteur";
                findAvailableDocBtn.Text = "Trouver un Docteur disponible";
                displayAllDoctorssBtn.Text = "Voir  tous les docteurs";
                viewTodayBtn.Text = "Voir les rendez-vous pour aujourd'hui";
                displayAppintmentsBtn.Text = "Voir tous les rendez-vous";
                patientInfo.Text = "Informations du Patient";
                displayAppintmentsBtn.Text = "Id du Patient";
                //   patientFirstNameLabelRecords.Text = "Prenom";
                // patientLastNameLabelRecords.Text = "Nom du famille";
                doctorInfo.Text = "Information du Docteur";
                transferPatientButton.Text = "Transferer le Patient Au Docteur";
            }
        }

        private void filterAgeButton_Click(object sender, EventArgs e)
        {
            int age;
            if (int.TryParse(patientAgeTextBox.Text, out age))
            {
                GetPatientsOlderThan(age);
            }
            else
            {
                MessageBox.Show("Please enter a valid age.");
            }
        }

        public void GetPatientsOlderThan(int age)
        {
            string query = "SELECT * FROM Patients WHERE DATEDIFF(YEAR, DateOfBirth, GETDATE()) > @Age";
            DataTable dataTable = new DataTable(); // Create a new DataTable to hold the results

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Age", age);

                try
                {
                    connection.Open();  // Open the connection to the database
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);  // Load the results into a DataTable
                    patientsDataGridView.DataSource = dataTable;  // Bind to DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void filterByBloodButton_Click(object sender, EventArgs e)
        {
            string bloodType = bloodTypeComboBox.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(bloodType))
            {
                FilterPatientsByBloodType(bloodType);
            }
            else
            {
                MessageBox.Show("Please select a valid blood type.");
            }
        }

        public void FilterPatientsByBloodType(string bloodType)
        {
            string query = "SELECT * FROM Patients WHERE BloodType = @BloodType";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@BloodType", bloodType);

                try
                {
                    connection.Open();  // Open the connection to the database
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);  // Load the results into a DataTable
                    patientsDataGridView.DataSource = dataTable;  // Bind the DataTable to the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void findPatientBtn_Click(object sender, EventArgs e)
        {
            int patientId;
            if (int.TryParse(patientIdTextBoxPatients.Text, out patientId))
            {
                FindPatientById(patientId);
            }
            else
            {
                MessageBox.Show("Please enter a valid patient ID.");
            }
        }

        public void FindPatientById(int patientId)
        {
            string query = "SELECT * FROM Patients WHERE PatientID = @PatientID";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PatientID", patientId);

                try
                {
                    connection.Open();  // Open the connection to the database
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);  // Load the results into a DataTable
                    patientsDataGridView.DataSource = dataTable;  // Bind to DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            DisplayAllPatients();
        }

        public void DisplayAllPatients()
        {
            string query = "SELECT * FROM Patients";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                try
                {
                    connection.Open();  // Open the connection to the database
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);  // Load the data into the DataTable

                    // Bind the DataTable to the DataGridView to display the results
                    patientsDataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
