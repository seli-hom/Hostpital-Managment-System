namespace HospitalManagementSystem
{
    partial class ChangePswForm
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
            this.confirmPswLabel = new System.Windows.Forms.Label();
            this.confirmNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.updatePswButton = new System.Windows.Forms.Button();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.oldPswTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // confirmPswLabel
            // 
            this.confirmPswLabel.AutoSize = true;
            this.confirmPswLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPswLabel.Location = new System.Drawing.Point(15, 131);
            this.confirmPswLabel.Name = "confirmPswLabel";
            this.confirmPswLabel.Size = new System.Drawing.Size(176, 20);
            this.confirmPswLabel.TabIndex = 19;
            this.confirmPswLabel.Text = "Confirm New Password:";
            // 
            // confirmNewPasswordTextBox
            // 
            this.confirmNewPasswordTextBox.Location = new System.Drawing.Point(208, 131);
            this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            this.confirmNewPasswordTextBox.PasswordChar = '*';
            this.confirmNewPasswordTextBox.Size = new System.Drawing.Size(266, 20);
            this.confirmNewPasswordTextBox.TabIndex = 18;
            this.confirmNewPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.Location = new System.Drawing.Point(74, 90);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(117, 20);
            this.newPasswordLabel.TabIndex = 17;
            this.newPasswordLabel.Text = "New Password:";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(208, 90);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            this.newPasswordTextBox.Size = new System.Drawing.Size(266, 20);
            this.newPasswordTextBox.TabIndex = 16;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // updatePswButton
            // 
            this.updatePswButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePswButton.Location = new System.Drawing.Point(499, 51);
            this.updatePswButton.Name = "updatePswButton";
            this.updatePswButton.Size = new System.Drawing.Size(96, 100);
            this.updatePswButton.TabIndex = 15;
            this.updatePswButton.Text = "Update Password";
            this.updatePswButton.UseVisualStyleBackColor = true;
            this.updatePswButton.Click += new System.EventHandler(this.updatePswButton_Click);
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordLabel.Location = new System.Drawing.Point(52, 51);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(139, 20);
            this.oldPasswordLabel.TabIndex = 14;
            this.oldPasswordLabel.Text = "Current Password:";
            // 
            // oldPswTextBox
            // 
            this.oldPswTextBox.Location = new System.Drawing.Point(208, 53);
            this.oldPswTextBox.Name = "oldPswTextBox";
            this.oldPswTextBox.PasswordChar = '*';
            this.oldPswTextBox.Size = new System.Drawing.Size(266, 20);
            this.oldPswTextBox.TabIndex = 20;
            this.oldPswTextBox.UseSystemPasswordChar = true;
            // 
            // ChangePswForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 203);
            this.Controls.Add(this.oldPswTextBox);
            this.Controls.Add(this.confirmPswLabel);
            this.Controls.Add(this.confirmNewPasswordTextBox);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.updatePswButton);
            this.Controls.Add(this.oldPasswordLabel);
            this.Name = "ChangePswForm";
            this.Text = "ChangePswForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirmPswLabel;
        private System.Windows.Forms.TextBox confirmNewPasswordTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Button updatePswButton;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.TextBox oldPswTextBox;
    }
}