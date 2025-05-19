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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDatabaseDataSet = new HospitalManagementSystem.HospitalDatabaseDataSet();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.themeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeUserControl1 = new HospitalManagementSystem.TimeUserControl();
            this.dateUserControl1 = new HospitalManagementSystem.DateUserControl();
            this.logoutButton = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.patientsTableAdapter = new HospitalManagementSystem.HospitalDatabaseDataSetTableAdapters.PatientsTableAdapter();
            this.addNewUserButton = new System.Windows.Forms.Button();
            this.timoutTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.changePswButton = new System.Windows.Forms.Button();
            this.appointmentsTabPage = new System.Windows.Forms.TabPage();
            this.viewTodayBtn = new System.Windows.Forms.Button();
            this.appointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayAppintmentsBtn = new System.Windows.Forms.Button();
            this.doctorsTabPage = new System.Windows.Forms.TabPage();
            this.doctorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findDoctorBtn = new System.Windows.Forms.Button();
            this.displayAllDoctorssBtn = new System.Windows.Forms.Button();
            this.findAvailableDocBtn = new System.Windows.Forms.Button();
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.doctorIdLabelDoctors = new System.Windows.Forms.Label();
            this.doctorNameTextBox = new System.Windows.Forms.TextBox();
            this.doctorIdTextBoxDoctors = new System.Windows.Forms.TextBox();
            this.patientsTabPage = new System.Windows.Forms.TabPage();
            this.filterAgeButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.findPatientBtn = new System.Windows.Forms.Button();
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientAgeLabel = new System.Windows.Forms.Label();
            this.patientIdLabelPatients = new System.Windows.Forms.Label();
            this.patientAgeTextBox = new System.Windows.Forms.TextBox();
            this.patientIdTextBoxPatients = new System.Windows.Forms.TextBox();
            this.filterByBloodButton = new System.Windows.Forms.Button();
            this.bloodTypeComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).BeginInit();
            this.patientsBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.appointmentsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).BeginInit();
            this.doctorsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).BeginInit();
            this.patientsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
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
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            this.doctorsBindingSource.DataSource = this.hospitalDatabaseDataSet;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.hospitalDatabaseDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = this.appointmentsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorsTableAdapter = this.doctorsTableAdapter;
            this.tableAdapterManager.LoginTableAdapter = null;
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
            resources.ApplyResources(this.patientsBindingNavigator, "patientsBindingNavigator");
            this.patientsBindingNavigator.BindingSource = this.patientsBindingSource;
            this.patientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.patientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientsBindingNavigator.Name = "patientsBindingNavigator";
            this.patientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorDeleteItem, "bindingNavigatorDeleteItem");
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            // 
            // patientsBindingNavigatorSaveItem
            // 
            this.patientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.patientsBindingNavigatorSaveItem, "patientsBindingNavigatorSaveItem");
            this.patientsBindingNavigatorSaveItem.Name = "patientsBindingNavigatorSaveItem";
            this.patientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.patientsBindingNavigatorSaveItem_Click);
            // 
            // themeButton
            // 
            this.themeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.themeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.themeButton, "themeButton");
            this.themeButton.Name = "themeButton";
            this.findPatientTip.SetToolTip(this.themeButton, resources.GetString("themeButton.ToolTip"));
            this.themeButton.UseVisualStyleBackColor = false;
            this.themeButton.Click += new System.EventHandler(this.themeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeUserControl1);
            this.groupBox1.Controls.Add(this.dateUserControl1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // timeUserControl1
            // 
            resources.ApplyResources(this.timeUserControl1, "timeUserControl1");
            this.timeUserControl1.Name = "timeUserControl1";
            // 
            // dateUserControl1
            // 
            resources.ApplyResources(this.dateUserControl1, "dateUserControl1");
            this.dateUserControl1.Name = "dateUserControl1";
            // 
            // logoutButton
            // 
            resources.ApplyResources(this.logoutButton, "logoutButton");
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // languageComboBox
            // 
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1"),
            resources.GetString("languageComboBox.Items2")});
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.Name = "languageLabel";
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // addNewUserButton
            // 
            resources.ApplyResources(this.addNewUserButton, "addNewUserButton");
            this.addNewUserButton.Name = "addNewUserButton";
            this.addNewUserButton.UseVisualStyleBackColor = true;
            this.addNewUserButton.Click += new System.EventHandler(this.addNewUserButton_Click);
            // 
            // timoutTimer
            // 
            this.timoutTimer.Enabled = true;
            this.timoutTimer.Interval = 60000;
            this.timoutTimer.Tick += new System.EventHandler(this.timoutTimer_Tick);
            // 
            // changePswButton
            // 
            resources.ApplyResources(this.changePswButton, "changePswButton");
            this.changePswButton.Name = "changePswButton";
            this.changePswButton.UseVisualStyleBackColor = true;
            this.changePswButton.Click += new System.EventHandler(this.changePswButton_Click);
            // 
            // appointmentsTabPage
            // 
            this.appointmentsTabPage.BackColor = System.Drawing.Color.AliceBlue;
            this.appointmentsTabPage.Controls.Add(this.displayAppintmentsBtn);
            this.appointmentsTabPage.Controls.Add(this.appointmentsDataGridView);
            this.appointmentsTabPage.Controls.Add(this.viewTodayBtn);
            resources.ApplyResources(this.appointmentsTabPage, "appointmentsTabPage");
            this.appointmentsTabPage.Name = "appointmentsTabPage";
            // 
            // viewTodayBtn
            // 
            resources.ApplyResources(this.viewTodayBtn, "viewTodayBtn");
            this.viewTodayBtn.Name = "viewTodayBtn";
            this.findPatientTip.SetToolTip(this.viewTodayBtn, resources.GetString("viewTodayBtn.ToolTip"));
            this.viewTodayBtn.UseVisualStyleBackColor = true;
            this.viewTodayBtn.Click += new System.EventHandler(this.viewTodayBtn_Click);
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
            resources.ApplyResources(this.appointmentsDataGridView, "appointmentsDataGridView");
            this.appointmentsDataGridView.Name = "appointmentsDataGridView";
            this.appointmentsDataGridView.RowTemplate.Height = 33;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "DoctorId";
            resources.ApplyResources(this.dataGridViewTextBoxColumn19, "dataGridViewTextBoxColumn19");
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "PatientId";
            resources.ApplyResources(this.dataGridViewTextBoxColumn18, "dataGridViewTextBoxColumn18");
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Time";
            resources.ApplyResources(this.dataGridViewTextBoxColumn17, "dataGridViewTextBoxColumn17");
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Date";
            resources.ApplyResources(this.dataGridViewTextBoxColumn16, "dataGridViewTextBoxColumn16");
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "AppointmentId";
            resources.ApplyResources(this.dataGridViewTextBoxColumn15, "dataGridViewTextBoxColumn15");
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // displayAppintmentsBtn
            // 
            resources.ApplyResources(this.displayAppintmentsBtn, "displayAppintmentsBtn");
            this.displayAppintmentsBtn.Name = "displayAppintmentsBtn";
            this.findPatientTip.SetToolTip(this.displayAppintmentsBtn, resources.GetString("displayAppintmentsBtn.ToolTip"));
            this.displayAppintmentsBtn.UseVisualStyleBackColor = true;
            // 
            // doctorsTabPage
            // 
            this.doctorsTabPage.BackColor = System.Drawing.Color.AliceBlue;
            this.doctorsTabPage.Controls.Add(this.doctorIdTextBoxDoctors);
            this.doctorsTabPage.Controls.Add(this.doctorNameTextBox);
            this.doctorsTabPage.Controls.Add(this.doctorIdLabelDoctors);
            this.doctorsTabPage.Controls.Add(this.doctorNameLabel);
            this.doctorsTabPage.Controls.Add(this.findAvailableDocBtn);
            this.doctorsTabPage.Controls.Add(this.displayAllDoctorssBtn);
            this.doctorsTabPage.Controls.Add(this.findDoctorBtn);
            this.doctorsTabPage.Controls.Add(this.doctorsDataGridView);
            this.doctorsTabPage.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.doctorsTabPage, "doctorsTabPage");
            this.doctorsTabPage.Name = "doctorsTabPage";
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
            resources.ApplyResources(this.doctorsDataGridView, "doctorsDataGridView");
            this.doctorsDataGridView.Name = "doctorsDataGridView";
            this.doctorsDataGridView.RowTemplate.Height = 33;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Specialty";
            resources.ApplyResources(this.dataGridViewTextBoxColumn14, "dataGridViewTextBoxColumn14");
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Contact";
            resources.ApplyResources(this.dataGridViewTextBoxColumn13, "dataGridViewTextBoxColumn13");
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "LastName";
            resources.ApplyResources(this.dataGridViewTextBoxColumn12, "dataGridViewTextBoxColumn12");
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FirstName";
            resources.ApplyResources(this.dataGridViewTextBoxColumn11, "dataGridViewTextBoxColumn11");
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DoctorId";
            resources.ApplyResources(this.dataGridViewTextBoxColumn10, "dataGridViewTextBoxColumn10");
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // findDoctorBtn
            // 
            resources.ApplyResources(this.findDoctorBtn, "findDoctorBtn");
            this.findDoctorBtn.Name = "findDoctorBtn";
            this.findPatientTip.SetToolTip(this.findDoctorBtn, resources.GetString("findDoctorBtn.ToolTip"));
            this.findDoctorBtn.UseVisualStyleBackColor = true;
            this.findDoctorBtn.Click += new System.EventHandler(this.findDoctorBtn_Click);
            // 
            // displayAllDoctorssBtn
            // 
            resources.ApplyResources(this.displayAllDoctorssBtn, "displayAllDoctorssBtn");
            this.displayAllDoctorssBtn.Name = "displayAllDoctorssBtn";
            this.findPatientTip.SetToolTip(this.displayAllDoctorssBtn, resources.GetString("displayAllDoctorssBtn.ToolTip"));
            this.displayAllDoctorssBtn.UseVisualStyleBackColor = true;
            this.displayAllDoctorssBtn.Click += new System.EventHandler(this.displayAllDoctorssBtn_Click);
            // 
            // findAvailableDocBtn
            // 
            resources.ApplyResources(this.findAvailableDocBtn, "findAvailableDocBtn");
            this.findAvailableDocBtn.Name = "findAvailableDocBtn";
            this.findPatientTip.SetToolTip(this.findAvailableDocBtn, resources.GetString("findAvailableDocBtn.ToolTip"));
            this.findAvailableDocBtn.UseVisualStyleBackColor = true;
            this.findAvailableDocBtn.Click += new System.EventHandler(this.findAvailableDocBtn_Click);
            // 
            // doctorNameLabel
            // 
            resources.ApplyResources(this.doctorNameLabel, "doctorNameLabel");
            this.doctorNameLabel.Name = "doctorNameLabel";
            // 
            // doctorIdLabelDoctors
            // 
            resources.ApplyResources(this.doctorIdLabelDoctors, "doctorIdLabelDoctors");
            this.doctorIdLabelDoctors.Name = "doctorIdLabelDoctors";
            // 
            // doctorNameTextBox
            // 
            resources.ApplyResources(this.doctorNameTextBox, "doctorNameTextBox");
            this.doctorNameTextBox.Name = "doctorNameTextBox";
            // 
            // doctorIdTextBoxDoctors
            // 
            resources.ApplyResources(this.doctorIdTextBoxDoctors, "doctorIdTextBoxDoctors");
            this.doctorIdTextBoxDoctors.Name = "doctorIdTextBoxDoctors";
            // 
            // patientsTabPage
            // 
            this.patientsTabPage.BackColor = System.Drawing.Color.AliceBlue;
            this.patientsTabPage.Controls.Add(this.bloodTypeComboBox);
            this.patientsTabPage.Controls.Add(this.filterByBloodButton);
            this.patientsTabPage.Controls.Add(this.patientIdTextBoxPatients);
            this.patientsTabPage.Controls.Add(this.patientAgeTextBox);
            this.patientsTabPage.Controls.Add(this.patientIdLabelPatients);
            this.patientsTabPage.Controls.Add(this.patientAgeLabel);
            this.patientsTabPage.Controls.Add(this.patientsDataGridView);
            this.patientsTabPage.Controls.Add(this.findPatientBtn);
            this.patientsTabPage.Controls.Add(this.displayButton);
            this.patientsTabPage.Controls.Add(this.filterAgeButton);
            resources.ApplyResources(this.patientsTabPage, "patientsTabPage");
            this.patientsTabPage.Name = "patientsTabPage";
            // 
            // filterAgeButton
            // 
            resources.ApplyResources(this.filterAgeButton, "filterAgeButton");
            this.filterAgeButton.Name = "filterAgeButton";
            this.findPatientTip.SetToolTip(this.filterAgeButton, resources.GetString("filterAgeButton.ToolTip"));
            this.filterAgeButton.UseVisualStyleBackColor = true;
            this.filterAgeButton.Click += new System.EventHandler(this.filterAgeButton_Click);
            // 
            // displayButton
            // 
            resources.ApplyResources(this.displayButton, "displayButton");
            this.displayButton.Name = "displayButton";
            this.findPatientTip.SetToolTip(this.displayButton, resources.GetString("displayButton.ToolTip"));
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // findPatientBtn
            // 
            resources.ApplyResources(this.findPatientBtn, "findPatientBtn");
            this.findPatientBtn.Name = "findPatientBtn";
            this.findPatientTip.SetToolTip(this.findPatientBtn, resources.GetString("findPatientBtn.ToolTip"));
            this.findPatientBtn.UseVisualStyleBackColor = true;
            this.findPatientBtn.Click += new System.EventHandler(this.findPatientBtn_Click);
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
            resources.ApplyResources(this.patientsDataGridView, "patientsDataGridView");
            this.patientsDataGridView.Name = "patientsDataGridView";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "BloodType";
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Sex";
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DateOfBirth";
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Contact";
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PatientId";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // patientAgeLabel
            // 
            resources.ApplyResources(this.patientAgeLabel, "patientAgeLabel");
            this.patientAgeLabel.Name = "patientAgeLabel";
            // 
            // patientIdLabelPatients
            // 
            resources.ApplyResources(this.patientIdLabelPatients, "patientIdLabelPatients");
            this.patientIdLabelPatients.Name = "patientIdLabelPatients";
            // 
            // patientAgeTextBox
            // 
            resources.ApplyResources(this.patientAgeTextBox, "patientAgeTextBox");
            this.patientAgeTextBox.Name = "patientAgeTextBox";
            // 
            // patientIdTextBoxPatients
            // 
            resources.ApplyResources(this.patientIdTextBoxPatients, "patientIdTextBoxPatients");
            this.patientIdTextBoxPatients.Name = "patientIdTextBoxPatients";
            // 
            // filterByBloodButton
            // 
            resources.ApplyResources(this.filterByBloodButton, "filterByBloodButton");
            this.filterByBloodButton.Name = "filterByBloodButton";
            this.findPatientTip.SetToolTip(this.filterByBloodButton, resources.GetString("filterByBloodButton.ToolTip"));
            this.filterByBloodButton.UseVisualStyleBackColor = true;
            this.filterByBloodButton.Click += new System.EventHandler(this.filterByBloodButton_Click);
            // 
            // bloodTypeComboBox
            // 
            this.bloodTypeComboBox.FormattingEnabled = true;
            this.bloodTypeComboBox.Items.AddRange(new object[] {
            resources.GetString("bloodTypeComboBox.Items"),
            resources.GetString("bloodTypeComboBox.Items1"),
            resources.GetString("bloodTypeComboBox.Items2"),
            resources.GetString("bloodTypeComboBox.Items3"),
            resources.GetString("bloodTypeComboBox.Items4"),
            resources.GetString("bloodTypeComboBox.Items5"),
            resources.GetString("bloodTypeComboBox.Items6"),
            resources.GetString("bloodTypeComboBox.Items7")});
            resources.ApplyResources(this.bloodTypeComboBox, "bloodTypeComboBox");
            this.bloodTypeComboBox.Name = "bloodTypeComboBox";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.patientsTabPage);
            this.tabControl1.Controls.Add(this.doctorsTabPage);
            this.tabControl1.Controls.Add(this.appointmentsTabPage);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // ManagementForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.changePswButton);
            this.Controls.Add(this.addNewUserButton);
            this.Controls.Add(this.themeButton);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.patientsBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ManagementForm";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).EndInit();
            this.patientsBindingNavigator.ResumeLayout(false);
            this.patientsBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.appointmentsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).EndInit();
            this.doctorsTabPage.ResumeLayout(false);
            this.doctorsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).EndInit();
            this.patientsTabPage.ResumeLayout(false);
            this.patientsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private HospitalDatabaseDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private System.Windows.Forms.ToolTip findPatientTip;
        private System.Windows.Forms.GroupBox groupBox1;
        private TimeUserControl timeUserControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private HospitalDatabaseDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Button themeButton;
        private System.Windows.Forms.Button addNewUserButton;
        private System.Windows.Forms.Timer timoutTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button changePswButton;
        private System.Windows.Forms.TabPage appointmentsTabPage;
        private System.Windows.Forms.Button displayAppintmentsBtn;
        private System.Windows.Forms.DataGridView appointmentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.Button viewTodayBtn;
        private System.Windows.Forms.TabPage doctorsTabPage;
        private System.Windows.Forms.TextBox doctorIdTextBoxDoctors;
        private System.Windows.Forms.TextBox doctorNameTextBox;
        private System.Windows.Forms.Label doctorIdLabelDoctors;
        private System.Windows.Forms.Label doctorNameLabel;
        private System.Windows.Forms.Button findAvailableDocBtn;
        private System.Windows.Forms.Button displayAllDoctorssBtn;
        private System.Windows.Forms.Button findDoctorBtn;
        private System.Windows.Forms.DataGridView doctorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.TabPage patientsTabPage;
        private System.Windows.Forms.ComboBox bloodTypeComboBox;
        private System.Windows.Forms.Button filterByBloodButton;
        private System.Windows.Forms.TextBox patientIdTextBoxPatients;
        private System.Windows.Forms.TextBox patientAgeTextBox;
        private System.Windows.Forms.Label patientIdLabelPatients;
        private System.Windows.Forms.Label patientAgeLabel;
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button findPatientBtn;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button filterAgeButton;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

