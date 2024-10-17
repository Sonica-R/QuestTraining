using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sclStd = new SchoolStudent()
            {
                Name = "SclUser",
                Email = "scluser@mail.com",
                SchoolName = "XYZ"
            };

            var clgStd = new CollegeStudent()
            {
                Name = "NewUser",
                Email = "newuser@mail.com",
                CollegeName = "ABC"

            };


        }
    }
}
