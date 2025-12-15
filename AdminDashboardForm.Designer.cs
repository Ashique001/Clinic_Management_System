namespace Clininc_Management_System
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnDoctorList;
        private System.Windows.Forms.Button btnPatientList;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Button btnReviewDoctors;
        private System.Windows.Forms.Button btnApproveDoctor;
        private System.Windows.Forms.Button btnDeleteDoctor;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.Label lblSectionTitle;
        private System.Windows.Forms.Label lblHint;

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
            this.panelNav = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnDoctorList = new System.Windows.Forms.Button();
            this.btnPatientList = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.btnReviewDoctors = new System.Windows.Forms.Button();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.lblSectionTitle = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.panelNav.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Management System - Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(40, 116, 166);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Width = 220;
            this.panelNav.Controls.Add(this.btnDoctorList);
            this.panelNav.Controls.Add(this.btnPatientList);
            this.panelNav.Controls.Add(this.btnAddPatient);
            this.panelNav.Controls.Add(this.btnDeletePatient);
            this.panelNav.Controls.Add(this.btnReviewDoctors);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Controls.Add(this.gridData);
            this.panelContent.Controls.Add(this.lblSectionTitle);
            this.panelContent.Controls.Add(this.lblHint);
            this.panelContent.Controls.Add(this.btnApproveDoctor);
            this.panelContent.Controls.Add(this.btnDeleteDoctor);
            // 
            // Buttons
            // 
            int navTop = 40;
            int navLeft = 20;
            int navWidth = 180;
            int navHeight = 36;
            int navSpacing = 12;

            ConfigureNavButton(this.btnDoctorList, "Doctor List", navLeft, navTop, navWidth, navHeight);
            this.btnDoctorList.Click += new System.EventHandler(this.btnDoctorList_Click);
            navTop += navHeight + navSpacing;

            ConfigureNavButton(this.btnPatientList, "Patient List", navLeft, navTop, navWidth, navHeight);
            this.btnPatientList.Click += new System.EventHandler(this.btnPatientList_Click);
            navTop += navHeight + navSpacing;

            ConfigureNavButton(this.btnAddPatient, "Add Patient", navLeft, navTop, navWidth, navHeight);
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            navTop += navHeight + navSpacing;

            ConfigureNavButton(this.btnDeletePatient, "Delete Patient", navLeft, navTop, navWidth, navHeight);
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            navTop += navHeight + navSpacing;

            ConfigureNavButton(this.btnReviewDoctors, "Review Doctors", navLeft, navTop, navWidth, navHeight);
            this.btnReviewDoctors.Click += new System.EventHandler(this.btnReviewDoctors_Click);
            // 
            // lblSectionTitle
            // 
            this.lblSectionTitle.AutoSize = true;
            this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSectionTitle.ForeColor = System.Drawing.Color.FromArgb(40, 116, 166);
            this.lblSectionTitle.Location = new System.Drawing.Point(250, 20);
            this.lblSectionTitle.Text = "Dashboard";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHint.ForeColor = System.Drawing.Color.DimGray;
            this.lblHint.Location = new System.Drawing.Point(252, 55);
            this.lblHint.Text = "Use the left navigation to manage doctors and patients.";
            // 
            // gridData
            // 
            this.gridData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridData.BackgroundColor = System.Drawing.Color.White;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Location = new System.Drawing.Point(256, 90);
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridData.Size = new System.Drawing.Size(820, 520);
            this.gridData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellDoubleClick);
            // 
            // btnApproveDoctor
            // 
            this.btnApproveDoctor.Text = "Approve Doctor";
            this.btnApproveDoctor.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnApproveDoctor.ForeColor = System.Drawing.Color.White;
            this.btnApproveDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproveDoctor.Location = new System.Drawing.Point(800, 40);
            this.btnApproveDoctor.Size = new System.Drawing.Size(130, 32);
            this.btnApproveDoctor.Click += new System.EventHandler(this.btnApproveDoctor_Click);
            // 
            // btnDeleteDoctor
            // 
            this.btnDeleteDoctor.Text = "Delete Doctor";
            this.btnDeleteDoctor.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnDeleteDoctor.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDoctor.Location = new System.Drawing.Point(940, 40);
            this.btnDeleteDoctor.Size = new System.Drawing.Size(130, 32);
            this.btnDeleteDoctor.Click += new System.EventHandler(this.btnDeleteDoctor_Click);

            // 
            // Add controls
            // 
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelNav);

            this.panelNav.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);
        }

        private void ConfigureNavButton(System.Windows.Forms.Button button, string text, int left, int top, int width, int height)
        {
            button.Text = text;
            button.Left = left;
            button.Top = top;
            button.Width = width;
            button.Height = height;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.ForeColor = System.Drawing.Color.White;
            button.BackColor = System.Drawing.Color.FromArgb(40, 116, 166);
            button.FlatAppearance.BorderSize = 0;
        }

        #endregion
    }
}


