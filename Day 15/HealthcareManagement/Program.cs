using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareManagement
{
    class Patients
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MedicalCondition { get; set; }
    }

    class Appointment
    {
        public int ID { get; set; }
        public int PatientID { get; set; }
        public string DoctorName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentType { get; set; }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            var patients = new List<Patients>
            { 

                new Patients { ID = 1, Name = "John Smith", Age = 45, Gender = "Male", MedicalCondition = "Hypertension" },
                new Patients { ID = 2, Name = "Emily Davis", Age = 32, Gender = "Female", MedicalCondition = "Diabetes" },
                new Patients { ID = 3, Name = "Michael Johnson", Age = 60, Gender = "Male", MedicalCondition = "Heart Disease" },
                new Patients { ID = 4, Name = "Sarah Miller", Age = 28, Gender = "Female", MedicalCondition = "Diabetes"},
                new Patients { ID = 5, Name = "David Brown", Age = 50, Gender = "Male", MedicalCondition = "Hypertension" },
            };

            var appointments = new List<Appointment>
            {
                new Appointment
                {
                    ID = 1,
                    PatientID = 1,
                    DoctorName = "Dr. Alice Green",
                    AppointmentDate = new DateTime(2024, 10, 25),
                    AppointmentType = "Check-up"
                },
                new Appointment
                {
                    ID = 2,
                    PatientID = 2,
                    DoctorName = "Dr. Bob White",
                    AppointmentDate = new DateTime(2024, 10, 29),
                    AppointmentType = "Consultation"
                },
                new Appointment
                {
                    ID = 3,
                    PatientID = 3,
                    DoctorName = "Dr. Charlie Blue",
                    AppointmentDate = new DateTime(2024, 10, 28),
                    AppointmentType = "Follow-up"
                },
                new Appointment
                {
                    ID = 4,
                    PatientID = 4,
                    DoctorName = "Dr. Denise Yellow",
                    AppointmentDate = new DateTime(2024, 10, 30),
                    AppointmentType = "Check-up"
                },
                new Appointment
                {
                    ID = 5,
                    PatientID = 5,
                    DoctorName = "Dr. Eric Black",
                    AppointmentDate = new DateTime(2024, 11, 12),
                    AppointmentType = "Consultation"
                }
            };

            //Q1
            Console.WriteLine("Patient Details :");
            var details = appointments
                .Where(a => a.AppointmentDate <= DateTime.Now.AddDays(7))
                .Join(
                    patients,
                    a => a.ID, //Appointment ID
                    p => p.ID, //Patient ID
                    (a, p) => new
                    {
                        Name = p.Name,
                        Age = p.Age,
                        MedicalCondition = p.MedicalCondition
                    }
                );
            foreach (var item in details)
            {
                Console.WriteLine($"Name:{item.Name}, Age:{item.Age}, Medicalcondition:{item.MedicalCondition}");
            }
            Console.WriteLine("\nMedical Condition :");

            //Q2
            var res = patients.GroupBy(x => x.MedicalCondition).ToList();
            foreach (var group in res)
            {
                Console.WriteLine($"Medical Condition: {group.Key}, Count: {group.Count()}");
                foreach (var item in group)
                {
                    Console.WriteLine($"Patient name : {item.Name} Patient ID :{item.ID}");
                }
                Console.WriteLine();
            }
        }
    }
}
