using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    internal class Student
    {
        public string Name;
        private int age;

        public int Age { 
            get 
            { 
                return age;
            } 
            set 
            { 
                if(value > 0 && value < 60)
                {
                    value = age;
                }
            } 
        }
    }
}
