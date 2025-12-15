using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Clininc_Management_System.Models;

namespace Clininc_Management_System.Data
{
    /// <summary>
    /// Admin-oriented operations for managing doctors (review, approve, delete, list).
    /// </summary>
    public class DoctorAdminRepository
    {
        public IList<Doctor> GetPendingDoctors()
        {
            return GetDoctorsByStatus("Pending");
        }

        public IList<Doctor> GetAllDoctors()
        {
            var doctors = new List<Doctor>();
            using (var connection = Database.GetOpenConnection())
            using (var cmd = Database.CreateCommand(connection,
                       "SELECT " +
                       "DoctorId AS Id, " +
                       "DoctorCode AS DoctorId, " +
                       "FullName, " +
                       "NID AS Nid, " +
                       "Experience AS ExperienceYears, " +
                       "Specialization, " +
                       "Phone AS ContactNumber, " +
                       "Email, " +
                       "PasswordHash AS Password, " +
                       "Status " +
                       "FROM Doctors"))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    doctors.Add(MapDoctor(reader));
                }
            }

            return doctors;
        }

        public void ApproveDoctor(int id)
        {
            using (var connection = Database.GetOpenConnection())
            using (var cmd = Database.CreateCommand(connection,
                       "UPDATE Doctors SET Status = @Status WHERE DoctorId = @Id"))
            {
                cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.NVarChar, 20) { Value = "Approved" });
                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = id });
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteDoctor(int id)
        {
            using (var connection = Database.GetOpenConnection())
            using (var cmd = Database.CreateCommand(connection,
                       "DELETE FROM Doctors WHERE DoctorId = @Id"))
            {
                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = id });
                cmd.ExecuteNonQuery();
            }
        }

        private IList<Doctor> GetDoctorsByStatus(string status)
        {
            var doctors = new List<Doctor>();
            using (var connection = Database.GetOpenConnection())
            using (var cmd = Database.CreateCommand(connection,
                       "SELECT " +
                       "DoctorId AS Id, " +
                       "DoctorCode AS DoctorId, " +
                       "FullName, " +
                       "NID AS Nid, " +
                       "Experience AS ExperienceYears, " +
                       "Specialization, " +
                       "Phone AS ContactNumber, " +
                       "Email, " +
                       "PasswordHash AS Password, " +
                       "Status " +
                       "FROM Doctors WHERE Status = @Status"))
            {
                cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.NVarChar, 20) { Value = status });

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        doctors.Add(MapDoctor(reader));
                    }
                }
            }

            return doctors;
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


