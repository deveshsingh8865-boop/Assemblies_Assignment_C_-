using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityLibrary;
namespace ExaminationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(101, "Rahul", "MCA");
            s.DisplayDetails();

            Console.ReadLine();
        }
    }
}
