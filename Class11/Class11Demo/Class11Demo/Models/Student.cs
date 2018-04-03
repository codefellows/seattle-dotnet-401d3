using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class11Demo.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public double GPA { get; set; }

        public string Color { get; set; }

        public static Student GetStudent(string name, string cl, double gpa, string color )
        {
            Student student = new Student() { Name = name, Class = cl, GPA = gpa, Color = color };
            return student;
        }
    }
}
