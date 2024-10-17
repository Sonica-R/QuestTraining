using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student
    {
        public string Name;
        public int Mark1;
        public int Mark2;

        public void DisplayMarks()
        {
            Console.WriteLine(Mark1 + Mark2);
        }
    }
}
