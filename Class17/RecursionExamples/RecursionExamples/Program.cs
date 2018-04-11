using System;

namespace RecursionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             long x = FactorialExample(5);
         //   long one = Fibonacci(7);
           // long two = Fib(7);

           // Console.WriteLine(one);
            //Console.WriteLine(two);

        }

        /// <summary>
        /// Recursive Factorial
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static long FactorialExample(int n)
        {
            if (n <= 0)
            {
                return 1;
            }
          
            long num = n * FactorialExample(n - 1);
           //output the number after it has gone through the callstack
            Console.WriteLine($"{n} * ");
            return num;
        }

        /// <summary>
        /// NonRecursive Factorial
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public long Factorial(int n)
        {
            if (n == 0)
                return 1;
            long value = 1;
            for (int i = n; i > 0; i--)
            {
                value *= i;
            }
            return value;
        }

        /// <summary>
        /// Recursive Fibonacci 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int Fibonacci(int n)
        {
            //Easier to understand, but a bit more slow. 
            // in order to calculate Fibonacci(6) you have to know (5) and (4).
            // and so on...
            if (n <= 1)
                return n;
            
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        /// <summary>
        /// Non recursive fib iterative
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long Fib(int n)
        {
            if (n < 2)
                return n;
            long[] f = new long[n + 1];
            f[0] = 0;
            f[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }
            return f[n];
        }
    }
}
