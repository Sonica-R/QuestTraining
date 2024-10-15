using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            var s1 = new Student
            {
                Name = "Adi",
                Mark1 = 20,
                Mark2 = 25
            };

            var s2 = new Student
            {
                Name = "Ben",
                Mark1 = 25,
                Mark2 = 30
            };
            var s3 = new Student
            {
                Name = "Carlin",
                Mark1 = 20,
                Mark2 = 25
            };

            Student[] students = new Student[5];
            students[0] = s1;
            students[1] = s2;
            students[2] = s3;

            //var student4 = new Student
            //{
            //    Name = "Dev",
            //    Mark1 = 40,
            //    Mark2 = 45
            //};
            //var student5 = new Student
            //{
            //    Name = "Elsa",
            //    Mark1 = 30,
            //    Mark2 = 35
            //};

            foreach (var data in students)
            {
                int total = 0;
                if (data != null)
                {
                    // Console.WriteLine($"{data.Name} {data.Mark1} {data.Mark2}");
                    total += data.Mark1 + data.Mark2;
                    Console.WriteLine($"Name : {data.Name}, Total marks : {total}");
                }
            }
        }
    }
}
