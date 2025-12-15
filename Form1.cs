using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clininc_Management_System.Services;

namespace Clininc_Management_System
{
    public partial class Form1 : Form
    {
        private readonly AuthService _authService;

        public Form1()
        {
            InitializeComponent();
            _authService = new AuthService();
            cmbRole.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;

            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();
            var role = GetSelectedRole();

            var result = _authService.Login(username, password, role);
            if (!result.Success)
            {
                lblError.Text = result.ErrorMessage;
                return;
            }

            Form dashboard = null;
            switch (result.Role)
            {
                case UserRole.Admin:
                    dashboard = new AdminDashboardForm();
                    break;
                case UserRole.Manager:
                    dashboard = new ManagerDashboardForm();
                    break;
                case UserRole.Doctor:
                    dashboard = new DoctorDashboardForm(result.Doctor);
                    break;
            }

            if (dashboard != null)
            {
                this.Hide();
                dashboard.FormClosed += (s, args) => this.Show();
                dashboard.Show();
            }
        }

        private UserRole GetSelectedRole()
        {
            var selected = cmbRole.SelectedItem as string;
            if (selected == "Manager")
                return UserRole.Manager;
            if (selected == "Doctor")
                return UserRole.Doctor;
            return UserRole.Admin;
        }

        private void btnDoctorRegister_Click(object sender, EventArgs e)
        {
            using (var form = new DoctorRegistrationForm())
            {
                form.ShowDialog(this);
            }
        }
    }
}

