using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityLibrary;
namespace AttendanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(102, "Khalid", "MCA");
            s.DisplayDetails();

            Console.ReadLine();
        }
    }
}
