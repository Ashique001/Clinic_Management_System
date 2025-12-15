using System.Windows.Forms;
using Clininc_Management_System.Models;

namespace Clininc_Management_System
{
    public partial class DoctorDashboardForm : Form
    {
        private readonly Doctor _doctor;

        public DoctorDashboardForm(Doctor doctor)
        {
            _doctor = doctor;
            InitializeComponent();
            PopulateProfile();
        }

        private void PopulateProfile()
        {
            if (_doctor == null)
                return;

            lblDoctorName.Text = _doctor.FullName;
            lblDoctorId.Text = _doctor.DoctorId;
            lblSpecialization.Text = _doctor.Specialization;
            lblExperience.Text = _doctor.ExperienceYears + " years";
            lblContact.Text = _doctor.ContactNumber;
            lblEmail.Text = _doctor.Email;
        }
    }
}


