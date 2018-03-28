using System;
using System.Collections.Generic;

namespace ClassDemo7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //EnumExample();
            // CollectionsExample();

            CustomCollection();
        }

        static void EnumExample()
        {
            Days today = Days.Tuesday;
            int dayNumber = (int)today;

            Console.WriteLine(dayNumber);

            Days myDay = (Days)100;

            Console.WriteLine(myDay);


        }

        static void CollectionsExample()
        {
            //HashSet<string> myhash = new HashSet<string>();

            List<string> myList = new List<string>();
            myList.Add("Amanda");
            myList.Add("Miya");
            myList.Add("Kevin");
            myList.Add("Arthur");
            myList.Add("Tiger");
            myList.Add("Amanda");

            foreach (string student in myList)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Removing Amanda....");

            myList.Remove("Amanda");
            myList.RemoveAt(1);


            foreach (string student in myList)
            {
                Console.WriteLine(student);
            }

            if (myList.Contains("Amanda"))
            {
                Console.WriteLine("There is an Amanda");
            }



            Console.WriteLine();
            Console.WriteLine();

            List<string> cats = new List<string> { "Miss Kitty", "Josie", "Belle", "Felix", "Griffin", "Cheshire", "Figaro", "Oliver" };

            foreach (string cat in cats)
            {
                Console.WriteLine($"Cat Name: {cat}");
            }

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            myDictionary.Add(1, "One");
            myDictionary.Add(2, "two");
            myDictionary.Add(3, "three");

            foreach ((int key, string value) in myDictionary)
            {
                Console.WriteLine($"Key: {key}, Value: {value}");
            }

            List<Person> peopleList = new List<Person>();

            Person pp = new Person { Name = "Amanda", Age = 50 };
            if (pp.Age > 18)
            {
                peopleList.Add(pp);
            }

        }

        static void CustomCollection()
        {
            NumberList<int> mynumbers = new NumberList<int>();

            mynumbers.Add(1);
            mynumbers.Add(2);
            mynumbers.Add(3);
            mynumbers.Add(4);
            mynumbers.Add(5);

            mynumbers.Add(11);
            mynumbers.Add(12);
            mynumbers.Add(13);
            mynumbers.Add(14);
            mynumbers.Add(15);

            mynumbers.Add(20);


            foreach (int number in mynumbers)
            {
                Console.WriteLine(number);

            }

            NumberList<int> nummbers = new NumberList<int> { 4, 8, 15, 16, 23, 42 };

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            foreach (int number in nummbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
