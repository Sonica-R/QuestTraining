using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PatientsFunction
{



    internal class Program
    {
        static List<Dictionary<string, string>> patients = new List<Dictionary<string, string>>();

        static void AddPatient(List<Dictionary<string, string>> patients)
        {
            var patient = new Dictionary<string, string>();
            Console.WriteLine("Enter patient name: ");
            patient.Add("name", Console.ReadLine());

            Console.WriteLine("Enter age: ");
            patient.Add("age", Console.ReadLine());

            Console.WriteLine("Enter symptoms: ");
            patient.Add("symptoms", Console.ReadLine());

            var id = Guid.NewGuid().ToString();
            patient.Add("id", id);
            Console.WriteLine(id);
            //patient.Add("id", Guid.NewGuid().ToString());
            patients.Add(patient);
        }



        static void GetPatientById(List<Dictionary<string, string>> patients)
        {
            Console.WriteLine("Enetr ID: ");
            var id = Console.ReadLine();

            foreach (var patient in patients)
            {
                if (patient["id"] == id)
                {
                    Console.WriteLine("Name:" + patient["name"]);
                    Console.WriteLine("Age:" + patient["age"]);
                    Console.WriteLine("Symptoms:" + patient["symptoms"]);
                }
            }
        }

        static void GetPatientBySymptom(List<Dictionary<string, string>> patients)
        {
            Console.WriteLine("Enter name: ");
            var symptom = Console.ReadLine();

            foreach (var patient in patients)
            {
                if (patient["symptoms"] == symptom)
                {
                    Console.WriteLine("Name:" + patient["name"]);
                    Console.WriteLine("Age:" + patient["age"]);
                    Console.WriteLine("Symptoms:" + patient["symptoms"]);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Get the datas of the patients");
            while (true)
            {
                Console.WriteLine("1 : Add Patient");
                Console.WriteLine("2 : Search patient by ID");
                Console.WriteLine("3 : Search patient by symptom");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddPatient(patients);
                        break;
                    case "2":
                        GetPatientById(patients);
                        break;
                    case "3":
                        GetPatientBySymptom(patients);
                        break;

                }

            }
        }
    }
}


        
