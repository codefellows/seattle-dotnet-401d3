using System;
using System.Threading;
using System.Collections.Generic;

/*
 Frog Racing: 
Let's make a little simulator for a frog race. The idea is that there are multiple frogs that are 
lined up and competing against each other to jump across a finish line. In order to finish the race, 
a frog needs to jump a total of 10 times. 
Each frog runs on it's own thread, and we'll have three total. 
To do this, create a method that matches the ParameterizedThreadStart delegate. 
As input, the object that is passed in will be the frog's number. Inside of that method, 
use a loop to print out "Frog #X Jumped" and then use Thread.Sleep and Random object to have the 
frog/thread sleep for a random amount of time between 0 and 1 seconds.
When the frog/thread has jumped ten times and the loop ends, print out "Frog #X finished." 

Start the frog race by creating three separate threads and starting them all with different numbers. 
wait for each thread to finish using the Join method.
     */

namespace FrogRace
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;

            while (playing) //game loop
            {
                Console.WriteLine("Welcome to Medievil Frog Racer. Let the race begin!");
                Console.WriteLine(@"The frog says, ""Ribbit""");

                int n = UserNumber();
                SpinUpThreadPartTwo(n);

                Console.WriteLine(Winner);
                Console.WriteLine("Dost thou wanteth to playeth again, sire or m'lady?");
                Console.WriteLine("I require from thee a meager Y (for Aye) or anything else (for Nay)");

                // 'y' or 'Y' or 'Yes' or 'yes' or 'yEs' or even 'yippee' will work
                if (!Console.ReadLine().ToUpper().StartsWith('Y'))
                {
                    playing = false;
                }
            }
        }

        /// <summary>
        /// determines when a frog jumps
        /// </summary>
        /// <param name="x">object</param>
        public static void FrogLogic(object x)
        {
            // makes the frogID a int type
            int frogID = (int)x;

            // Create a instance of random
            Random random = new Random();
            
            // Write some text and sleep, then repeat that 9 more times
            // Each time it will sleep a random, different amount of milliseconds
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Frog #{frogID} jumped.");
                Thread.Sleep(random.Next(0, 1_001)); // 0 to 1 seconds
            }
            Console.WriteLine($"Frog {frogID} has finished.");
            if (Program.Winner.Length == 0)
            {
                Program.Winner = $"The winner was frog number {frogID}";
            }
        }

        public static string Winner = "";

        /// <summary>
        /// creates the threads, starts the threads and joins the threads
        /// </summary>
        /// <param name="numberOfFrogs">int type of desired number of frogs</param>
        public static void SpinUpThreadPartTwo(int numberOfFrogs)
        {
            List<Thread> threads = new List<Thread>();

            // Add thread instances and start them
            for (int i = 1; i <= numberOfFrogs; i++)
            {
                threads.Add(new Thread(FrogLogic));
                threads[i - 1].Start(i);
            }

            // Now, they've all been started, so we can join them
            // They will now operate "simultaneously"
            foreach (Thread thread in threads)
            {
                thread.Join();
            }
        }

        /// <summary>
        /// prompts the user to enter a desired number of frogs, validates that
        /// a number was entered
        /// </summary>
        /// <returns>int type of the users number request</returns>
        public static int UserNumber()
        {
            int num = 0;
            bool invalidEntry = false;
            for (int i = 0; i < 10 && !invalidEntry; i++)
            {
                try
                {
                    Console.WriteLine("Yo, bro, how many frogs dost thou wanteth????");
                    num = int.Parse(Console.ReadLine());
                    invalidEntry = true;
                }
                catch
                {
                    Console.WriteLine("That was not a valid number");
                }
            }           
            return num;
        }
    }
}