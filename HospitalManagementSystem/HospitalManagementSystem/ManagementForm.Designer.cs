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
            System.Windows.Forms.Label patientIdLabel;
            System.Windows.Forms.Label familyDoctorLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label specialtyLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel1;
            System.Windows.Forms.Label lastNameLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.patientsTabPage = new System.Windows.Forms.TabPage();
            this.doctorFilterButton = new System.Windows.Forms.Button();
            this.findPatientBtn = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.filterAgeButton = new System.Windows.Forms.Button();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDatabaseDataSet = new HospitalManagementSystem.HospitalDatabaseDataSet();
            this.doctorsTabPage = new System.Windows.Forms.TabPage();
            this.FindAvailableDocBtn = new System.Windows.Forms.Button();
            this.filterSpecialtyBtn = new System.Windows.Forms.Button();
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.specialtyTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.patientInfo = new System.Windows.Forms.GroupBox();
            this.patientIdTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox1 = new System.Windows.Forms.TextBox();
            this.familyDoctorTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox1 = new System.Windows.Forms.TextBox();
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
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            patientIdLabel = new System.Windows.Forms.Label();
            familyDoctorLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            specialtyLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel1 = new System.Windows.Forms.Label();
            lastNameLabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.patientsTabPage.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patientIdLabel
            // 
            patientIdLabel.AutoSize = true;
            patientIdLabel.Location = new System.Drawing.Point(13, 51);
            patientIdLabel.Name = "patientIdLabel";
            patientIdLabel.Size = new System.Drawing.Size(88, 21);
            patientIdLabel.TabIndex = 0;
            patientIdLabel.Text = "Patient Id:";
            // 
            // familyDoctorLabel
            // 
            familyDoctorLabel.AutoSize = true;
            familyDoctorLabel.Location = new System.Drawing.Point(13, 106);
            familyDoctorLabel.Name = "familyDoctorLabel";
            familyDoctorLabel.Size = new System.Drawing.Size(120, 21);
            familyDoctorLabel.TabIndex = 2;
            familyDoctorLabel.Text = "Family Doctor:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(-1, 30);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(97, 21);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // specialtyLabel
            // 
            specialtyLabel.AutoSize = true;
            specialtyLabel.Location = new System.Drawing.Point(-1, 81);
            specialtyLabel.Name = "specialtyLabel";
            specialtyLabel.Size = new System.Drawing.Size(81, 21);
            specialtyLabel.TabIndex = 6;
            specialtyLabel.Text = "Specialty:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(238, 34);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(95, 21);
            lastNameLabel.TabIndex = 8;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel1
            // 
            firstNameLabel1.AutoSize = true;
            firstNameLabel1.Location = new System.Drawing.Point(13, 165);
            firstNameLabel1.Name = "firstNameLabel1";
            firstNameLabel1.Size = new System.Drawing.Size(97, 21);
            firstNameLabel1.TabIndex = 10;
            firstNameLabel1.Text = "First Name:";
            // 
            // lastNameLabel1
            // 
            lastNameLabel1.AutoSize = true;
            lastNameLabel1.Location = new System.Drawing.Point(13, 215);
            lastNameLabel1.Name = "lastNameLabel1";
            lastNameLabel1.Size = new System.Drawing.Size(95, 21);
            lastNameLabel1.TabIndex = 12;
            lastNameLabel1.Text = "Last Name:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.patientsTabPage);
            this.tabControl1.Controls.Add(this.doctorsTabPage);
            this.tabControl1.Controls.Add(this.appointmentsTabPage);
            this.tabControl1.Controls.Add(this.recordsTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 98);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1204, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // patientsTabPage
            // 
            this.patientsTabPage.Controls.Add(this.button1);
            this.patientsTabPage.Controls.Add(this.patientsDataGridView);
            this.patientsTabPage.Controls.Add(this.doctorFilterButton);
            this.patientsTabPage.Controls.Add(this.findPatientBtn);
            this.patientsTabPage.Controls.Add(this.displayButton);
            this.patientsTabPage.Controls.Add(this.filterAgeButton);
            this.patientsTabPage.Location = new System.Drawing.Point(4, 30);
            this.patientsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.patientsTabPage.Name = "patientsTabPage";
            this.patientsTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.patientsTabPage.Size = new System.Drawing.Size(1196, 378);
            this.patientsTabPage.TabIndex = 0;
            this.patientsTabPage.Text = "Patients";
            this.patientsTabPage.UseVisualStyleBackColor = true;
            this.patientsTabPage.Click += new System.EventHandler(this.patientsTabPage_Click);
            // 
            // doctorFilterButton
            // 
            this.doctorFilterButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorFilterButton.Location = new System.Drawing.Point(815, 245);
            this.doctorFilterButton.Name = "doctorFilterButton";
            this.doctorFilterButton.Size = new System.Drawing.Size(136, 46);
            this.doctorFilterButton.TabIndex = 11;
            this.doctorFilterButton.Text = "Filter by Doctor:";
            this.findPatientTip.SetToolTip(this.doctorFilterButton, "Enter the ID of the patient in the text field to the right.");
            this.doctorFilterButton.UseVisualStyleBackColor = true;
            // 
            // findPatientBtn
            // 
            this.findPatientBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findPatientBtn.Location = new System.Drawing.Point(414, 245);
            this.findPatientBtn.Name = "findPatientBtn";
            this.findPatientBtn.Size = new System.Drawing.Size(136, 46);
            this.findPatientBtn.TabIndex = 9;
            this.findPatientBtn.Text = "Find Patient:";
            this.findPatientTip.SetToolTip(this.findPatientBtn, "Enter the ID of the patient in the text field to the right.");
            this.findPatientBtn.UseVisualStyleBackColor = true;
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.Location = new System.Drawing.Point(936, 5);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(222, 46);
            this.displayButton.TabIndex = 10;
            this.displayButton.Text = "Display All Patients";
            this.findPatientTip.SetToolTip(this.displayButton, "Enter the ID of the patient in the text field to the right.");
            this.displayButton.UseVisualStyleBackColor = true;
            // 
            // filterAgeButton
            // 
            this.filterAgeButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterAgeButton.Location = new System.Drawing.Point(13, 245);
            this.filterAgeButton.Name = "filterAgeButton";
            this.filterAgeButton.Size = new System.Drawing.Size(136, 46);
            this.filterAgeButton.TabIndex = 12;
            this.filterAgeButton.Text = "Find Patients older than...";
            this.findPatientTip.SetToolTip(this.filterAgeButton, "Enter the ID of the patient in the text field to the right.");
            this.filterAgeButton.UseVisualStyleBackColor = true;
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
            // doctorsTabPage
            // 
            this.doctorsTabPage.Controls.Add(this.FindAvailableDocBtn);
            this.doctorsTabPage.Controls.Add(this.filterSpecialtyBtn);
            this.doctorsTabPage.Controls.Add(this.displayAllDoctorssBtn);
            this.doctorsTabPage.Controls.Add(this.findDoctorBtn);
            this.doctorsTabPage.Controls.Add(this.doctorsDataGridView);
            this.doctorsTabPage.Location = new System.Drawing.Point(4, 30);
            this.doctorsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.doctorsTabPage.Name = "doctorsTabPage";
            this.doctorsTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.doctorsTabPage.Size = new System.Drawing.Size(1196, 378);
            this.doctorsTabPage.TabIndex = 1;
            this.doctorsTabPage.Text = "Doctors";
            this.doctorsTabPage.UseVisualStyleBackColor = true;
            // 
            // FindAvailableDocBtn
            // 
            this.FindAvailableDocBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindAvailableDocBtn.Location = new System.Drawing.Point(1022, 143);
            this.FindAvailableDocBtn.Name = "FindAvailableDocBtn";
            this.FindAvailableDocBtn.Size = new System.Drawing.Size(136, 46);
            this.FindAvailableDocBtn.TabIndex = 15;
            this.FindAvailableDocBtn.Text = "Find Available Doctors";
            this.findPatientTip.SetToolTip(this.FindAvailableDocBtn, "Enter the ID of the patient in the text field to the right.");
            this.FindAvailableDocBtn.UseVisualStyleBackColor = true;
            // 
            // filterSpecialtyBtn
            // 
            this.filterSpecialtyBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterSpecialtyBtn.Location = new System.Drawing.Point(1022, 5);
            this.filterSpecialtyBtn.Name = "filterSpecialtyBtn";
            this.filterSpecialtyBtn.Size = new System.Drawing.Size(136, 46);
            this.filterSpecialtyBtn.TabIndex = 14;
            this.filterSpecialtyBtn.Text = "Filter by  specialty ";
            this.findPatientTip.SetToolTip(this.filterSpecialtyBtn, "Enter the ID of the patient in the text field to the right.");
            this.filterSpecialtyBtn.UseVisualStyleBackColor = true;
            // 
            // displayAllDoctorssBtn
            // 
            this.displayAllDoctorssBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAllDoctorssBtn.Location = new System.Drawing.Point(1022, 210);
            this.displayAllDoctorssBtn.Name = "displayAllDoctorssBtn";
            this.displayAllDoctorssBtn.Size = new System.Drawing.Size(136, 46);
            this.displayAllDoctorssBtn.TabIndex = 13;
            this.displayAllDoctorssBtn.Text = "Display All Doctors";
            this.findPatientTip.SetToolTip(this.displayAllDoctorssBtn, "Enter the ID of the patient in the text field to the right.");
            this.displayAllDoctorssBtn.UseVisualStyleBackColor = true;
            // 
            // findDoctorBtn
            // 
            this.findDoctorBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findDoctorBtn.Location = new System.Drawing.Point(1027, 308);
            this.findDoctorBtn.Name = "findDoctorBtn";
            this.findDoctorBtn.Size = new System.Drawing.Size(136, 46);
            this.findDoctorBtn.TabIndex = 12;
            this.findDoctorBtn.Text = "Find Doctor";
            this.findPatientTip.SetToolTip(this.findDoctorBtn, "Enter the ID of the patient in the text field to the right.");
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
            this.doctorsDataGridView.Location = new System.Drawing.Point(4, 4);
            this.doctorsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.doctorsDataGridView.Name = "doctorsDataGridView";
            this.doctorsDataGridView.RowHeadersWidth = 82;
            this.doctorsDataGridView.RowTemplate.Height = 33;
            this.doctorsDataGridView.Size = new System.Drawing.Size(983, 243);
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
            this.appointmentsTabPage.Location = new System.Drawing.Point(4, 30);
            this.appointmentsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentsTabPage.Name = "appointmentsTabPage";
            this.appointmentsTabPage.Size = new System.Drawing.Size(1196, 378);
            this.appointmentsTabPage.TabIndex = 2;
            this.appointmentsTabPage.Text = "Appointments";
            this.appointmentsTabPage.UseVisualStyleBackColor = true;
            // 
            // displayAppintmentsBtn
            // 
            this.displayAppintmentsBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAppintmentsBtn.Location = new System.Drawing.Point(1036, 101);
            this.displayAppintmentsBtn.Name = "displayAppintmentsBtn";
            this.displayAppintmentsBtn.Size = new System.Drawing.Size(136, 46);
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
            this.appointmentsDataGridView.Location = new System.Drawing.Point(-2, 0);
            this.appointmentsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentsDataGridView.Name = "appointmentsDataGridView";
            this.appointmentsDataGridView.RowHeadersWidth = 82;
            this.appointmentsDataGridView.RowTemplate.Height = 33;
            this.appointmentsDataGridView.Size = new System.Drawing.Size(1014, 238);
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
            this.viewTodayBtn.Location = new System.Drawing.Point(1036, 24);
            this.viewTodayBtn.Name = "viewTodayBtn";
            this.viewTodayBtn.Size = new System.Drawing.Size(136, 46);
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
            this.recordsTabPage.Location = new System.Drawing.Point(4, 30);
            this.recordsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.recordsTabPage.Name = "recordsTabPage";
            this.recordsTabPage.Size = new System.Drawing.Size(1196, 378);
            this.recordsTabPage.TabIndex = 3;
            this.recordsTabPage.Text = "Records";
            this.recordsTabPage.UseVisualStyleBackColor = true;
            // 
            // transferPatientButton
            // 
            this.transferPatientButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferPatientButton.Location = new System.Drawing.Point(399, 175);
            this.transferPatientButton.Name = "transferPatientButton";
            this.transferPatientButton.Size = new System.Drawing.Size(136, 46);
            this.transferPatientButton.TabIndex = 20;
            this.transferPatientButton.Text = "Transfer Patient to Doctor";
            this.transferPatientButton.UseVisualStyleBackColor = true;
            // 
            // doctorInfo
            // 
            this.doctorInfo.Controls.Add(this.firstNameTextBox);
            this.doctorInfo.Controls.Add(firstNameLabel);
            this.doctorInfo.Controls.Add(lastNameLabel);
            this.doctorInfo.Controls.Add(this.specialtyTextBox);
            this.doctorInfo.Controls.Add(this.lastNameTextBox);
            this.doctorInfo.Controls.Add(specialtyLabel);
            this.doctorInfo.Location = new System.Drawing.Point(399, 13);
            this.doctorInfo.Name = "doctorInfo";
            this.doctorInfo.Size = new System.Drawing.Size(500, 119);
            this.doctorInfo.TabIndex = 15;
            this.doctorInfo.TabStop = false;
            this.doctorInfo.Text = "Doctor\'s Information";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(102, 27);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 28);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // specialtyTextBox
            // 
            this.specialtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "Specialty", true));
            this.specialtyTextBox.Location = new System.Drawing.Point(102, 78);
            this.specialtyTextBox.Name = "specialtyTextBox";
            this.specialtyTextBox.Size = new System.Drawing.Size(100, 28);
            this.specialtyTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(339, 31);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 28);
            this.lastNameTextBox.TabIndex = 9;
            // 
            // patientInfo
            // 
            this.patientInfo.Controls.Add(this.patientIdTextBox);
            this.patientInfo.Controls.Add(lastNameLabel1);
            this.patientInfo.Controls.Add(patientIdLabel);
            this.patientInfo.Controls.Add(this.lastNameTextBox1);
            this.patientInfo.Controls.Add(this.familyDoctorTextBox);
            this.patientInfo.Controls.Add(firstNameLabel1);
            this.patientInfo.Controls.Add(familyDoctorLabel);
            this.patientInfo.Controls.Add(this.firstNameTextBox1);
            this.patientInfo.Location = new System.Drawing.Point(19, 13);
            this.patientInfo.Name = "patientInfo";
            this.patientInfo.Size = new System.Drawing.Size(259, 264);
            this.patientInfo.TabIndex = 14;
            this.patientInfo.TabStop = false;
            this.patientInfo.Text = "Patient\'s information";
            // 
            // patientIdTextBox
            // 
            this.patientIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "PatientId", true));
            this.patientIdTextBox.Location = new System.Drawing.Point(139, 48);
            this.patientIdTextBox.Name = "patientIdTextBox";
            this.patientIdTextBox.Size = new System.Drawing.Size(100, 28);
            this.patientIdTextBox.TabIndex = 1;
            // 
            // lastNameTextBox1
            // 
            this.lastNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "LastName", true));
            this.lastNameTextBox1.Location = new System.Drawing.Point(139, 208);
            this.lastNameTextBox1.Name = "lastNameTextBox1";
            this.lastNameTextBox1.Size = new System.Drawing.Size(100, 28);
            this.lastNameTextBox1.TabIndex = 13;
            // 
            // familyDoctorTextBox
            // 
            this.familyDoctorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "FamilyDoctor", true));
            this.familyDoctorTextBox.Location = new System.Drawing.Point(139, 103);
            this.familyDoctorTextBox.Name = "familyDoctorTextBox";
            this.familyDoctorTextBox.Size = new System.Drawing.Size(100, 28);
            this.familyDoctorTextBox.TabIndex = 3;
            // 
            // firstNameTextBox1
            // 
            this.firstNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "FirstName", true));
            this.firstNameTextBox1.Location = new System.Drawing.Point(139, 162);
            this.firstNameTextBox1.Name = "firstNameTextBox1";
            this.firstNameTextBox1.Size = new System.Drawing.Size(100, 28);
            this.firstNameTextBox1.TabIndex = 11;
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
            this.patientsBindingNavigator.Location = new System.Drawing.Point(241, 65);
            this.patientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientsBindingNavigator.Name = "patientsBindingNavigator";
            this.patientsBindingNavigator.Padding = new System.Windows.Forms.Padding(0);
            this.patientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientsBindingNavigator.Size = new System.Drawing.Size(345, 39);
            this.patientsBindingNavigator.TabIndex = 2;
            this.patientsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(27, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // patientsBindingNavigatorSaveItem
            // 
            this.patientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientsBindingNavigatorSaveItem.Image")));
            this.patientsBindingNavigatorSaveItem.Name = "patientsBindingNavigatorSaveItem";
            this.patientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.patientsBindingNavigatorSaveItem.Text = "Save Data";
            this.patientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.patientsBindingNavigatorSaveItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeUserControl1);
            this.groupBox1.Controls.Add(this.dateUserControl1);
            this.groupBox1.Location = new System.Drawing.Point(19, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(261, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // timeUserControl1
            // 
            this.timeUserControl1.Location = new System.Drawing.Point(1024, 9);
            this.timeUserControl1.Margin = new System.Windows.Forms.Padding(1);
            this.timeUserControl1.Name = "timeUserControl1";
            this.timeUserControl1.Size = new System.Drawing.Size(166, 29);
            this.timeUserControl1.TabIndex = 13;
            // 
            // dateUserControl1
            // 
            this.dateUserControl1.Location = new System.Drawing.Point(10, 9);
            this.dateUserControl1.Margin = new System.Windows.Forms.Padding(1);
            this.dateUserControl1.Name = "dateUserControl1";
            this.dateUserControl1.Size = new System.Drawing.Size(284, 29);
            this.dateUserControl1.TabIndex = 1;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
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
            this.patientsDataGridView.Location = new System.Drawing.Point(5, 5);
            this.patientsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.RowHeadersWidth = 82;
            this.patientsDataGridView.Size = new System.Drawing.Size(901, 220);
            this.patientsDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PatientId";
            this.dataGridViewTextBoxColumn1.HeaderText = "PatientId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Contact";
            this.dataGridViewTextBoxColumn5.HeaderText = "Contact";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DateOfBirth";
            this.dataGridViewTextBoxColumn6.HeaderText = "DateOfBirth";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn7.HeaderText = "Sex";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "BloodType";
            this.dataGridViewTextBoxColumn8.HeaderText = "BloodType";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(936, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Display ICU Patients";
            this.findPatientTip.SetToolTip(this.button1, "Enter the ID of the patient in the text field to the right.");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(1174, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(136, 46);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 552);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.patientsBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagementForm";
            this.Text = "Hospital Management System";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.patientsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).EndInit();
            this.doctorsTabPage.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
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
        private System.Windows.Forms.Button doctorFilterButton;
        private System.Windows.Forms.Button findPatientBtn;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button filterAgeButton;
        private System.Windows.Forms.Button FindAvailableDocBtn;
        private System.Windows.Forms.Button filterSpecialtyBtn;
        private System.Windows.Forms.Button displayAllDoctorssBtn;
        private System.Windows.Forms.Button findDoctorBtn;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox specialtyTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox familyDoctorTextBox;
        private System.Windows.Forms.TextBox patientIdTextBox;
        private System.Windows.Forms.GroupBox doctorInfo;
        private System.Windows.Forms.GroupBox patientInfo;
        private System.Windows.Forms.TextBox lastNameTextBox1;
        private System.Windows.Forms.TextBox firstNameTextBox1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logoutButton;
    }
}

