using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Tree
    {
        public Node Root { get; set; }

        public Tree(Node node)
        {
            Root = node;
        }
        public void InOrder(Node node)
        {

            if(node.LeftChild != null)
            {
                InOrder(node.LeftChild);
            }

            Console.WriteLine(node.Value);

            if(node.RightChild != null)
            {
                InOrder(node.RightChild);
            }

        }
    }
}
