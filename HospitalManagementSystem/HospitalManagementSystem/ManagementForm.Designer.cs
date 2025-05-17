namespace HospitalManagementSystem
{
    partial class ManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label patientIdLabelRecords;
            System.Windows.Forms.Label doctorFirstNameLabelRecords;
            System.Windows.Forms.Label specialtyLabel;
            System.Windows.Forms.Label doctorLastNameLabelRecords;
            System.Windows.Forms.Label patientFirstNameLabelRecords;
            System.Windows.Forms.Label patientLastNameLabelRecords;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.patientsTabPage = new System.Windows.Forms.TabPage();
            this.bloodTypeComboBox = new System.Windows.Forms.ComboBox();
            this.filterByBloodButton = new System.Windows.Forms.Button();
            this.patientIdTextBoxPatients = new System.Windows.Forms.TextBox();
            this.patientIdLabelPatients = new System.Windows.Forms.Label();
            this.patientAgeTextBox = new System.Windows.Forms.TextBox();
            this.patientAgeLabel = new System.Windows.Forms.Label();
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDatabaseDataSet = new HospitalManagementSystem.HospitalDatabaseDataSet();
            this.findPatientBtn = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.filterAgeButton = new System.Windows.Forms.Button();
            this.doctorsTabPage = new System.Windows.Forms.TabPage();
            this.doctorIdTextBoxDoctors = new System.Windows.Forms.TextBox();
            this.doctorIdLabelDoctors = new System.Windows.Forms.Label();
            this.doctorNameTextBox = new System.Windows.Forms.TextBox();
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.findAvailableDocBtn = new System.Windows.Forms.Button();
            this.displayAllDoctorssBtn = new System.Windows.Forms.Button();
            this.findDoctorBtn = new System.Windows.Forms.Button();
            this.doctorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTabPage = new System.Windows.Forms.TabPage();
            this.displayAppintmentsBtn = new System.Windows.Forms.Button();
            this.appointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewTodayBtn = new System.Windows.Forms.Button();
            this.recordsTabPage = new System.Windows.Forms.TabPage();
            this.transferPatientButton = new System.Windows.Forms.Button();
            this.doctorInfo = new System.Windows.Forms.GroupBox();
            this.doctorFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.specialtyTextBox = new System.Windows.Forms.TextBox();
            this.doctorLastNameTextBox = new System.Windows.Forms.TextBox();
            this.patientInfo = new System.Windows.Forms.GroupBox();
            this.patientIdTextBoxRecords = new System.Windows.Forms.TextBox();
            this.patientLastNameTextBox = new System.Windows.Forms.TextBox();
            this.patientFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new HospitalManagementSystem.HospitalDatabaseDataSetTableAdapters.TableAdapterManager();
            this.appointmentsTableAdapter = new HospitalManagementSystem.HospitalDatabaseDataSetTableAdapters.AppointmentsTableAdapter();
            this.doctorsTableAdapter = new HospitalManagementSystem.HospitalDatabaseDataSetTableAdapters.DoctorsTableAdapter();
            this.patientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.patientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.findPatientTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeUserControl1 = new HospitalManagementSystem.TimeUserControl();
            this.dateUserControl1 = new HospitalManagementSystem.DateUserControl();
            this.patientsTableAdapter = new HospitalManagementSystem.HospitalDatabaseDataSetTableAdapters.PatientsTableAdapter();
            this.logoutButton = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            patientIdLabelRecords = new System.Windows.Forms.Label();
            doctorFirstNameLabelRecords = new System.Windows.Forms.Label();
            specialtyLabel = new System.Windows.Forms.Label();
            doctorLastNameLabelRecords = new System.Windows.Forms.Label();
            patientFirstNameLabelRecords = new System.Windows.Forms.Label();
            patientLastNameLabelRecords = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.patientsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).BeginInit();
            this.doctorsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            this.appointmentsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            this.recordsTabPage.SuspendLayout();
            this.doctorInfo.SuspendLayout();
            this.patientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).BeginInit();
            this.patientsBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientIdLabelRecords
            // 
            patientIdLabelRecords.AutoSize = true;
            patientIdLabelRecords.Location = new System.Drawing.Point(26, 98);
            patientIdLabelRecords.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            patientIdLabelRecords.Name = "patientIdLabelRecords";
            patientIdLabelRecords.Size = new System.Drawing.Size(173, 41);
            patientIdLabelRecords.TabIndex = 0;
            patientIdLabelRecords.Text = "Patient Id:";
            // 
            // doctorFirstNameLabelRecords
            // 
            doctorFirstNameLabelRecords.AutoSize = true;
            doctorFirstNameLabelRecords.Location = new System.Drawing.Point(-2, 58);
            doctorFirstNameLabelRecords.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            doctorFirstNameLabelRecords.Name = "doctorFirstNameLabelRecords";
            doctorFirstNameLabelRecords.Size = new System.Drawing.Size(192, 41);
            doctorFirstNameLabelRecords.TabIndex = 4;
            doctorFirstNameLabelRecords.Text = "First Name:";
            // 
            // specialtyLabel
            // 
            specialtyLabel.AutoSize = true;
            specialtyLabel.Location = new System.Drawing.Point(-2, 156);
            specialtyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            specialtyLabel.Name = "specialtyLabel";
            specialtyLabel.Size = new System.Drawing.Size(163, 41);
            specialtyLabel.TabIndex = 6;
            specialtyLabel.Text = "Specialty:";
            // 
            // doctorLastNameLabelRecords
            // 
            doctorLastNameLabelRecords.AutoSize = true;
            doctorLastNameLabelRecords.Location = new System.Drawing.Point(476, 65);
            doctorLastNameLabelRecords.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            doctorLastNameLabelRecords.Name = "doctorLastNameLabelRecords";
            doctorLastNameLabelRecords.Size = new System.Drawing.Size(188, 41);
            doctorLastNameLabelRecords.TabIndex = 8;
            doctorLastNameLabelRecords.Text = "Last Name:";
            // 
            // patientFirstNameLabelRecords
            // 
            patientFirstNameLabelRecords.AutoSize = true;
            patientFirstNameLabelRecords.Location = new System.Drawing.Point(26, 206);
            patientFirstNameLabelRecords.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            patientFirstNameLabelRecords.Name = "patientFirstNameLabelRecords";
            patientFirstNameLabelRecords.Size = new System.Drawing.Size(192, 41);
            patientFirstNameLabelRecords.TabIndex = 10;
            patientFirstNameLabelRecords.Text = "First Name:";
            // 
            // patientLastNameLabelRecords
            // 
            patientLastNameLabelRecords.AutoSize = true;
            patientLastNameLabelRecords.Location = new System.Drawing.Point(26, 302);
            patientLastNameLabelRecords.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            patientLastNameLabelRecords.Name = "patientLastNameLabelRecords";
            patientLastNameLabelRecords.Size = new System.Drawing.Size(188, 41);
            patientLastNameLabelRecords.TabIndex = 12;
            patientLastNameLabelRecords.Text = "Last Name:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.patientsTabPage);
            this.tabControl1.Controls.Add(this.doctorsTabPage);
            this.tabControl1.Controls.Add(this.appointmentsTabPage);
            this.tabControl1.Controls.Add(this.recordsTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(24, 188);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2408, 792);
            this.tabControl1.TabIndex = 0;
            // 
            // patientsTabPage
            // 
            this.patientsTabPage.Controls.Add(this.bloodTypeComboBox);
            this.patientsTabPage.Controls.Add(this.filterByBloodButton);
            this.patientsTabPage.Controls.Add(this.patientIdTextBoxPatients);
            this.patientsTabPage.Controls.Add(this.patientIdLabelPatients);
            this.patientsTabPage.Controls.Add(this.patientAgeTextBox);
            this.patientsTabPage.Controls.Add(this.patientAgeLabel);
            this.patientsTabPage.Controls.Add(this.patientsDataGridView);
            this.patientsTabPage.Controls.Add(this.findPatientBtn);
            this.patientsTabPage.Controls.Add(this.displayButton);
            this.patientsTabPage.Controls.Add(this.filterAgeButton);
            this.patientsTabPage.Location = new System.Drawing.Point(8, 55);
            this.patientsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.patientsTabPage.Name = "patientsTabPage";
            this.patientsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.patientsTabPage.Size = new System.Drawing.Size(2392, 729);
            this.patientsTabPage.TabIndex = 0;
            this.patientsTabPage.Text = "Patients";
            this.patientsTabPage.UseVisualStyleBackColor = true;
            // 
            // bloodTypeComboBox
            // 
            this.bloodTypeComboBox.FormattingEnabled = true;
            this.bloodTypeComboBox.Items.AddRange(new object[] {
            "A-",
            "A+",
            "AB-",
            "AB+",
            "B-",
            "B+",
            "O-",
            "O+"});
            this.bloodTypeComboBox.Location = new System.Drawing.Point(1166, 617);
            this.bloodTypeComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.bloodTypeComboBox.Name = "bloodTypeComboBox";
            this.bloodTypeComboBox.Size = new System.Drawing.Size(438, 49);
            this.bloodTypeComboBox.TabIndex = 29;
            // 
            // filterByBloodButton
            // 
            this.filterByBloodButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterByBloodButton.Location = new System.Drawing.Point(868, 600);
            this.filterByBloodButton.Margin = new System.Windows.Forms.Padding(6);
            this.filterByBloodButton.Name = "filterByBloodButton";
            this.filterByBloodButton.Size = new System.Drawing.Size(272, 88);
            this.filterByBloodButton.TabIndex = 28;
            this.filterByBloodButton.Text = "Filter By BloodType";
            this.findPatientTip.SetToolTip(this.filterByBloodButton, "Enter the ID of the patient in the text field to the right.");
            this.filterByBloodButton.UseVisualStyleBackColor = true;
            this.filterByBloodButton.Click += new System.EventHandler(this.filterByBloodButton_Click);
            // 
            // patientIdTextBoxPatients
            // 
            this.patientIdTextBoxPatients.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdTextBoxPatients.Location = new System.Drawing.Point(1370, 497);
            this.patientIdTextBoxPatients.Margin = new System.Windows.Forms.Padding(6);
            this.patientIdTextBoxPatients.Name = "patientIdTextBoxPatients";
            this.patientIdTextBoxPatients.Size = new System.Drawing.Size(438, 46);
            this.patientIdTextBoxPatients.TabIndex = 25;
            // 
            // patientIdLabelPatients
            // 
            this.patientIdLabelPatients.AutoSize = true;
            this.patientIdLabelPatients.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdLabelPatients.Location = new System.Drawing.Point(1150, 503);
            this.patientIdLabelPatients.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.patientIdLabelPatients.Name = "patientIdLabelPatients";
            this.patientIdLabelPatients.Size = new System.Drawing.Size(165, 39);
            this.patientIdLabelPatients.TabIndex = 24;
            this.patientIdLabelPatients.Text = "Patient ID:";
            // 
            // patientAgeTextBox
            // 
            this.patientAgeTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientAgeTextBox.Location = new System.Drawing.Point(410, 508);
            this.patientAgeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.patientAgeTextBox.Name = "patientAgeTextBox";
            this.patientAgeTextBox.Size = new System.Drawing.Size(292, 46);
            this.patientAgeTextBox.TabIndex = 21;
            // 
            // patientAgeLabel
            // 
            this.patientAgeLabel.AutoSize = true;
            this.patientAgeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientAgeLabel.Location = new System.Drawing.Point(312, 515);
            this.patientAgeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.patientAgeLabel.Name = "patientAgeLabel";
            this.patientAgeLabel.Size = new System.Drawing.Size(81, 39);
            this.patientAgeLabel.TabIndex = 20;
            this.patientAgeLabel.Text = "Age:";
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.AutoGenerateColumns = false;
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.patientsDataGridView.DataSource = this.patientsBindingSource;
            this.patientsDataGridView.Location = new System.Drawing.Point(10, 10);
            this.patientsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.RowHeadersWidth = 82;
            this.patientsDataGridView.Size = new System.Drawing.Size(1802, 423);
            this.patientsDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PatientId";
            this.dataGridViewTextBoxColumn1.HeaderText = "PatientId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Contact";
            this.dataGridViewTextBoxColumn5.HeaderText = "Contact";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DateOfBirth";
            this.dataGridViewTextBoxColumn6.HeaderText = "DateOfBirth";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn7.HeaderText = "Sex";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "BloodType";
            this.dataGridViewTextBoxColumn8.HeaderText = "BloodType";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.hospitalDatabaseDataSet;
            // 
            // hospitalDatabaseDataSet
            // 
            this.hospitalDatabaseDataSet.DataSetName = "HospitalDatabaseDataSet";
            this.hospitalDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // findPatientBtn
            // 
            this.findPatientBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findPatientBtn.Location = new System.Drawing.Point(866, 477);
            this.findPatientBtn.Margin = new System.Windows.Forms.Padding(6);
            this.findPatientBtn.Name = "findPatientBtn";
            this.findPatientBtn.Size = new System.Drawing.Size(272, 88);
            this.findPatientBtn.TabIndex = 9;
            this.findPatientBtn.Text = "Find Patient:";
            this.findPatientTip.SetToolTip(this.findPatientBtn, "Enter the ID of the patient in the text field to the right.");
            this.findPatientBtn.UseVisualStyleBackColor = true;
            this.findPatientBtn.Click += new System.EventHandler(this.findPatientBtn_Click);
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.Location = new System.Drawing.Point(1872, 10);
            this.displayButton.Margin = new System.Windows.Forms.Padding(6);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(444, 88);
            this.displayButton.TabIndex = 10;
            this.displayButton.Text = "Display All Patients";
            this.findPatientTip.SetToolTip(this.displayButton, "Enter the ID of the patient in the text field to the right.");
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // filterAgeButton
            // 
            this.filterAgeButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterAgeButton.Location = new System.Drawing.Point(26, 471);
            this.filterAgeButton.Margin = new System.Windows.Forms.Padding(6);
            this.filterAgeButton.Name = "filterAgeButton";
            this.filterAgeButton.Size = new System.Drawing.Size(272, 88);
            this.filterAgeButton.TabIndex = 12;
            this.filterAgeButton.Text = "Find Patients older than...";
            this.findPatientTip.SetToolTip(this.filterAgeButton, "Enter the ID of the patient in the text field to the right.");
            this.filterAgeButton.UseVisualStyleBackColor = true;
            this.filterAgeButton.Click += new System.EventHandler(this.filterAgeButton_Click);
            // 
            // doctorsTabPage
            // 
            this.doctorsTabPage.Controls.Add(this.doctorIdTextBoxDoctors);
            this.doctorsTabPage.Controls.Add(this.doctorIdLabelDoctors);
            this.doctorsTabPage.Controls.Add(this.doctorNameTextBox);
            this.doctorsTabPage.Controls.Add(this.doctorNameLabel);
            this.doctorsTabPage.Controls.Add(this.findAvailableDocBtn);
            this.doctorsTabPage.Controls.Add(this.displayAllDoctorssBtn);
            this.doctorsTabPage.Controls.Add(this.findDoctorBtn);
            this.doctorsTabPage.Controls.Add(this.doctorsDataGridView);
            this.doctorsTabPage.Location = new System.Drawing.Point(8, 55);
            this.doctorsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.doctorsTabPage.Name = "doctorsTabPage";
            this.doctorsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.doctorsTabPage.Size = new System.Drawing.Size(2392, 729);
            this.doctorsTabPage.TabIndex = 1;
            this.doctorsTabPage.Text = "Doctors";
            this.doctorsTabPage.UseVisualStyleBackColor = true;
            // 
            // doctorIdTextBoxDoctors
            // 
            this.doctorIdTextBoxDoctors.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorIdTextBoxDoctors.Location = new System.Drawing.Point(586, 573);
            this.doctorIdTextBoxDoctors.Margin = new System.Windows.Forms.Padding(6);
            this.doctorIdTextBoxDoctors.Name = "doctorIdTextBoxDoctors";
            this.doctorIdTextBoxDoctors.Size = new System.Drawing.Size(438, 46);
            this.doctorIdTextBoxDoctors.TabIndex = 19;
            // 
            // doctorIdLabelDoctors
            // 
            this.doctorIdLabelDoctors.AutoSize = true;
            this.doctorIdLabelDoctors.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorIdLabelDoctors.Location = new System.Drawing.Point(360, 587);
            this.doctorIdLabelDoctors.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.doctorIdLabelDoctors.Name = "doctorIdLabelDoctors";
            this.doctorIdLabelDoctors.Size = new System.Drawing.Size(163, 39);
            this.doctorIdLabelDoctors.TabIndex = 18;
            this.doctorIdLabelDoctors.Text = "Doctor ID:";
            // 
            // doctorNameTextBox
            // 
            this.doctorNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorNameTextBox.Location = new System.Drawing.Point(586, 500);
            this.doctorNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.doctorNameTextBox.Name = "doctorNameTextBox";
            this.doctorNameTextBox.Size = new System.Drawing.Size(438, 46);
            this.doctorNameTextBox.TabIndex = 17;
            // 
            // doctorNameLabel
            // 
            this.doctorNameLabel.AutoSize = true;
            this.doctorNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorNameLabel.Location = new System.Drawing.Point(360, 513);
            this.doctorNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(217, 39);
            this.doctorNameLabel.TabIndex = 16;
            this.doctorNameLabel.Text = "Doctor Name:";
            // 
            // findAvailableDocBtn
            // 
            this.findAvailableDocBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findAvailableDocBtn.Location = new System.Drawing.Point(2044, 35);
            this.findAvailableDocBtn.Margin = new System.Windows.Forms.Padding(6);
            this.findAvailableDocBtn.Name = "findAvailableDocBtn";
            this.findAvailableDocBtn.Size = new System.Drawing.Size(272, 88);
            this.findAvailableDocBtn.TabIndex = 15;
            this.findAvailableDocBtn.Text = "Find Available Doctors";
            this.findPatientTip.SetToolTip(this.findAvailableDocBtn, "Enter the ID of the patient in the text field to the right.");
            this.findAvailableDocBtn.UseVisualStyleBackColor = true;
            // 
            // displayAllDoctorssBtn
            // 
            this.displayAllDoctorssBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAllDoctorssBtn.Location = new System.Drawing.Point(2044, 165);
            this.displayAllDoctorssBtn.Margin = new System.Windows.Forms.Padding(6);
            this.displayAllDoctorssBtn.Name = "displayAllDoctorssBtn";
            this.displayAllDoctorssBtn.Size = new System.Drawing.Size(272, 88);
            this.displayAllDoctorssBtn.TabIndex = 13;
            this.displayAllDoctorssBtn.Text = "Display All Doctors";
            this.findPatientTip.SetToolTip(this.displayAllDoctorssBtn, "Enter the ID of the patient in the text field to the right.");
            this.displayAllDoctorssBtn.UseVisualStyleBackColor = true;
            // 
            // findDoctorBtn
            // 
            this.findDoctorBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findDoctorBtn.Location = new System.Drawing.Point(26, 513);
            this.findDoctorBtn.Margin = new System.Windows.Forms.Padding(6);
            this.findDoctorBtn.Name = "findDoctorBtn";
            this.findDoctorBtn.Size = new System.Drawing.Size(272, 88);
            this.findDoctorBtn.TabIndex = 12;
            this.findDoctorBtn.Text = "Find Doctor:";
            this.findPatientTip.SetToolTip(this.findDoctorBtn, "Enter the ID or name of the doctor");
            this.findDoctorBtn.UseVisualStyleBackColor = true;
            // 
            // doctorsDataGridView
            // 
            this.doctorsDataGridView.AutoGenerateColumns = false;
            this.doctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.doctorsDataGridView.DataSource = this.doctorsBindingSource;
            this.doctorsDataGridView.Location = new System.Drawing.Point(8, 8);
            this.doctorsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.doctorsDataGridView.Name = "doctorsDataGridView";
            this.doctorsDataGridView.RowHeadersWidth = 82;
            this.doctorsDataGridView.RowTemplate.Height = 33;
            this.doctorsDataGridView.Size = new System.Drawing.Size(1966, 467);
            this.doctorsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DoctorId";
            this.dataGridViewTextBoxColumn10.HeaderText = "DoctorId";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn11.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 200;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn12.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 200;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Contact";
            this.dataGridViewTextBoxColumn13.HeaderText = "Contact";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 200;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Specialty";
            this.dataGridViewTextBoxColumn14.HeaderText = "Specialty";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 200;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            this.doctorsBindingSource.DataSource = this.hospitalDatabaseDataSet;
            // 
            // appointmentsTabPage
            // 
            this.appointmentsTabPage.Controls.Add(this.displayAppintmentsBtn);
            this.appointmentsTabPage.Controls.Add(this.appointmentsDataGridView);
            this.appointmentsTabPage.Controls.Add(this.viewTodayBtn);
            this.appointmentsTabPage.Location = new System.Drawing.Point(8, 55);
            this.appointmentsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentsTabPage.Name = "appointmentsTabPage";
            this.appointmentsTabPage.Size = new System.Drawing.Size(2392, 729);
            this.appointmentsTabPage.TabIndex = 2;
            this.appointmentsTabPage.Text = "Appointments";
            this.appointmentsTabPage.UseVisualStyleBackColor = true;
            // 
            // displayAppintmentsBtn
            // 
            this.displayAppintmentsBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAppintmentsBtn.Location = new System.Drawing.Point(2072, 194);
            this.displayAppintmentsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.displayAppintmentsBtn.Name = "displayAppintmentsBtn";
            this.displayAppintmentsBtn.Size = new System.Drawing.Size(272, 88);
            this.displayAppintmentsBtn.TabIndex = 20;
            this.displayAppintmentsBtn.Text = "Display All Appintments";
            this.findPatientTip.SetToolTip(this.displayAppintmentsBtn, "Enter the ID of the patient in the text field to the right.");
            this.displayAppintmentsBtn.UseVisualStyleBackColor = true;
            // 
            // appointmentsDataGridView
            // 
            this.appointmentsDataGridView.AutoGenerateColumns = false;
            this.appointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.appointmentsDataGridView.DataSource = this.appointmentsBindingSource;
            this.appointmentsDataGridView.Location = new System.Drawing.Point(-4, 0);
            this.appointmentsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentsDataGridView.Name = "appointmentsDataGridView";
            this.appointmentsDataGridView.RowHeadersWidth = 82;
            this.appointmentsDataGridView.RowTemplate.Height = 33;
            this.appointmentsDataGridView.Size = new System.Drawing.Size(2028, 458);
            this.appointmentsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "AppointmentId";
            this.dataGridViewTextBoxColumn15.HeaderText = "AppointmentId";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 200;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn16.HeaderText = "Date";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 200;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn17.HeaderText = "Time";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 200;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "PatientId";
            this.dataGridViewTextBoxColumn18.HeaderText = "PatientId";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 200;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "DoctorId";
            this.dataGridViewTextBoxColumn19.HeaderText = "DoctorId";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 200;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.hospitalDatabaseDataSet;
            // 
            // viewTodayBtn
            // 
            this.viewTodayBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTodayBtn.Location = new System.Drawing.Point(2072, 46);
            this.viewTodayBtn.Margin = new System.Windows.Forms.Padding(6);
            this.viewTodayBtn.Name = "viewTodayBtn";
            this.viewTodayBtn.Size = new System.Drawing.Size(272, 88);
            this.viewTodayBtn.TabIndex = 18;
            this.viewTodayBtn.Text = "View Todays Appointments";
            this.findPatientTip.SetToolTip(this.viewTodayBtn, "Enter the ID of the patient in the text field to the right.");
            this.viewTodayBtn.UseVisualStyleBackColor = true;
            // 
            // recordsTabPage
            // 
            this.recordsTabPage.Controls.Add(this.transferPatientButton);
            this.recordsTabPage.Controls.Add(this.doctorInfo);
            this.recordsTabPage.Controls.Add(this.patientInfo);
            this.recordsTabPage.Location = new System.Drawing.Point(8, 55);
            this.recordsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.recordsTabPage.Name = "recordsTabPage";
            this.recordsTabPage.Size = new System.Drawing.Size(2392, 729);
            this.recordsTabPage.TabIndex = 3;
            this.recordsTabPage.Text = "Records";
            this.recordsTabPage.UseVisualStyleBackColor = true;
            // 
            // transferPatientButton
            // 
            this.transferPatientButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferPatientButton.Location = new System.Drawing.Point(798, 337);
            this.transferPatientButton.Margin = new System.Windows.Forms.Padding(6);
            this.transferPatientButton.Name = "transferPatientButton";
            this.transferPatientButton.Size = new System.Drawing.Size(272, 88);
            this.transferPatientButton.TabIndex = 20;
            this.transferPatientButton.Text = "Transfer Patient to Doctor";
            this.transferPatientButton.UseVisualStyleBackColor = true;
            // 
            // doctorInfo
            // 
            this.doctorInfo.Controls.Add(this.doctorFirstNameTextBox);
            this.doctorInfo.Controls.Add(doctorFirstNameLabelRecords);
            this.doctorInfo.Controls.Add(doctorLastNameLabelRecords);
            this.doctorInfo.Controls.Add(this.specialtyTextBox);
            this.doctorInfo.Controls.Add(this.doctorLastNameTextBox);
            this.doctorInfo.Controls.Add(specialtyLabel);
            this.doctorInfo.Location = new System.Drawing.Point(798, 25);
            this.doctorInfo.Margin = new System.Windows.Forms.Padding(6);
            this.doctorInfo.Name = "doctorInfo";
            this.doctorInfo.Padding = new System.Windows.Forms.Padding(6);
            this.doctorInfo.Size = new System.Drawing.Size(1000, 229);
            this.doctorInfo.TabIndex = 15;
            this.doctorInfo.TabStop = false;
            this.doctorInfo.Text = "Doctor\'s Information";
            // 
            // doctorFirstNameTextBox
            // 
            this.doctorFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "FirstName", true));
            this.doctorFirstNameTextBox.Location = new System.Drawing.Point(204, 52);
            this.doctorFirstNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.doctorFirstNameTextBox.Name = "doctorFirstNameTextBox";
            this.doctorFirstNameTextBox.Size = new System.Drawing.Size(196, 48);
            this.doctorFirstNameTextBox.TabIndex = 5;
            // 
            // specialtyTextBox
            // 
            this.specialtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "Specialty", true));
            this.specialtyTextBox.Location = new System.Drawing.Point(204, 150);
            this.specialtyTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.specialtyTextBox.Name = "specialtyTextBox";
            this.specialtyTextBox.Size = new System.Drawing.Size(196, 48);
            this.specialtyTextBox.TabIndex = 7;
            // 
            // doctorLastNameTextBox
            // 
            this.doctorLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "LastName", true));
            this.doctorLastNameTextBox.Location = new System.Drawing.Point(678, 60);
            this.doctorLastNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.doctorLastNameTextBox.Name = "doctorLastNameTextBox";
            this.doctorLastNameTextBox.Size = new System.Drawing.Size(196, 48);
            this.doctorLastNameTextBox.TabIndex = 9;
            // 
            // patientInfo
            // 
            this.patientInfo.Controls.Add(this.patientIdTextBoxRecords);
            this.patientInfo.Controls.Add(patientLastNameLabelRecords);
            this.patientInfo.Controls.Add(patientIdLabelRecords);
            this.patientInfo.Controls.Add(this.patientLastNameTextBox);
            this.patientInfo.Controls.Add(patientFirstNameLabelRecords);
            this.patientInfo.Controls.Add(this.patientFirstNameTextBox);
            this.patientInfo.Location = new System.Drawing.Point(38, 25);
            this.patientInfo.Margin = new System.Windows.Forms.Padding(6);
            this.patientInfo.Name = "patientInfo";
            this.patientInfo.Padding = new System.Windows.Forms.Padding(6);
            this.patientInfo.Size = new System.Drawing.Size(518, 429);
            this.patientInfo.TabIndex = 14;
            this.patientInfo.TabStop = false;
            this.patientInfo.Text = "Patient\'s information";
            // 
            // patientIdTextBoxRecords
            // 
            this.patientIdTextBoxRecords.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "PatientId", true));
            this.patientIdTextBoxRecords.Location = new System.Drawing.Point(278, 92);
            this.patientIdTextBoxRecords.Margin = new System.Windows.Forms.Padding(6);
            this.patientIdTextBoxRecords.Name = "patientIdTextBoxRecords";
            this.patientIdTextBoxRecords.Size = new System.Drawing.Size(196, 48);
            this.patientIdTextBoxRecords.TabIndex = 1;
            // 
            // patientLastNameTextBox
            // 
            this.patientLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "LastName", true));
            this.patientLastNameTextBox.Location = new System.Drawing.Point(278, 288);
            this.patientLastNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.patientLastNameTextBox.Name = "patientLastNameTextBox";
            this.patientLastNameTextBox.Size = new System.Drawing.Size(196, 48);
            this.patientLastNameTextBox.TabIndex = 13;
            // 
            // patientFirstNameTextBox
            // 
            this.patientFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "FirstName", true));
            this.patientFirstNameTextBox.Location = new System.Drawing.Point(278, 200);
            this.patientFirstNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.patientFirstNameTextBox.Name = "patientFirstNameTextBox";
            this.patientFirstNameTextBox.Size = new System.Drawing.Size(196, 48);
            this.patientFirstNameTextBox.TabIndex = 11;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = this.appointmentsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorsTableAdapter = this.doctorsTableAdapter;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HospitalManagementSystem.HospitalDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // patientsBindingNavigator
            // 
            this.patientsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientsBindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientsBindingNavigator.BindingSource = this.patientsBindingSource;
            this.patientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.patientsBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.patientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.patientsBindingNavigatorSaveItem});
            this.patientsBindingNavigator.Location = new System.Drawing.Point(482, 125);
            this.patientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientsBindingNavigator.Name = "patientsBindingNavigator";
            this.patientsBindingNavigator.Padding = new System.Windows.Forms.Padding(0);
            this.patientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientsBindingNavigator.Size = new System.Drawing.Size(484, 42);
            this.patientsBindingNavigator.TabIndex = 2;
            this.patientsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // patientsBindingNavigatorSaveItem
            // 
            this.patientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientsBindingNavigatorSaveItem.Image")));
            this.patientsBindingNavigatorSaveItem.Name = "patientsBindingNavigatorSaveItem";
            this.patientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.patientsBindingNavigatorSaveItem.Text = "Save Data";
            this.patientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.patientsBindingNavigatorSaveItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeUserControl1);
            this.groupBox1.Controls.Add(this.dateUserControl1);
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(522, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // timeUserControl1
            // 
            this.timeUserControl1.Location = new System.Drawing.Point(2048, 17);
            this.timeUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.timeUserControl1.Name = "timeUserControl1";
            this.timeUserControl1.Size = new System.Drawing.Size(332, 56);
            this.timeUserControl1.TabIndex = 13;
            // 
            // dateUserControl1
            // 
            this.dateUserControl1.Location = new System.Drawing.Point(20, 17);
            this.dateUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.dateUserControl1.Name = "dateUserControl1";
            this.dateUserControl1.Size = new System.Drawing.Size(568, 56);
            this.dateUserControl1.TabIndex = 1;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(2348, 23);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(6);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(272, 88);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // languageComboBox
            // 
            this.languageComboBox.Items.AddRange(new object[] {
            "English",
            "Français",
            "Español"});
            this.languageComboBox.Location = new System.Drawing.Point(2012, 23);
            this.languageComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(302, 33);
            this.languageComboBox.TabIndex = 13;
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.Location = new System.Drawing.Point(1830, 19);
            this.languageLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(169, 37);
            this.languageLabel.TabIndex = 14;
            this.languageLabel.Text = "Language:";
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2644, 1062);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.patientsBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagementForm";
            this.Text = "Hospital Management System";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.patientsTabPage.ResumeLayout(false);
            this.patientsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).EndInit();
            this.doctorsTabPage.ResumeLayout(false);
            this.doctorsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            this.appointmentsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            this.recordsTabPage.ResumeLayout(false);
            this.doctorInfo.ResumeLayout(false);
            this.doctorInfo.PerformLayout();
            this.patientInfo.ResumeLayout(false);
            this.patientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).EndInit();
            this.patientsBindingNavigator.ResumeLayout(false);
            this.patientsBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage patientsTabPage;
        private System.Windows.Forms.TabPage doctorsTabPage;
        private System.Windows.Forms.TabPage appointmentsTabPage;
        private System.Windows.Forms.TabPage recordsTabPage;
        private DateUserControl dateUserControl1;
        private HospitalDatabaseDataSet hospitalDatabaseDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private HospitalDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton patientsBindingNavigatorSaveItem;
        private HospitalDatabaseDataSetTableAdapters.DoctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private System.Windows.Forms.DataGridView doctorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private HospitalDatabaseDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private System.Windows.Forms.DataGridView appointmentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.ToolTip findPatientTip;
        private System.Windows.Forms.Button displayAppintmentsBtn;
        private System.Windows.Forms.Button viewTodayBtn;
        private System.Windows.Forms.Button findPatientBtn;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button filterAgeButton;
        private System.Windows.Forms.Button findAvailableDocBtn;
        private System.Windows.Forms.Button displayAllDoctorssBtn;
        private System.Windows.Forms.Button findDoctorBtn;
        private System.Windows.Forms.TextBox doctorLastNameTextBox;
        private System.Windows.Forms.TextBox specialtyTextBox;
        private System.Windows.Forms.TextBox doctorFirstNameTextBox;
        private System.Windows.Forms.TextBox patientIdTextBoxRecords;
        private System.Windows.Forms.GroupBox doctorInfo;
        private System.Windows.Forms.GroupBox patientInfo;
        private System.Windows.Forms.TextBox patientLastNameTextBox;
        private System.Windows.Forms.TextBox patientFirstNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private TimeUserControl timeUserControl1;
        private System.Windows.Forms.Button transferPatientButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private HospitalDatabaseDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.TextBox doctorIdTextBoxDoctors;
        private System.Windows.Forms.Label doctorIdLabelDoctors;
        private System.Windows.Forms.TextBox doctorNameTextBox;
        private System.Windows.Forms.Label doctorNameLabel;
        private System.Windows.Forms.TextBox patientIdTextBoxPatients;
        private System.Windows.Forms.Label patientIdLabelPatients;
        private System.Windows.Forms.TextBox patientAgeTextBox;
        private System.Windows.Forms.Label patientAgeLabel;
        private System.Windows.Forms.ComboBox bloodTypeComboBox;
        private System.Windows.Forms.Button filterByBloodButton;
    }
}

