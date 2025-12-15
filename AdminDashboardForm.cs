using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Clininc_Management_System.Data;
using Clininc_Management_System.Models;

namespace Clininc_Management_System
{
    public partial class AdminDashboardForm : Form
    {
        private readonly DoctorAdminRepository _doctorAdminRepository;
        private readonly PatientRepository _patientRepository;

        public AdminDashboardForm()
        {
            InitializeComponent();
            _doctorAdminRepository = new DoctorAdminRepository();
            _patientRepository = new PatientRepository();
            LoadDoctorList();
        }

        private void LoadDoctorList()
        {
            lblSectionTitle.Text = "Doctor List";
            lblHint.Text = "View all registered doctors.";
            BindGrid(_doctorAdminRepository.GetAllDoctors());
        }

        private void LoadPendingDoctors()
        {
            lblSectionTitle.Text = "Review Doctors";
            lblHint.Text = "Approve or delete pending doctor registrations.";
            BindGrid(_doctorAdminRepository.GetPendingDoctors());
        }

        private void LoadPatientList()
        {
            lblSectionTitle.Text = "Patient List";
            lblHint.Text = "View all registered patients.";
            BindGrid(_patientRepository.GetAllPatients());
        }

        private void BindGrid<IListT>(IListT list)
        {
            gridData.DataSource = null;
            gridData.DataSource = list;
        }

        private void btnDoctorList_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDoctorList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load doctor list.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPatientList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load patient list.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReviewDoctors_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPendingDoctors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load pending doctors.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            using (var form = new AddPatientForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        _patientRepository.AddPatient(form.Patient);
                        LoadPatientList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to add patient.\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            if (gridData.CurrentRow == null)
            {
                MessageBox.Show("Please select a patient row to delete.", "Delete Patient",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(gridData.CurrentRow.DataBoundItem is Patient patient))
            {
                MessageBox.Show("Current view is not the patient list.", "Delete Patient",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete patient '{patient.FullName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                _patientRepository.DeletePatientById(patient.Id);
                LoadPatientList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete patient.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Approve or delete the selected doctor when in Review Doctors section.
        /// For simplicity, this method approves on double-click; you could also
        /// add separate Approve/Delete buttons or a context menu.
        /// </summary>
        private void gridData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (!(gridData.Rows[e.RowIndex].DataBoundItem is Doctor doctor))
                return;

            if (!string.Equals(doctor.Status, "Pending", StringComparison.OrdinalIgnoreCase))
                return;

            var result = MessageBox.Show(
                $"Approve doctor '{doctor.FullName}' (ID: {doctor.DoctorId})?\n\n" +
                "Press Yes to Approve, No to Delete, Cancel to do nothing.",
                "Review Doctor",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            try
            {
                if (result == DialogResult.Yes)
                {
                    _doctorAdminRepository.ApproveDoctor(doctor.Id);
                }
                else if (result == DialogResult.No)
                {
                    _doctorAdminRepository.DeleteDoctor(doctor.Id);
                }
                LoadPendingDoctors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update doctor.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



