using System;

namespace Class04Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Person amanda = new Person("Amanda", 50); // amanda is my object of the Person Class
            //Console.WriteLine(amanda.SayHello());

            //Person miya = new Person("Miya", 40);

            //miya.Dance();

            //amanda.Name = "Amanda"; // set 
            //string name = amanda.Name; // get;

            Person greg = new Person("Greg", 45) { Name = "Scott", Age = 28, EyeColor = "purple", HairColor = "yellow" };

            Console.WriteLine(greg.Name);
            Console.WriteLine(greg.Age);

            //miya.Name = "Miya";
            //miya.Age = 40;
            //miya.Height = 56;
            //miya.HairColor = "pink";


            Board game = new Board();

            Player player1 = new Player("Amanda", "X");
            Player player2 = new Player("Miya", "@");
            player1.MakeMark(game);


        }

        static void MyMethod()
        {
            Console.WriteLine("Hello!!!");
        }
    }
}
