using Class11Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class11Demo.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, string color)
        {
            //List<string> myList = new List<string>() { "German Shepard", "Great Dane", "Border Collie", "Beagle", "HotDog" };

            return RedirectToAction("Students", new { name, color });

            // return View(myList);
        }

        public ViewResult Students(string name, string color)
        {
            //Student students = new Student();

            Student students = Student.GetStudent(name, "Dotnet", 4.1, color);
            Student students1 = Student.GetStudent("Brent", "Crazy", 0.7, "blue");
            Student students2= Student.GetStudent("Peter", "Dance", 3.5, "pink");



            List<Student> myStudents = new List<Student> { students, students1, students2 };
            return View(myStudents);
        }
    }
}
