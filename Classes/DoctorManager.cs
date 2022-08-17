using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class DoctorManager
    {
        public static List<Doctor> Doctors { get; private set; } = new List<Doctor>();
        public static void getPatientsList()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\s.mohammadi\VSProjects\HospitalV1\HospitalV1\HospitalDatabase.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string commandString = "SELECT * FROM Doctors";

                SqlCommand command = new SqlCommand(commandString, connection);

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Doctors.Add(new Doctor(Convert.ToInt32(dataReader.GetValue(0)), Convert.ToString(dataReader.GetValue(1)), Convert.ToString(dataReader.GetValue(2)), Convert.ToString(dataReader.GetValue(3))));

                }
            }
        }
    }
}
