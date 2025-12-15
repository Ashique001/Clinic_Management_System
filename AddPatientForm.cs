using System;
using System.Windows.Forms;
using Clininc_Management_System.Models;

namespace Clininc_Management_System
{
    public partial class AddPatientForm : Form
    {
        public Patient Patient { get; private set; }

        public AddPatientForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text))
            {
                lblMessage.Text = "Full Name, Contact, and Age are required.";
                return;
            }

            if (!int.TryParse(txtAge.Text, out var age))
            {
                lblMessage.Text = "Age must be a valid number.";
                return;
            }

            Patient = new Patient
            {
                FullName = txtFullName.Text.Trim(),
                ContactNumber = txtContact.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Gender = cmbGender.SelectedItem as string,
                Age = age
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}


