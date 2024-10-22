using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    internal class Program
    {
        static class AppSettings
        {
            public static string Version { get; } = "1. 0. 0";
            public static string ProjectURL { get; set; } = "https://website.com";
            public static string DefaultEngine { get; set; } = "Google";
        }
        static void Main(string[] args)
        {
            // AppSettings.Version = "2. 0. 0";
            // This is not not possible as it is not having any setter function

            AppSettings.DefaultEngine = "Bingo";
            //Can be set as there is sette and also this modification can only be done with the class aname and not by creating an object        }
    }
}
