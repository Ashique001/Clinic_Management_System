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
                       "SELECT Id, FullName, PatientId, ContactNumber, Address, Gender, Age FROM Patients"))
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
                       "INSERT INTO Patients (FullName, PatientId, ContactNumber, Address, Gender, Age) " +
                       "VALUES (@FullName, @PatientId, @ContactNumber, @Address, @Gender, @Age)"))
            {
                cmd.Parameters.Add(new SqlParameter("@FullName", SqlDbType.NVarChar, 150) { Value = patient.FullName });
                cmd.Parameters.Add(new SqlParameter("@PatientId", SqlDbType.NVarChar, 50) { Value = patient.PatientId });
                cmd.Parameters.Add(new SqlParameter("@ContactNumber", SqlDbType.NVarChar, 30) { Value = patient.ContactNumber });
                cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 200) { Value = (object)patient.Address ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@Gender", SqlDbType.NVarChar, 20) { Value = (object)patient.Gender ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@Age", SqlDbType.Int) { Value = patient.Age });

                cmd.ExecuteNonQuery();
            }
        }

        public void DeletePatientById(int id)
        {
            using (var connection = Database.GetOpenConnection())
            using (var cmd = Database.CreateCommand(connection,
                       "DELETE FROM Patients WHERE Id = @Id"))
            {
                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = id });
                cmd.ExecuteNonQuery();
            }
        }

        private static Patient MapPatient(IDataRecord record)
        {
            return new Patient
            {
                Id = record["Id"] is DBNull ? 0 : Convert.ToInt32(record["Id"]),
                FullName = record["FullName"] as string,
                PatientId = record["PatientId"] as string,
                ContactNumber = record["ContactNumber"] as string,
                Address = record["Address"] as string,
                Gender = record["Gender"] as string,
                Age = record["Age"] is DBNull ? 0 : Convert.ToInt32(record["Age"])
            };
        }
    }
}


