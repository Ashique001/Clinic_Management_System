namespace Clininc_Management_System
{
    partial class DoctorDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lblDoctorId;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;

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
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblDoctorId = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoctorDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DoctorDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Management System - Doctor Profile";
            // 
            // Labels (simple layout; can be improved visually later)
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Location = new System.Drawing.Point(60, 60);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(0, 16);

            this.lblDoctorId.AutoSize = true;
            this.lblDoctorId.Location = new System.Drawing.Point(60, 100);
            this.lblDoctorId.Name = "lblDoctorId";
            this.lblDoctorId.Size = new System.Drawing.Size(0, 16);

            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Location = new System.Drawing.Point(60, 140);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(0, 16);

            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(60, 180);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(0, 16);

            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(60, 220);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(0, 16);

            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(60, 260);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 16);

            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.lblDoctorId);
            this.Controls.Add(this.lblSpecialization);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblEmail);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}


