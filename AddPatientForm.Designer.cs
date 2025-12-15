namespace Clininc_Management_System
{
    partial class AddPatientForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnSave;
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
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddPatientForm";
            this.Text = "Add Patient";

            int leftLabel = 40;
            int leftInput = 190;
            int top = 30;
            int spacing = 35;

            CreateLabel("Full Name", leftLabel, top);
            this.txtFullName.Location = new System.Drawing.Point(leftInput, top - 3);
            this.txtFullName.Width = 280;

            top += spacing;
            CreateLabel("Patient ID", leftLabel, top);
            this.txtPatientId.Location = new System.Drawing.Point(leftInput, top - 3);
            this.txtPatientId.Width = 280;

            top += spacing;
            CreateLabel("Contact Number", leftLabel, top);
            this.txtContact.Location = new System.Drawing.Point(leftInput, top - 3);
            this.txtContact.Width = 280;

            top += spacing;
            CreateLabel("Address", leftLabel, top);
            this.txtAddress.Location = new System.Drawing.Point(leftInput, top - 3);
            this.txtAddress.Width = 280;

            top += spacing;
            CreateLabel("Gender", leftLabel, top);
            this.cmbGender.Location = new System.Drawing.Point(leftInput, top - 3);
            this.cmbGender.Width = 150;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });

            top += spacing;
            CreateLabel("Age", leftLabel, top);
            this.txtAge.Location = new System.Drawing.Point(leftInput, top - 3);
            this.txtAge.Width = 80;

            // Save button
            this.btnSave.Text = "Save";
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(40, 116, 166);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(leftInput, top + 40);
            this.btnSave.Size = new System.Drawing.Size(120, 32);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Message label
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMessage.Location = new System.Drawing.Point(leftInput, top + 80);

            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnSave);
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


