using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void doctorFilterButton_Click(object sender, EventArgs e)
        {

        }

        private void patientAgeLabel_Click(object sender, EventArgs e)
        {

        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (languageComboBox.SelectedIndex == 1)
            {
                patientsTabPage.Text = "Patients";
                doctorsTabPage.Text = "Docteurs";
                appointmentsTabPage.Text = "Rendez-Vous";
                recordsTabPage.Text = "Dossiers";
                filterAgeButton.Text = "Trouve les patients plus grand que...";
                patientAgeLabel.Text = "Age";
                doctorFilterButton.Text = "Trouver par docteur";
                findPatientBtn.Text = "Trouver le patient";
                doctorIdLabelPatients.Text = "Id du docteur";
                patientNameLabel.Text = "Nom";
                patientIdLabelPatients.Text = "Id du Patient.";
                displayButton.Text = "Voir tous les patients";
                displayIcuPatientsBtn.Text = "Voir les patients emn urgence";
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
            }
        }
    }
}
