namespace Clininc_Management_System.Models
{
    /// <summary>
    /// Represents a patient in the clinic system.
    /// </summary>
    public class Patient
    {
        public int Id { get; set; }           // Identity / primary key
        public string FullName { get; set; }
        public string PatientId { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}


