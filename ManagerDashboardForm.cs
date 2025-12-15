using System;
using System.Windows.Forms;
using Clininc_Management_System.Data;

namespace Clininc_Management_System
{
    public partial class ManagerDashboardForm : Form
    {
        private readonly DoctorAdminRepository _doctorAdminRepository;
        private readonly PatientRepository _patientRepository;

        public ManagerDashboardForm()
        {
            InitializeComponent();
            _doctorAdminRepository = new DoctorAdminRepository();
            _patientRepository = new PatientRepository();
            LoadDoctorList();
        }

        private void LoadDoctorList()
        {
            lblSectionTitle.Text = "Doctor List";
            lblHint.Text = "Read-only list of doctors.";
            gridData.DataSource = null;
            gridData.DataSource = _doctorAdminRepository.GetAllDoctors();
        }

        private void LoadPatientList()
        {
            lblSectionTitle.Text = "Patient List";
            lblHint.Text = "Read-only list of patients.";
            gridData.DataSource = null;
            gridData.DataSource = _patientRepository.GetAllPatients();
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
    }
}



