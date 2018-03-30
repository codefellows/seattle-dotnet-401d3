using System;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node0 = new Node() { Value = 4};

            Node node1 = new Node() { Value = 8 };


            Stack stack = new Stack(node0);
            stack.Push(node1);

            Console.WriteLine(stack.Peek().Value);
        }
    }
}
