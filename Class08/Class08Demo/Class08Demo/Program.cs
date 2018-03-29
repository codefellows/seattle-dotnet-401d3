using System;
using System.Collections.Generic;
using System.Linq;

namespace Class08Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QueryExample();
        }

        static void QueryExample()
        {
            List<string> list = new List<string>();

            list.Add("Kevin");
            list.Add("Josh");
            list.Add("Brent");
            list.Add("Tiger");
            list.Add("Arthur");
            list.Add("Phil");
            list.Add("Miya");
            list.Add("Amanda");
            list.Add("Cat");

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            IEnumerable<string> filteredNames = from n in list
                                                where n.Length < 5
                                                select n;

            //foreach (string name in filteredNames)
            //{
            //    Console.WriteLine(name);

            //}

            IEnumerable<string> nextFilter = from name in filteredNames
                                             where name.Contains('a')
                                             select name;

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //foreach (string name in nextFilter)
            //{
            //    Console.WriteLine(name);

            //}


            List<string> typesOfBirds = new List<string>() {"cardinal","robin","big","seahawk","thunderbird", "toucan", "rio", "mockingbird", "angry" };

            IEnumerable<string> myQuery = from n in typesOfBirds
                                          where n.Contains('i')
                                          select n;

            var mybirds = typesOfBirds.Where(name => name.Contains('i'))
                                      .Where(name => name.Length <= 4);
                                                                           
    

            Console.WriteLine();
            Console.WriteLine();

            foreach (string item in myQuery)
            {

                Console.WriteLine(item);
            }


            Console.WriteLine();
            Console.WriteLine();
            

            foreach (var item in mybirds)
            {

                Console.WriteLine(item);
            }

        }
    }
}
