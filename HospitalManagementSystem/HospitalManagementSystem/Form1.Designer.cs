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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.patientsTabPage = new System.Windows.Forms.TabPage();
            this.doctorsTabPage = new System.Windows.Forms.TabPage();
            this.appointmentsTabPage = new System.Windows.Forms.TabPage();
            this.recordsTabPage = new System.Windows.Forms.TabPage();
            this.dateUserControl1 = new HospitalManagementSystem.DateUserControl();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.patientsTabPage);
            this.tabControl1.Controls.Add(this.doctorsTabPage);
            this.tabControl1.Controls.Add(this.appointmentsTabPage);
            this.tabControl1.Controls.Add(this.recordsTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(25, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1531, 976);
            this.tabControl1.TabIndex = 0;
            // 
            // patientsTabPage
            // 
            this.patientsTabPage.Location = new System.Drawing.Point(8, 55);
            this.patientsTabPage.Name = "patientsTabPage";
            this.patientsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.patientsTabPage.Size = new System.Drawing.Size(1515, 913);
            this.patientsTabPage.TabIndex = 0;
            this.patientsTabPage.Text = "Patients";
            this.patientsTabPage.UseVisualStyleBackColor = true;
            // 
            // doctorsTabPage
            // 
            this.doctorsTabPage.Location = new System.Drawing.Point(8, 55);
            this.doctorsTabPage.Name = "doctorsTabPage";
            this.doctorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.doctorsTabPage.Size = new System.Drawing.Size(1515, 913);
            this.doctorsTabPage.TabIndex = 1;
            this.doctorsTabPage.Text = "Doctors";
            this.doctorsTabPage.UseVisualStyleBackColor = true;
            // 
            // appointmentsTabPage
            // 
            this.appointmentsTabPage.Location = new System.Drawing.Point(8, 55);
            this.appointmentsTabPage.Name = "appointmentsTabPage";
            this.appointmentsTabPage.Size = new System.Drawing.Size(1515, 913);
            this.appointmentsTabPage.TabIndex = 2;
            this.appointmentsTabPage.Text = "Appointments";
            this.appointmentsTabPage.UseVisualStyleBackColor = true;
            // 
            // recordsTabPage
            // 
            this.recordsTabPage.Location = new System.Drawing.Point(8, 55);
            this.recordsTabPage.Name = "recordsTabPage";
            this.recordsTabPage.Size = new System.Drawing.Size(1515, 913);
            this.recordsTabPage.TabIndex = 3;
            this.recordsTabPage.Text = "Records";
            this.recordsTabPage.UseVisualStyleBackColor = true;
            // 
            // dateUserControl1
            // 
            this.dateUserControl1.Location = new System.Drawing.Point(12, 12);
            this.dateUserControl1.Name = "dateUserControl1";
            this.dateUserControl1.Size = new System.Drawing.Size(351, 58);
            this.dateUserControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 1074);
            this.Controls.Add(this.dateUserControl1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Hospital Management System";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage patientsTabPage;
        private System.Windows.Forms.TabPage doctorsTabPage;
        private System.Windows.Forms.TabPage appointmentsTabPage;
        private System.Windows.Forms.TabPage recordsTabPage;
        private DateUserControl dateUserControl1;
    }
}

