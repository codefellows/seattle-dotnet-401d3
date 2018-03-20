using System;

namespace Class01Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CatchSingleException();

            string answer = MethodB();
        }

        static void CatchSingleException()
        {
            int milesDriven, gallonsOfGas, mpg;

            try
            {
                Console.WriteLine("Please enter the miles driven");
                milesDriven = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter gallons of gas purchased");

                gallonsOfGas = Convert.ToInt32(Console.ReadLine());

                mpg = milesDriven / gallonsOfGas;
            }
            catch (Exception e)
            {
                mpg = 0;
                Console.WriteLine(e.Message);

                throw;
            }
        }
        
        static string MethodB()
        {
            return "Phil";
        }

        public static void CatchDoubleException()
        {
            // Point of this exerise is to show that you will get an error 
            // for both dividing by zero, and puttng 
            // an item in an index within an array that does not exist. 

            // We can get more specific on the types of errors we want to catch. 
            // There is more than just generic Exception

      
            int num = 13, denom = 0, result;
            int[] array = { 22, 33, 44 };
            try
            {
                result = num / denom;
                result = array[num];
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine("We are in the first catch block");
                Console.WriteLine(error.Message);
                throw;
            }
            catch (IndexOutOfRangeException error)
            {
                Console.WriteLine("We are in the second catch block");
                Console.WriteLine(error.Message);


            }

        }
    }
}
