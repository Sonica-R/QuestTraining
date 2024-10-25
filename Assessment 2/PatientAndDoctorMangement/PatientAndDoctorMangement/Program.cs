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
            var patient = new PatientRepository();
            patient.AddPatientDetails(new Data.Patients { PatientName = "Alby", Age = 35, Gender = "Male", MedicalCondition = "Fever"});
            patient.DisplayPatients(2);
            patient.DeletePatient(1);

            var doctor = new DoctorsRepository();
            doctor.AddDoctorDetails(new Data.Doctors { DoctorName = "Mr X", Specialization = "Ortho"});
            doctor.DisplayDoctors(2);
            doctor.DeleteDoctor(2);
        }
    }
}
