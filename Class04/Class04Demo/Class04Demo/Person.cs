using System;
using System.Collections.Generic;
using System.Text;

namespace Class04Demo
{
    public class Person
    {
        public Person(string name, int ages)
        {
            Name = name;
            age = ages;
        }
        //public Person()
        //{

        //}


        public int Height { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }

        private string name; // backing store
        private int age;
        //  public string Name { get; set; }

        public string FavoriteColor { get; private set; } = "Red";

        public int Age
        {
            get
            {
                return age;
            }
           set
            {
                if (age < 21)
                {
                    Console.WriteLine($"{Name} is not old enough");
                }
                else
                {
                    age = value;
                }
                //age = value;
            }
        }

        private int number;

        public int Number
        {
            get
            {
                return number++;
            }

        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string SayHello()
        {
            return "Hello!!";
        }

        public string SayGoodbye()
        {
            return "Goodbye";

        }

        public string Dance()
        {
            return "Chicken Dance";
        }




    }
}
