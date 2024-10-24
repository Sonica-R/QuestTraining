﻿using PatientAndDoctorMangement.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAndDoctorMangement
{
    class PatientAndDoctorManagement
    {
        private SqlConnection _conn;
        public PatientAndDoctorManagement()
        {
            _conn = new SqlConnection(CommonRepos.connStr);
        }
        public void CreatePatientsTable()
        {
            EnsureConnectionIsOpen();
            var createPatientsTable = @"CREATE TABLE PATIENTS
                                        ID INT PRIMARY KEY IDENTITY(1, 1) UNIQUE,
                                        PatientName VARCHAR(100),
                                        Age INT,
                                        Gender VARCHAR(10),
                                        MedicalCondition VARCHAR(200)";

            var command1 = new SqlCommand(createPatientsTable, _conn);
            command1.ExecuteNonQuery();
        }
        public void AddPatientDetails()
        {
            EnsureConnectionIsOpen();
            //var connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sonic\OneDrive\Documents\QuestDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            //var conn = new SqlConnection(connStr);
            //conn.Open();

            /* var patients = new List<Data.Patients>
             {
                 new Data.Patients
                 {
                     PatientName = "John Doe",
                     Age = 30,
                     Gender = "Male",
                     MedicalCondition = "Hypertension"
                 },
                 new Data.Patients
                 {
                     PatientName = "Jane Smith",
                     Age = 25,
                     Gender = "Female",
                     MedicalCondition = "Diabetes"
                 },
                 new Data.Patients
                 {
                     PatientName = "Alice Johnson",
                     Age = 40,
                     Gender = "Female",
                     MedicalCondition = "Asthma"
                 },
                 new Data.Patients
                 {
                     PatientName = "Robert Brown",
                     Age = 55,
                     Gender = "Male",
                     MedicalCondition = "Heart Disease"
                 },
                 new Data.Patients
                 {
                     PatientName = "Michael White",
                     Age = 22,
                     Gender = "Male",
                     MedicalCondition = "Anxiety"
                 }
             };*/

            Console.Write("Enter name of patient : ");
            var Patientname = Console.ReadLine();

            Console.Write("Enter age : ");
            var Age = int.Parse(Console.ReadLine());

            Console.Write("Enter gender : ");
            var Gender = Console.ReadLine();

            Console.Write("Enter medical condition : ");
            var MedicalCondition = Console.ReadLine();

            var insertPatients = @"INSERT INTO PATIENTS
                                (PatientName, Age, Gender, MedicalCondition)
                                VALUES
                                (@PatientName, @Age, @Gender, @MedicalCondition)";
            var command = new SqlCommand(insertPatients, _conn);
            command.Parameters.AddWithValue("@PatientName", Patientname);
            command.Parameters.AddWithValue("@Age", Age);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@MedicalCondition", @MedicalCondition);
            command.ExecuteNonQuery();
            //conn.Open();
            Console.WriteLine("Succesfully inserted");
        }
        public void DisplayPatients(int id)
        {
            EnsureConnectionIsOpen();

            var getPatients = @"SELECT * FROM PATIENTS WHERE ID = @id";
            var command = new SqlCommand(getPatients, _conn);
            command.ExecuteNonQuery();
        }
        public void UpdatePatients(string medicCondition, int id)
        {
            EnsureConnectionIsOpen();

            var updatePatients = @"UPDATE PATIENTS SET MedicalCondition = @MedicalCondition WHERE ID = @id";
            var command = new SqlCommand(updatePatients, _conn);
            command.ExecuteNonQuery();
            Console.WriteLine("Successfully updated");
        }

        //Doctors Repos
        public void CreateDoctorsTable()
        {
            EnsureConnectionIsOpen();
            var CreateDoctorsTable = @"CREATE TABLE DOCTORS
                                       ID INT PRIMARY KEY IDENTITY(101, 1) UNIQUE,
                                       DoctorName VARCHAR(100),
                                       Specialization VARCHAR(100),
                                       PatientID INT IDENTITY(1, 1)";

            var command2 = new SqlCommand(CreateDoctorsTable, _conn);
            command2.ExecuteNonQuery();
        }
        public void AddDoctorDetails()
        {
            EnsureConnectionIsOpen();

            /*var doctors = new List<Data.Doctors>
            {
            new Data.Doctors
            {
                DoctorName = "Dr. Alice Smith",
                Specialization = "Cardiology"
            },
            new Data.Doctors
            {
                DoctorName = "Dr. John Doe",
                Specialization = "Dermatology"
            },
            new Data.Doctors
            {
                DoctorName = "Dr. Emily Johnson",
                Specialization = "Pediatrics"
            },
            new Data.Doctors
            {
                DoctorName = "Dr. Michael Brown",
                Specialization = "Orthopedics"
            },
            new Data.Doctors
            {
                DoctorName = "Dr. Sarah Davis",
                Specialization = "Neurology"
            }
            };*/
            Console.Write("Enter name of doctor : ");
            var DoctorName = Console.ReadLine();

            Console.Write("Enter specialization :");
            var Specialitization = Console.ReadLine();

            var insertDoctors = @"INSERT INTO DOCTORS
                                 (DoctorName, Specialization) VALUES
                                 (@DoctorName, @Specialization)";
            var command = new SqlCommand(insertDoctors, _conn);
            command.Parameters.AddWithValue("@DoctorName", DoctorName);
            command.Parameters.AddWithValue("@Specialization", Specialitization);
            command.ExecuteNonQuery();
            Console.WriteLine("Successfully inserted");
        }

        public void DisplayDoctors(int id)
        {
            EnsureConnectionIsOpen();

            var getDoctors = @"SELECT * FROM DOCTORS WHERE ID = @id";
            var command = new SqlCommand(getDoctors, _conn);
            command.ExecuteNonQuery();
        }
        public void UpdateDoctors(string specialization, int id)
        {
            EnsureConnectionIsOpen();
            var updateDoctors = @"UPDATE DOCTORS SET Specialization = @specialtization WHERE ID = @id";
            var command = new SqlCommand(updateDoctors, _conn);
            command.ExecuteNonQuery();
            Console.WriteLine("Successfully updated");
        }

        public void DeletePatient(int id)
        {
            EnsureConnectionIsOpen();
            var deletePatient = @"DELETE FROM PATIENTS WHERE ID = @id";
            var command = new SqlCommand(deletePatient, _conn);
            command.ExecuteNonQuery();
            Console.WriteLine("Successfully deleted");
        }

        public void DeleteDoctor(int id)
        {
            EnsureConnectionIsOpen();
            var deleteDoctor = @"DELETE FROM DOCTORS WHERE ID = @ id";
            var command = new SqlCommand(deleteDoctor, _conn);
            command.ExecuteNonQuery();
            Console.WriteLine("Succesfully deleted");
        }
        private void EnsureConnectionIsOpen()
        {
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }
        }
    }
}