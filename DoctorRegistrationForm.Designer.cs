namespace Clininc_Management_System
{
    partial class DoctorRegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.TextBox txtNid;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblMessage;

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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.txtNid = new System.Windows.Forms.TextBox();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoctorRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DoctorRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doctor Registration";

            int leftLabel = 40;
            int leftInput = 200;
            int top = 30;
            int spacing = 35;

            // Full Name
            CreateLabel("Full Name", leftLabel, top);
            this.txtFullName.Location = new System.Drawing.Point(leftInput, top - 3);
            this.txtFullName.Width = 320;
            // Doctor ID
            top += spacing;
            CreateLabel("Doctor ID", leftLabel, top);
            this.txtDoctorId.Location = new System.Drawing.Point(leftInput, top - 3);
            this.txtDoctorId.Width = 320;
            // NID
            top += spacing;
            CreateLabel("NID", leftLabel, top);
            this.txtNid.Location = new System.Drawing.Point(leftInput, top - 3);
            this.txtNid.Width = 320;
            // Experience
            top += spacing;
            CreateLabel("Experience (years)", leftLabel, top);
            this.txtExperience.Location = new System.Drawing.Point(leftInput, top - 3);
            this.txtExperience.Width = 320;
            // Specialization
            top += spacing;
            CreateLabel("Specialization", leftLabel, top);
            this.txtSpecialization.Location = new System.Drawing.Point(leftInput, top - 3);
            this.txtSpecialization.Width = 320;
            // Contact
            top += spacing;
            CreateLabel("Contact Number", leftLabel, top);
            this.txtContact.Location = new System.Drawing.Point(leftInput, top - 3);
            this.txtContact.Width = 320;
            // Email
            top += spacing;
            CreateLabel("Email", leftLabel, top);
            this.txtEmail.Location = new System.Drawing.Point(leftInput, top - 3);
            this.txtEmail.Width = 320;
            // Password
            top += spacing;
            CreateLabel("Password", leftLabel, top);
            this.txtPassword.Location = new System.Drawing.Point(leftInput, top - 3);
            this.txtPassword.Width = 320;
            this.txtPassword.UseSystemPasswordChar = true;

            // Submit button
            this.btnSubmit.Text = "Submit for Review";
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(40, 116, 166);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(leftInput, top + 40);
            this.btnSubmit.Size = new System.Drawing.Size(180, 32);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // Message label
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMessage.Location = new System.Drawing.Point(leftInput, top + 80);

            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtDoctorId);
            this.Controls.Add(this.txtNid);
            this.Controls.Add(this.txtExperience);
            this.Controls.Add(this.txtSpecialization);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblMessage);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void CreateLabel(string text, int left, int top)
        {
            var label = new System.Windows.Forms.Label();
            label.AutoSize = true;
            label.Text = text;
            label.Location = new System.Drawing.Point(left, top);
            this.Controls.Add(label);
        }

        #endregion
    }
}


