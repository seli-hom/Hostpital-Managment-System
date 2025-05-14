namespace HospitalManagementSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label patientIdLabel;
            System.Windows.Forms.Label familyDoctorLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label specialtyLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel1;
            System.Windows.Forms.Label lastNameLabel1;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.patientsTabPage = new System.Windows.Forms.TabPage();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDatabaseDataSet = new HospitalManagementSystem.HospitalDatabaseDataSet();
            this.doctorsTabPage = new System.Windows.Forms.TabPage();
            this.doctorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTabPage = new System.Windows.Forms.TabPage();
            this.appointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recordsTabPage = new System.Windows.Forms.TabPage();
            this.patientsTableAdapter = new HospitalManagementSystem.HospitalDatabaseDataSetTableAdapters.PatientsTableAdapter();
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
            this.patientsDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayAppintmentsBtn = new System.Windows.Forms.Button();
            this.rescheduleBtn = new System.Windows.Forms.Button();
            this.viewTodayBtn = new System.Windows.Forms.Button();
            this.findAppointmentBtn = new System.Windows.Forms.Button();
            this.bloodFilterButton = new System.Windows.Forms.Button();
            this.findPatientBtn = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.filterAgeButton = new System.Windows.Forms.Button();
            this.FindAvailableDocBtn = new System.Windows.Forms.Button();
            this.filterSpecialtyBtn = new System.Windows.Forms.Button();
            this.displayAllDoctorssBtn = new System.Windows.Forms.Button();
            this.findDoctorBtn = new System.Windows.Forms.Button();
            this.dateUserControl1 = new HospitalManagementSystem.DateUserControl();
            this.patientIdTextBox = new System.Windows.Forms.TextBox();
            this.familyDoctorTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.specialtyTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox1 = new System.Windows.Forms.TextBox();
            this.lastNameTextBox1 = new System.Windows.Forms.TextBox();
            this.patientInfo = new System.Windows.Forms.GroupBox();
            this.doctorInfo = new System.Windows.Forms.GroupBox();
            this.assignDoctorBtn = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).BeginInit();
            this.patientsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView1)).BeginInit();
            this.patientInfo.SuspendLayout();
            this.doctorInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.patientsTabPage);
            this.tabControl1.Controls.Add(this.doctorsTabPage);
            this.tabControl1.Controls.Add(this.appointmentsTabPage);
            this.tabControl1.Controls.Add(this.recordsTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 44);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1204, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // patientsTabPage
            // 
            this.patientsTabPage.Controls.Add(this.bloodFilterButton);
            this.patientsTabPage.Controls.Add(this.findPatientBtn);
            this.patientsTabPage.Controls.Add(this.displayButton);
            this.patientsTabPage.Controls.Add(this.filterAgeButton);
            this.patientsTabPage.Controls.Add(this.patientsDataGridView1);
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
            this.appointmentsTabPage.Controls.Add(this.rescheduleBtn);
            this.appointmentsTabPage.Controls.Add(this.findAppointmentBtn);
            this.appointmentsTabPage.Controls.Add(this.viewTodayBtn);
            this.appointmentsTabPage.Location = new System.Drawing.Point(4, 30);
            this.appointmentsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentsTabPage.Name = "appointmentsTabPage";
            this.appointmentsTabPage.Size = new System.Drawing.Size(1196, 378);
            this.appointmentsTabPage.TabIndex = 2;
            this.appointmentsTabPage.Text = "Appointments";
            this.appointmentsTabPage.UseVisualStyleBackColor = true;
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
            // recordsTabPage
            // 
            this.recordsTabPage.Controls.Add(this.assignDoctorBtn);
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
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = this.appointmentsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorsTableAdapter = this.doctorsTableAdapter;
            this.tableAdapterManager.PatientsTableAdapter = this.patientsTableAdapter;
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
            this.patientsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientsBindingNavigator.Name = "patientsBindingNavigator";
            this.patientsBindingNavigator.Padding = new System.Windows.Forms.Padding(0);
            this.patientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientsBindingNavigator.Size = new System.Drawing.Size(1462, 39);
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
            // patientsDataGridView1
            // 
            this.patientsDataGridView1.AutoGenerateColumns = false;
            this.patientsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.patientsDataGridView1.DataSource = this.patientsBindingSource;
            this.patientsDataGridView1.Location = new System.Drawing.Point(3, 5);
            this.patientsDataGridView1.Name = "patientsDataGridView1";
            this.patientsDataGridView1.Size = new System.Drawing.Size(1006, 220);
            this.patientsDataGridView1.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "PatientId";
            this.dataGridViewTextBoxColumn20.HeaderText = "PatientId";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn21.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn22.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn23.HeaderText = "Address";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Contact";
            this.dataGridViewTextBoxColumn24.HeaderText = "Contact";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "DateOfBirth";
            this.dataGridViewTextBoxColumn25.HeaderText = "DateOfBirth";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn26.HeaderText = "Sex";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "FamilyDoctor";
            this.dataGridViewTextBoxColumn27.HeaderText = "FamilyDoctor";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "BloodType";
            this.dataGridViewTextBoxColumn28.HeaderText = "BloodType";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // displayAppintmentsBtn
            // 
            this.displayAppintmentsBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAppintmentsBtn.Location = new System.Drawing.Point(1036, 204);
            this.displayAppintmentsBtn.Name = "displayAppintmentsBtn";
            this.displayAppintmentsBtn.Size = new System.Drawing.Size(136, 46);
            this.displayAppintmentsBtn.TabIndex = 20;
            this.displayAppintmentsBtn.Text = "Display All Appintments";
            this.findPatientTip.SetToolTip(this.displayAppintmentsBtn, "Enter the ID of the patient in the text field to the right.");
            this.displayAppintmentsBtn.UseVisualStyleBackColor = true;
            // 
            // rescheduleBtn
            // 
            this.rescheduleBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rescheduleBtn.Location = new System.Drawing.Point(1036, 142);
            this.rescheduleBtn.Name = "rescheduleBtn";
            this.rescheduleBtn.Size = new System.Drawing.Size(136, 46);
            this.rescheduleBtn.TabIndex = 19;
            this.rescheduleBtn.Text = "Reschedule Appintment";
            this.findPatientTip.SetToolTip(this.rescheduleBtn, "Enter the ID of the patient in the text field to the right.");
            this.rescheduleBtn.UseVisualStyleBackColor = true;
            // 
            // viewTodayBtn
            // 
            this.viewTodayBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTodayBtn.Location = new System.Drawing.Point(1036, 4);
            this.viewTodayBtn.Name = "viewTodayBtn";
            this.viewTodayBtn.Size = new System.Drawing.Size(136, 46);
            this.viewTodayBtn.TabIndex = 18;
            this.viewTodayBtn.Text = "View Todays Appointments";
            this.findPatientTip.SetToolTip(this.viewTodayBtn, "Enter the ID of the patient in the text field to the right.");
            this.viewTodayBtn.UseVisualStyleBackColor = true;
            // 
            // findAppointmentBtn
            // 
            this.findAppointmentBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findAppointmentBtn.Location = new System.Drawing.Point(1036, 72);
            this.findAppointmentBtn.Name = "findAppointmentBtn";
            this.findAppointmentBtn.Size = new System.Drawing.Size(136, 46);
            this.findAppointmentBtn.TabIndex = 17;
            this.findAppointmentBtn.Text = "Find Appointment";
            this.findPatientTip.SetToolTip(this.findAppointmentBtn, "Enter the ID of the patient in the text field to the right.");
            this.findAppointmentBtn.UseVisualStyleBackColor = true;
            // 
            // bloodFilterButton
            // 
            this.bloodFilterButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodFilterButton.Location = new System.Drawing.Point(1029, 16);
            this.bloodFilterButton.Name = "bloodFilterButton";
            this.bloodFilterButton.Size = new System.Drawing.Size(136, 46);
            this.bloodFilterButton.TabIndex = 11;
            this.bloodFilterButton.Text = "Filter by BloodType";
            this.findPatientTip.SetToolTip(this.bloodFilterButton, "Enter the ID of the patient in the text field to the right.");
            this.bloodFilterButton.UseVisualStyleBackColor = true;
            // 
            // findPatientBtn
            // 
            this.findPatientBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findPatientBtn.Location = new System.Drawing.Point(1029, 68);
            this.findPatientBtn.Name = "findPatientBtn";
            this.findPatientBtn.Size = new System.Drawing.Size(136, 46);
            this.findPatientBtn.TabIndex = 9;
            this.findPatientBtn.Text = "Find Patient";
            this.findPatientTip.SetToolTip(this.findPatientBtn, "Enter the ID of the patient in the text field to the right.");
            this.findPatientBtn.UseVisualStyleBackColor = true;
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.Location = new System.Drawing.Point(1029, 205);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(136, 46);
            this.displayButton.TabIndex = 10;
            this.displayButton.Text = "Display All Patients";
            this.findPatientTip.SetToolTip(this.displayButton, "Enter the ID of the patient in the text field to the right.");
            this.displayButton.UseVisualStyleBackColor = true;
            // 
            // filterAgeButton
            // 
            this.filterAgeButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterAgeButton.Location = new System.Drawing.Point(1029, 138);
            this.filterAgeButton.Name = "filterAgeButton";
            this.filterAgeButton.Size = new System.Drawing.Size(136, 46);
            this.filterAgeButton.TabIndex = 12;
            this.filterAgeButton.Text = "Find Patients older than...";
            this.findPatientTip.SetToolTip(this.filterAgeButton, "Enter the ID of the patient in the text field to the right.");
            this.filterAgeButton.UseVisualStyleBackColor = true;
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
            this.findDoctorBtn.Location = new System.Drawing.Point(1022, 73);
            this.findDoctorBtn.Name = "findDoctorBtn";
            this.findDoctorBtn.Size = new System.Drawing.Size(136, 46);
            this.findDoctorBtn.TabIndex = 12;
            this.findDoctorBtn.Text = "Find Doctor";
            this.findPatientTip.SetToolTip(this.findDoctorBtn, "Enter the ID of the patient in the text field to the right.");
            this.findDoctorBtn.UseVisualStyleBackColor = true;
            // 
            // dateUserControl1
            // 
            this.dateUserControl1.Location = new System.Drawing.Point(6, 6);
            this.dateUserControl1.Margin = new System.Windows.Forms.Padding(1);
            this.dateUserControl1.Name = "dateUserControl1";
            this.dateUserControl1.Size = new System.Drawing.Size(176, 30);
            this.dateUserControl1.TabIndex = 1;
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
            // patientIdTextBox
            // 
            this.patientIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "PatientId", true));
            this.patientIdTextBox.Location = new System.Drawing.Point(139, 48);
            this.patientIdTextBox.Name = "patientIdTextBox";
            this.patientIdTextBox.Size = new System.Drawing.Size(100, 28);
            this.patientIdTextBox.TabIndex = 1;
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
            // familyDoctorTextBox
            // 
            this.familyDoctorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "FamilyDoctor", true));
            this.familyDoctorTextBox.Location = new System.Drawing.Point(139, 103);
            this.familyDoctorTextBox.Name = "familyDoctorTextBox";
            this.familyDoctorTextBox.Size = new System.Drawing.Size(100, 28);
            this.familyDoctorTextBox.TabIndex = 3;
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
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(102, 27);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 28);
            this.firstNameTextBox.TabIndex = 5;
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
            // specialtyTextBox
            // 
            this.specialtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "Specialty", true));
            this.specialtyTextBox.Location = new System.Drawing.Point(102, 78);
            this.specialtyTextBox.Name = "specialtyTextBox";
            this.specialtyTextBox.Size = new System.Drawing.Size(100, 28);
            this.specialtyTextBox.TabIndex = 7;
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
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(339, 31);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 28);
            this.lastNameTextBox.TabIndex = 9;
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
            // firstNameTextBox1
            // 
            this.firstNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "FirstName", true));
            this.firstNameTextBox1.Location = new System.Drawing.Point(139, 162);
            this.firstNameTextBox1.Name = "firstNameTextBox1";
            this.firstNameTextBox1.Size = new System.Drawing.Size(100, 28);
            this.firstNameTextBox1.TabIndex = 11;
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
            // lastNameTextBox1
            // 
            this.lastNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "LastName", true));
            this.lastNameTextBox1.Location = new System.Drawing.Point(139, 208);
            this.lastNameTextBox1.Name = "lastNameTextBox1";
            this.lastNameTextBox1.Size = new System.Drawing.Size(100, 28);
            this.lastNameTextBox1.TabIndex = 13;
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
            // doctorInfo
            // 
            this.doctorInfo.Controls.Add(this.firstNameTextBox);
            this.doctorInfo.Controls.Add(firstNameLabel);
            this.doctorInfo.Controls.Add(lastNameLabel);
            this.doctorInfo.Controls.Add(this.specialtyTextBox);
            this.doctorInfo.Controls.Add(this.lastNameTextBox);
            this.doctorInfo.Controls.Add(specialtyLabel);
            this.doctorInfo.Location = new System.Drawing.Point(396, 25);
            this.doctorInfo.Name = "doctorInfo";
            this.doctorInfo.Size = new System.Drawing.Size(500, 119);
            this.doctorInfo.TabIndex = 15;
            this.doctorInfo.TabStop = false;
            this.doctorInfo.Text = "Doctor\'s Information";
            // 
            // assignDoctorBtn
            // 
            this.assignDoctorBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignDoctorBtn.Location = new System.Drawing.Point(399, 178);
            this.assignDoctorBtn.Name = "assignDoctorBtn";
            this.assignDoctorBtn.Size = new System.Drawing.Size(136, 46);
            this.assignDoctorBtn.TabIndex = 19;
            this.assignDoctorBtn.Text = "Assign Family Doctor";
            this.findPatientTip.SetToolTip(this.assignDoctorBtn, "Enter the ID of the patient in the text field to the right.");
            this.assignDoctorBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 728);
            this.Controls.Add(this.patientsBindingNavigator);
            this.Controls.Add(this.dateUserControl1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Hospital Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).EndInit();
            this.patientsBindingNavigator.ResumeLayout(false);
            this.patientsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView1)).EndInit();
            this.patientInfo.ResumeLayout(false);
            this.patientInfo.PerformLayout();
            this.doctorInfo.ResumeLayout(false);
            this.doctorInfo.PerformLayout();
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
        private HospitalDatabaseDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
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
        private System.Windows.Forms.DataGridView patientsDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.Button displayAppintmentsBtn;
        private System.Windows.Forms.Button rescheduleBtn;
        private System.Windows.Forms.Button viewTodayBtn;
        private System.Windows.Forms.Button findAppointmentBtn;
        private System.Windows.Forms.Button bloodFilterButton;
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
        private System.Windows.Forms.Button assignDoctorBtn;
        private System.Windows.Forms.GroupBox doctorInfo;
        private System.Windows.Forms.GroupBox patientInfo;
        private System.Windows.Forms.TextBox lastNameTextBox1;
        private System.Windows.Forms.TextBox firstNameTextBox1;
    }
}

