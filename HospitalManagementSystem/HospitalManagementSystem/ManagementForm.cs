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
        private bool isAdminUser;
        private string currentUser;
        private int minutesElapsed = 0;
        private const int timeoutMinutes = 10;
        private bool warningShown = false;


        public ManagementForm(bool isAdmin, string currentUsername)
        {
            InitializeComponent();
            isAdminUser = isAdmin;
            currentUser = currentUsername;
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

            //for logout feature
            minutesElapsed = 0;
            warningShown = false;
            timoutTimer.Start();
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
            var changeLanguage = new ChangeLanguage();
            switch (languageComboBox.SelectedIndex) 
            {
                case 0: changeLanguage.UpdateLanguage("language", "en");
                    logoutButton.Text = "Logout";
                    patientsTabPage.Text = "Patients";
                    doctorsTabPage.Text = "Doctors";
                    appointmentsTabPage.Text = "Appointments";
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

                    //Application.Restart();
                    break;
                case 1: changeLanguage.UpdateLanguage("language", "fr-CA");
                    logoutButton.Text = "Se deconnecter";
                    patientsTabPage.Text = "Patients";
                    doctorsTabPage.Text = "Docteurs";
                    appointmentsTabPage.Text = "Rendez-Vous";

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
                    displayAppintmentsBtn.Text = "Id du Patient";
                    //   patientFirstNameLabelRecords.Text = "Prenom";
                    // patientLastNameLabelRecords.Text = "Nom du famille";
                    //Application.Restart();
                    break;
                case 2: changeLanguage.UpdateLanguage("language", "es");
                    logoutButton.Text = "Cerrar sesión";
                    patientsTabPage.Text = "Pacientes";
                    doctorsTabPage.Text = "Doctores";
                    appointmentsTabPage.Text = "Citas";
                    filterAgeButton.Text = "Encontrar pacientes mayores que...";
                    patientAgeLabel.Text = "Edad";
                    findPatientBtn.Text = "Buscar paciente";
                    patientIdLabelPatients.Text = "ID del paciente.";
                    displayButton.Text = "Ver todos los pacientes";
                    findDoctorBtn.Text = "Buscar un doctor";
                    doctorNameLabel.Text = "Nombre";
                    doctorIdLabelDoctors.Text = "ID del doctor";
                    findAvailableDocBtn.Text = "Buscar doctor disponible";
                    displayAllDoctorssBtn.Text = "Ver todos los doctores";
                    viewTodayBtn.Text = "Ver las citas de hoy";
                    displayAppintmentsBtn.Text = "Ver todas las citas";
                    displayAppintmentsBtn.Text = "ID del paciente";
                    // patientFirstNameLabelRecords.Text = "Nombre";
                    // patientLastNameLabelRecords.Text = "Apellido";

                    //Application.Restart();
                    break;
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

        private void findDoctorBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(doctorIdTextBoxDoctors.Text))
            {
                if (int.TryParse(doctorIdTextBoxDoctors.Text, out int id))
                    findDoctorById(id);
                else
                    MessageBox.Show("Invalid Doctor ID.");
            }
            else
            {
                findDoctorByName(doctorNameTextBox.Text.Trim()); //remove leading and trailing white-space 
            }
        }

        private void displayAllDoctorssBtn_Click(object sender, EventArgs e)
        {
            this.doctorsTableAdapter.Fill(this.hospitalDatabaseDataSet.Doctors);
        }

        private void findAvailableDocBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.doctorsTableAdapter.FillAvailableDocs(this.hospitalDatabaseDataSet.Doctors);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Could not retrieve available doctors: " + exception.Message);
            }
        }

        private void findDoctorByName(string fullname)
        {
            try
            {
                this.doctorsTableAdapter.FillByName(this.hospitalDatabaseDataSet.Doctors, fullname);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error searching doctor: " + e.Message);
            }
        }

        private void findDoctorById(int id)
        {
            try
            {
                this.doctorsTableAdapter.FillByDoctorId(this.hospitalDatabaseDataSet.Doctors, id);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error searching doctor: " + e.Message);
            }
        }


        private void viewTodayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var adapter = new HospitalDatabaseDataSetTableAdapters.AppointmentsTableAdapter();
                var table = adapter.GetDataByToday();  // If using Fill method, bind to a dataset table instead

                appointmentsDataGridView.DataSource = table;
            }
            catch (Exception errror)
            {
                MessageBox.Show("Sorry, failed load appointments: " + errror.Message, "Database Problen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      public void DisplayAllAppointments()
      {
            string query = "SELECT * FROM Appointments";
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

        private void themeButton_Click(object sender, EventArgs e)
        {
            if (themeButton.Text.Equals("Set Dark"))
            {
                themeButton.ForeColor = Color.Black;
                themeButton.BackColor = Color.White;
                themeButton.Text = "Set Light";
                this.BackColor = Color.DarkGray;
                patientsTabPage.BackColor = Color.FromArgb(64, 64, 64);
                //patientsTabPage.ForeColor = Color.White;
                doctorsTabPage.BackColor = Color.FromArgb(64, 64, 64);
                //doctorsTabPage.ForeColor = Color.White;
                appointmentsTabPage.BackColor = Color.FromArgb(64, 64, 64);
                //appointmentsTabPage.ForeColor = Color.White;
                //recordsTabPage.ForeColor = Color.White;

            }
            else
            {
                themeButton.ForeColor = Color.White;
                themeButton.BackColor = Color.FromArgb(64, 64, 64);
                themeButton.Text = "Set Dark";
                this.BackColor = Color.PaleTurquoise;
                patientsTabPage.BackColor = Color.AliceBlue;
                patientsTabPage.ForeColor = Color.Black;
                doctorsTabPage.BackColor = Color.AliceBlue;
                doctorsTabPage.ForeColor = Color.Black;
                appointmentsTabPage.BackColor = Color.AliceBlue;
                appointmentsTabPage.ForeColor = Color.Black;
            }
        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            if (!isAdminUser)
            {
                MessageBox.Show("Only the admin can add new users.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else {
                this.Hide();
                AddUserForm addUserForm = new AddUserForm();
                addUserForm.ShowDialog();
                this.Close();
            }
        }

        private void timoutTimer_Tick(object sender, EventArgs e)
        {
            minutesElapsed++;

            if (minutesElapsed == timeoutMinutes - 1 && !warningShown)
            {
                MessageBox.Show("You will be logged out in 1 minute for to security reasons.", "Timeout Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                warningShown = true;
            }
            else if (minutesElapsed >= timeoutMinutes)
            {
                timoutTimer.Stop();
                MessageBox.Show("Session expired, so we will return to login.", "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //login form
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void changePswButton_Click(object sender, EventArgs e)
        {
            ChangePswForm changeForm = new ChangePswForm(currentUser); // pass logged-in username for the form

            changeForm.ShowDialog();
        }
    }
}

