using System;
using System.Data;
using System.Data.SqlClient;

namespace Clininc_Management_System.Data
{
    /// <summary>
    /// Handles doctor registration persistence. New doctors are saved with Status = 'Pending'.
    /// </summary>
    public class DoctorRegistrationRepository
    {
        public void RegisterDoctor(
            string doctorId,
            string fullName,
            string nid,
            int experienceYears,
            string specialization,
            string contactNumber,
            string email,
            string password)
        {
            using (var connection = Database.GetOpenConnection())
            using (var command = Database.CreateCommand(connection,
                "INSERT INTO Doctors (DoctorId, FullName, Nid, ExperienceYears, Specialization, ContactNumber, Email, Password, Status) " +
                "VALUES (@DoctorId, @FullName, @Nid, @ExperienceYears, @Specialization, @ContactNumber, @Email, @Password, @Status)"))
            {
                command.Parameters.Add(new SqlParameter("@DoctorId", SqlDbType.NVarChar, 50) { Value = doctorId });
                command.Parameters.Add(new SqlParameter("@FullName", SqlDbType.NVarChar, 150) { Value = fullName });
                command.Parameters.Add(new SqlParameter("@Nid", SqlDbType.NVarChar, 50) { Value = nid });
                command.Parameters.Add(new SqlParameter("@ExperienceYears", SqlDbType.Int) { Value = experienceYears });
                command.Parameters.Add(new SqlParameter("@Specialization", SqlDbType.NVarChar, 100) { Value = specialization });
                command.Parameters.Add(new SqlParameter("@ContactNumber", SqlDbType.NVarChar, 30) { Value = contactNumber });
                command.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 150) { Value = email });
                command.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 255) { Value = password });
                command.Parameters.Add(new SqlParameter("@Status", SqlDbType.NVarChar, 20) { Value = "Pending" });

                command.ExecuteNonQuery();
            }
        }
    }
}


