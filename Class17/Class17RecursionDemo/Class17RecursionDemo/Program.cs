using System;

namespace Class17RecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
         //   Console.WriteLine("Hello World!");

           //Console.WriteLine(IterativeFactorial((5)));

        Console.WriteLine(EvilRecursive(5));
        }


        static long IterativeFactorial(int n)
        {
            long total = 1;

            //if (n == 0)
            //{
            //    return 1;
            //}

            for (int i = n; i > 0; i--)
            {
               total *= i;
            }

            return total;

        }

        static long EvilRecursive(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            long number = n * EvilRecursive(n - 1);
            Console.WriteLine($"{n} *");

            return number;
        }
        


    }
}
