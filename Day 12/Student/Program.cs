using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
                var sManage = new StudentManage();

                while (true)
                {
                    Console.WriteLine("1. Add student ");
                    Console.WriteLine("2. Search student by regId");
                    Console.WriteLine("3. Update student detail");
                    Console.WriteLine("4. Delete student entry");
                    Console.WriteLine("5. Add Subject and Marks");

                var option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            var student = GetStudent();
                            sManage.Add(student);
                            break;
                        case "2":
                            Console.WriteLine("Enter student id to search: ");
                            var studentId = Console.ReadLine();
                            sManage.Search(studentId);
                            break;
                        case "3":
                            var studentToUpdate = GetStudent();
                            sManage.Update
                            (studentToUpdate.StudentId,
                            studentToUpdate.StudentName,
                            studentToUpdate.Class);
                            break;
                        case "4":
                            Console.WriteLine("Enter the student id to delete:");
                            var studToDelete = Console.ReadLine();
                            sManage.Delete(studToDelete);
                            break;
                    case "5":
                        Console.Write("Enter the Reg number to add subject: ");
                        var regNumber = Console.ReadLine();
                        Console.Write("Enter the subject name: ");
                        var subject = Console.ReadLine();
                        Console.Write("Enter the marks: ");
                        var marks = int.Parse(Console.ReadLine());
                        sManager.AddSubject(regNumber, subject, marks);
                        break;
                    default:
                            Console.WriteLine("INVALID");
                            break;
                    }
                }
        }

        private static Student GetStudent()
        {
            Student stud = new Student();

            Console.WriteLine("Enter student name : ");
            stud.StudentName = Console.ReadLine();

            Console.WriteLine("Enter the student id");
            stud.StudentId = Console.ReadLine();

            Console.WriteLine("Enter the class and division");
            stud.Class = Console.ReadLine();

            Console.Write("Enter Subject Name: ");
            stud.Subject = Console.ReadLine();

            Console.Write("Enter Marks obtained for the Subject: ");
            stud.Mark = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter tht total marks:");
            stud.TotalMarks = Console.ReadLine();

            return stud;
        }
    }
}
