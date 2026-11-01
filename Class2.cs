using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class Student
    {
        public int RollNo;
        public string Name;
        public string Course;

        public Student(int rollno, string name, string course)
        {
            RollNo = rollno;
            Name = name;
            Course = course;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Student details: ");
            Console.WriteLine("Roll no: "+ RollNo);
            Console.WriteLine("Name : "+ Name);
            Console.WriteLine("Course: "+ Course);
        }
    }
}
