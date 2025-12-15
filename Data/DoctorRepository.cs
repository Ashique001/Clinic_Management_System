using System;
using System.Data;
using System.Data.SqlClient;
using Clininc_Management_System.Models;

namespace Clininc_Management_System.Data
{
    /// <summary>
    /// Data access operations related to doctors.
    /// </summary>
    public class DoctorRepository
    {
        /// <summary>
        /// Validates doctor login against the database.
        /// Only allows doctors with Status = 'Approved'.
        /// </summary>
        public Doctor ValidateDoctorLogin(string doctorId, string password)
        {
            if (string.IsNullOrWhiteSpace(doctorId) || string.IsNullOrWhiteSpace(password))
                return null;

            try
            {
                using (var connection = Database.GetOpenConnection())
                using (var command = Database.CreateCommand(connection,
                    "SELECT TOP 1 Id, DoctorId, FullName, Nid, ExperienceYears, Specialization, ContactNumber, Email, Password, Status " +
                    "FROM Doctors WHERE DoctorId = @DoctorId AND Password = @Password AND Status = @Status"))
                {
                    command.Parameters.Add(new SqlParameter("@DoctorId", SqlDbType.NVarChar, 50) { Value = doctorId });
                    command.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 255) { Value = password });
                    command.Parameters.Add(new SqlParameter("@Status", SqlDbType.NVarChar, 20) { Value = "Approved" });

                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;

                        return MapDoctor(reader);
                    }
                }
            }
            catch (Exception)
            {
                // In a real system we would log this; for now, fail gracefully.
                return null;
            }
        }

        private static Doctor MapDoctor(IDataRecord record)
        {
            return new Doctor
            {
                Id = record["Id"] is DBNull ? 0 : Convert.ToInt32(record["Id"]),
                DoctorId = record["DoctorId"] as string,
                FullName = record["FullName"] as string,
                Nid = record["Nid"] as string,
                ExperienceYears = record["ExperienceYears"] is DBNull ? 0 : Convert.ToInt32(record["ExperienceYears"]),
                Specialization = record["Specialization"] as string,
                ContactNumber = record["ContactNumber"] as string,
                Email = record["Email"] as string,
                PasswordHash = record["Password"] as string,
                Status = record["Status"] as string
            };
        }
    }
}


