using System;

namespace ClassDemo06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Employee e = new Employee();
            e.Name = "Amanda";

            Robot r = new Robot();
            r.Name = "Rosie";

            Car car = new Car();

            Student student = new Student();

            car.BuyCar(student);

            car.Drive(r);
           // car.Drive(student);
            car.Drive(e);

            if (r is IDrive)
            {

            }

            IDrive drive = new Robot();

            Robot myRobot = new Robot();
            drive = myRobot;
        }
    }
}
