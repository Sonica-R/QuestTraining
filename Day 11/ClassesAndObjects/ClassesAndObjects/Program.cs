using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    /*class Student
    {
        public string Name;

        public void DisplayName()
        {
            Console.WriteLine("Hi" + Name);
        }
    }*/

    /* class Employee
       {
         public string FirstName;
         public string LastName;
         public int Salary;

         public void DisplayAnnualSalary()
         {
             Console.WriteLine($"Annual Salary : {Salary * 12}");
         }
       }*/

    class Student
    {
        public string Name;
        public float Mark1;
        public float Mark2;
        public float Mark3;
        public float Total;

        public void FindTotalMarks()
        {
            Total = Mark1 + Mark2 + Mark3;
            Console.WriteLine($"Total marks : {Total}");
        }

        public void FindAvgMarks()
        {
            float avg = Total / 3;
            Console.WriteLine($"Average marks : {avg}");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student();
            student1.Name = "Adi";
            student1.Mark1 = 20.5f;
            student1.Mark2 = 30;
            student1.Mark3 = 35;

            student1.FindTotalMarks();
            student1.FindAvgMarks();


            /*Student s = new Student();
            s.Name = "Anu";

            Student s1 = new Student();
            s1.Name = "Birla";*/

            /*Employee e1 = new Employee();
            e1.FirstName = "Job";
            e1.LastName = "Dani";
            e1.Salary = 10_000;

            e1.DisplayAnnualSalary();*/

        }
    }
}




      
