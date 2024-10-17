using System;
using System.Collections.Generic;

namespace Student
{
    class StudentManage
    {
        private List<Student> students = new List<Student>();
        public void Add(Student stud)
        {
            if (GetStudentById(stud.StudentId) != null)
            {
                Console.WriteLine("Student already exists");
                return;
            }

            students.Add(stud);
            Console.WriteLine("Added successfully");
        }
        public void Search(string StudentId)
        {
            var stud = GetStudentById(StudentId);
            if(stud != null)
            {
                Console.WriteLine("Student data found !!");
                Console.WriteLine(stud);
            }
            else
            {
                Console.WriteLine("Student not found");
            }

        }

        public void Update(string StudentId, string Name, string Class, string Subject, int Mark)
        {
            var studID = GetStudentById(StudentId);
            if (studID == null)
            {
                Console.WriteLine("Not found");
                return;
            }

            studID.Class = Class;
            studID.StudentName = Name;
            studID.SubjecT = Subject;
            studID.Mark = Mark;
            Console.WriteLine("Updated successfully");
        }

        public void Delete(string StudentId)
        {
            var studID = GetStudentById(StudentId);
            if (studID == null)
            {
                Console.WriteLine("Not found");
                return;
            }

            students.Remove(studID);
            Console.WriteLine("Deleted successfully");
        }

        private Student GetStudentById(string StudentId)
        {
            foreach (var id in students)
            {
                if (id.StudentId == StudentId)
                {
                    return id;
                }
            }
            return null;
        }

    }
}
