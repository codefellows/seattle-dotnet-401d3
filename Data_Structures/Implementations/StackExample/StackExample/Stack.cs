using System;
using System.Collections.Generic;
using System.Text;

namespace StackExample
{
   public class Stack
    {
        public Node Head { get; set; }
        public Stack(Node node)
        {
            Head = node;
        }

        public void Push(Node node)
        {
            node.Next = Head;
            Head = node;
        }

        public Node Peek() => Head;
    }
}
