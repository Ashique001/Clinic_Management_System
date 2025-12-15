using System;

namespace Clininc_Management_System.Models
{
    /// <summary>
    /// Represents a doctor in the clinic system.
    /// </summary>
    public class Doctor
    {
        public int Id { get; set; }               // Database identity / primary key
        public string DoctorId { get; set; }      // Business-facing doctor ID
        public string FullName { get; set; }
        public string Nid { get; set; }
        public int ExperienceYears { get; set; }
        public string Specialization { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Status { get; set; }        // Pending / Approved

        public bool IsApproved => string.Equals(Status, "Approved", StringComparison.OrdinalIgnoreCase);
    }
}


