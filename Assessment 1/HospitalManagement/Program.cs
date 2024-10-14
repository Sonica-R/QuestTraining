using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    internal class Program
    {
        static List<string> DeptList = new List<string>();
        static List<Dictionary<string, string>> DoctorsList = new List<Dictionary<string, string>>();
        static List<Dictionary<string, string>> PatientsList = new List<Dictionary<string, string>>();

        static void AddDepartments(List<string> DeptList)
        {
            Console.Write("Enter the number of depatments to be added :");
            var numOfDept = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfDept; i++)
            {
                var depName = Console.ReadLine();
                DeptList.Add(depName);
            }
            Console.WriteLine("Departmenst added are :");
            foreach (var data in DeptList)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine();

        }

        static void AddDoctors(List<Dictionary<string, string>> DoctorsList)
        {
            Console.Write("Enter doctor name :");
            var docName = Console.ReadLine().Trim();
            Console.Write("Enter department name :");
            var docDept = Console.ReadLine().Trim();
            Dictionary<string, string> DocDetails = new Dictionary<string, string>()
            {
                { "DoctorName" , docName},
                { "DeptOfDoctor" , docDept}
            };
            DoctorsList.Add(DocDetails);
        }

        static void AddPatients(List<Dictionary<string, string>> PatientsList)
        {
            Console.Write("Enter patients name : ");
            string patientName = Console.ReadLine();
            Console.Write("Enter doctor's name : ");
            string docName = Console.ReadLine();
            Dictionary<string, string> Patient = new Dictionary<string, string>()
            {
                { "Patients Name" , patientName},
                { "DeptOfDoctor" , docName}
            };

            PatientsList.Add(Patient);
        }

        static void SearchDoctors(List<Dictionary<string, string>> DoctorsList)
        {
            Console.Write("Enter the doctor's name to be serached : ");
            var searchName = Console.ReadLine();
            foreach (var data in DoctorsList)
            {
                foreach (var item in data)
                {
                    if (item.Value == searchName)
                    {
                        Console.WriteLine("Doctor's name exist");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Doesn't exist");
                        break;
                    }
                    

                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 : Add Departments");
                Console.WriteLine("2 : Add Doctors");
                Console.WriteLine("3 : Add Patients");
                Console.WriteLine("4 : Search for doctors");
                Console.WriteLine("5 : Search for patients");
                Console.WriteLine("6 : Display information about departments");
                Console.WriteLine("7 : Display information about doctors");
                Console.WriteLine("8 : Display information about patients");
                Console.WriteLine();
                Console.Write("Enter you choice :");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if ((choice >= 1) && (choice < 9))
                {
                    switch (choice)
                    {
                        case 1:
                            AddDepartments(DeptList);
                            break;
                        case 2:
                            AddDoctors(DoctorsList);
                            break;
                        case 3:
                            AddPatients(PatientsList);
                            break;
                        case 4:
                            SearchDoctors(DoctorsList);
                            break;
                            //case 5:
                            //    SearchPatient();
                            //    break;
                            //case 6:
                            //    DisplayDeptInfo();
                            //    break;
                            //case 7:
                            //    DisplayDoctorInfo();
                            //    break;
                            //case 8:
                            //    DisplayPatientInfo();
                            //    break;
                    }
                }
                else
                {
                    break;
                }
            }

        }
    }
}
