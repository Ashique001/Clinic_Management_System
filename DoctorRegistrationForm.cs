using System;
using System.Windows.Forms;
using Clininc_Management_System.Data;

namespace Clininc_Management_System
{
    public partial class DoctorRegistrationForm : Form
    {
        public DoctorRegistrationForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtDoctorId.Text) ||
                string.IsNullOrWhiteSpace(txtNid.Text) ||
                string.IsNullOrWhiteSpace(txtExperience.Text) ||
                string.IsNullOrWhiteSpace(txtSpecialization.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblMessage.Text = "Please fill in all fields.";
                return;
            }

            if (!int.TryParse(txtExperience.Text, out var experienceYears))
            {
                lblMessage.Text = "Experience must be a valid number of years.";
                return;
            }

            try
            {
                var repo = new DoctorRegistrationRepository();
                repo.RegisterDoctor(
                    txtDoctorId.Text.Trim(),
                    txtFullName.Text.Trim(),
                    txtNid.Text.Trim(),
                    experienceYears,
                    txtSpecialization.Text.Trim(),
                    txtContact.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtPassword.Text.Trim());

                MessageBox.Show(
                    "Registration submitted for review.\nAn admin must approve your account before you can log in.",
                    "Registration Submitted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Could not submit registration. Please try again later.";
                Console.WriteLine(ex.Message);
            }
        }
    }
}


