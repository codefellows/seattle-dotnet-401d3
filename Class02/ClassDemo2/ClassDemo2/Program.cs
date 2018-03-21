using System;

namespace ClassDemo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// The Convert Method takes in a number and changes it to a string for FizzBuzz
        /// </summary>
        /// <param name="number">the number we are outputting</param>
        /// <returns>Fizz/Buzz/FizzBuzz/or number provided</returns>
        public static string Convert(int number)
        {
            
            //If the number is divisible by 3 AND 5, then run this statemetn
            if (number % 3 == 0 && number % 5 == 0)
            {
               
                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
              // Amanda 3.20.18 - Added this code per Janine on 3.15
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                //TODO:
                return "Buzz";
            }
           
            return number.ToString();
        }
    }
}
