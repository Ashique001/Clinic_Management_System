namespace Clininc_Management_System
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblClinicName;
        private System.Windows.Forms.Label lblClinicTagline;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Panel loginCardPanel;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnDoctorRegister;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblError;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblClinicName = new System.Windows.Forms.Label();
            this.lblClinicTagline = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.loginCardPanel = new System.Windows.Forms.Panel();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnDoctorRegister = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.loginCardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Management System - Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(40, 116, 166);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Height = 120;
            this.headerPanel.Controls.Add(this.lblClinicName);
            this.headerPanel.Controls.Add(this.lblClinicTagline);
            // 
            // lblClinicName
            // 
            this.lblClinicName.AutoSize = true;
            this.lblClinicName.ForeColor = System.Drawing.Color.White;
            this.lblClinicName.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblClinicName.Location = new System.Drawing.Point(40, 25);
            this.lblClinicName.Text = "Harmony Care Clinic";
            // 
            // lblClinicTagline
            // 
            this.lblClinicTagline.AutoSize = true;
            this.lblClinicTagline.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblClinicTagline.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.lblClinicTagline.Location = new System.Drawing.Point(44, 75);
            this.lblClinicTagline.Text = "Comprehensive outpatient care, diagnostics, and specialist consultations.";
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(244, 249, 253);
            this.infoPanel.Location = new System.Drawing.Point(40, 150);
            this.infoPanel.Size = new System.Drawing.Size(600, 380);
            this.infoPanel.Controls.Add(this.lblAddress);
            this.infoPanel.Controls.Add(this.lblServices);
            this.infoPanel.Controls.Add(this.lblContact);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAddress.Location = new System.Drawing.Point(25, 30);
            this.lblAddress.Text = "Address: 123 Harmony Road, City Center, Metroville";
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblServices.Location = new System.Drawing.Point(25, 80);
            this.lblServices.Text = "Services: General Medicine, Pediatrics, Cardiology, Diagnostics, Emergency Care";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblContact.Location = new System.Drawing.Point(25, 130);
            this.lblContact.Text = "Contact: +1 (555) 123-4567 | contact@harmonyclinic.com";
            // 
            // loginCardPanel
            // 
            this.loginCardPanel.BackColor = System.Drawing.Color.White;
            this.loginCardPanel.Location = new System.Drawing.Point(680, 200);
            this.loginCardPanel.Size = new System.Drawing.Size(360, 320);
            this.loginCardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginCardPanel.Controls.Add(this.lblLoginTitle);
            this.loginCardPanel.Controls.Add(this.lblUsername);
            this.loginCardPanel.Controls.Add(this.txtUsername);
            this.loginCardPanel.Controls.Add(this.lblPassword);
            this.loginCardPanel.Controls.Add(this.txtPassword);
            this.loginCardPanel.Controls.Add(this.lblRole);
            this.loginCardPanel.Controls.Add(this.cmbRole);
            this.loginCardPanel.Controls.Add(this.btnLogin);
            this.loginCardPanel.Controls.Add(this.btnDoctorRegister);
            this.loginCardPanel.Controls.Add(this.lblError);
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(40, 116, 166);
            this.lblLoginTitle.Location = new System.Drawing.Point(30, 20);
            this.lblLoginTitle.Text = "Secure Login";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsername.Location = new System.Drawing.Point(32, 70);
            this.lblUsername.Text = "Username / Doctor ID";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtUsername.Location = new System.Drawing.Point(35, 90);
            this.txtUsername.Width = 280;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassword.Location = new System.Drawing.Point(32, 125);
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPassword.Location = new System.Drawing.Point(35, 145);
            this.txtPassword.Width = 280;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRole.Location = new System.Drawing.Point(32, 180);
            this.lblRole.Text = "Role";
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbRole.Location = new System.Drawing.Point(35, 200);
            this.cmbRole.Width = 280;
            this.cmbRole.Items.AddRange(new object[] { "Admin", "Manager", "Doctor" });
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(40, 116, 166);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(35, 240);
            this.btnLogin.Size = new System.Drawing.Size(130, 32);
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnDoctorRegister
            // 
            this.btnDoctorRegister.BackColor = System.Drawing.Color.White;
            this.btnDoctorRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDoctorRegister.ForeColor = System.Drawing.Color.FromArgb(40, 116, 166);
            this.btnDoctorRegister.Location = new System.Drawing.Point(185, 240);
            this.btnDoctorRegister.Size = new System.Drawing.Size(130, 32);
            this.btnDoctorRegister.Text = "Doctor Register";
            this.btnDoctorRegister.UseVisualStyleBackColor = false;
            this.btnDoctorRegister.Click += new System.EventHandler(this.btnDoctorRegister_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(35, 285);
            this.lblError.Text = string.Empty;
            // 
            // Add controls to form
            // 
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.loginCardPanel);

            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.loginCardPanel.ResumeLayout(false);
            this.loginCardPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}

