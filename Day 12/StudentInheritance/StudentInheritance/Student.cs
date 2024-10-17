using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInheritance
{
    internal class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    class SchoolStudent : Student
    {
        public string SchoolName { get; set; }
        public override string ToString()
        {
            return $"Name : {Name} Email :{Email} SchoolName : {SchoolName}";
        }
            
    }

    class CollegeStudent : SchoolStudent
    {
        public string CollegeName { get; set; }
        public override string ToString()
        {
            return $"Name : {Name} Email :{Email} CollegeName : {CollegeName}";
        }

    }
}
