using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Clininc_Management_System.Models;

namespace Clininc_Management_System.Data
{
    /// <summary>
    /// Data access for patient CRUD operations.
    /// </summary>
    public class PatientRepository
    {
        public IList<Patient> GetAllPatients()
        {
            var patients = new List<Patient>();
            using (var connection = Database.GetOpenConnection())
            using (var cmd = Database.CreateCommand(connection,
                       "SELECT PatientId, FullName, Age, Gender, Phone, Address FROM Patients"))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    patients.Add(MapPatient(reader));
                }
            }

            return patients;
        }

        public void AddPatient(Patient patient)
        {
            using (var connection = Database.GetOpenConnection())
            using (var cmd = Database.CreateCommand(connection,
                       "INSERT INTO Patients (FullName, Age, Gender, Phone, Address) " +
                       "VALUES (@FullName, @Age, @Gender, @Phone, @Address)"))
            {
                cmd.Parameters.Add(new SqlParameter("@FullName", SqlDbType.NVarChar, 150) { Value = patient.FullName });
                cmd.Parameters.Add(new SqlParameter("@Age", SqlDbType.Int) { Value = patient.Age });
                cmd.Parameters.Add(new SqlParameter("@Gender", SqlDbType.NVarChar, 10) { Value = (object)patient.Gender ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 20) { Value = (object)patient.ContactNumber ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 255) { Value = (object)patient.Address ?? DBNull.Value });

                cmd.ExecuteNonQuery();
            }
        }

        public void DeletePatientById(int id)
        {
            using (var connection = Database.GetOpenConnection())
            using (var cmd = Database.CreateCommand(connection,
                       "DELETE FROM Patients WHERE PatientId = @Id"))
            {
                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = id });
                cmd.ExecuteNonQuery();
            }
        }

        private static Patient MapPatient(IDataRecord record)
        {
            return new Patient
            {
                Id = record["PatientId"] is DBNull ? 0 : Convert.ToInt32(record["PatientId"]),
                FullName = record["FullName"] as string,
                // We don't have a separate string ID column; reuse the numeric ID as a string if needed.
                PatientId = record["PatientId"].ToString(),
                ContactNumber = record["Phone"] as string,
                Address = record["Address"] as string,
                Gender = record["Gender"] as string,
                Age = record["Age"] is DBNull ? 0 : Convert.ToInt32(record["Age"])
            };
        }
    }
}


