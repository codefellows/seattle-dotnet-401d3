using System;
using System.Threading;

namespace Class09Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Thread thread1 = new Thread(CountToN);
            thread1.Start(50);

            Thread thread2 = new Thread(CountToN);
            thread2.Start(75);

            thread1.Join();
            thread2.Join();


        }

        public static void CountToN(object x)
        {
            int n = (int)x;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i+1);
            }
        }
    }
}
