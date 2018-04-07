using System;
using Xunit;
using StackExample;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanPeek()
        {
            //Arrange
            Node node = new Node() { Value = 4};
            Node node2 = new Node() { Value = 8 };
            Node node3 = new Node() { Value = 15 };
            Node node4 = new Node() { Value = 16};
            Node node5 = new Node() { Value = 23 };
            Node node6 = new Node() { Value = 42 };

            Stack stack = new Stack(node);
            stack.Push(node2);
            stack.Push(node3);
            stack.Push(node4);
            stack.Push(node5);
            stack.Push(node6);

            //ACt

            //Assert

            Assert.Equal(42, stack.Peek().Value);
        }
    }
}
