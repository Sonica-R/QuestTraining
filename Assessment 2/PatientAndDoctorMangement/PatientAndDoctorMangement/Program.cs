using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PatientAndDoctorMangement.Program;

namespace PatientAndDoctorMangement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new PatientAndDoctorManagement();
            data.CreatePatientsTable();
            data.CreateDoctorsTable();
            data.AddDoctorDetails();
            data.AddPatientDetails();
            data.DisplayDoctors(2);
            data.DisplayPatients(2);
            data.DeletePatient(1);
            data.DeleteDoctor(2);
        }
    }
}
