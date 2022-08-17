using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    static class PatientManager
    {
        public static List<Patient> Patients { get; private set; } = new List<Patient>();
        public static void getPatientsList()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\s.mohammadi\VSProjects\HospitalV1\HospitalV1\HospitalDatabase.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string commandString = "SELECT * FROM Patients";

                SqlCommand command = new SqlCommand(commandString, connection);

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Patient p = new Patient(Convert.ToInt32(dataReader.GetValue(0)) ,Convert.ToString(dataReader.GetValue(1)), Convert.ToInt32(dataReader.GetValue(2)), Convert.ToString(dataReader.GetValue(5)));

                }
            }
        }


    }
}
