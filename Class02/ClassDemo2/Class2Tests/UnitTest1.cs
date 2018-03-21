using System;
using Xunit;
using ClassDemo2;
using static ClassDemo2.Program;

namespace Class2Tests
{
   public class UnitTest1
    {
        //[Fact]
        //public void CanReturn1()
        //{
        //    Assert.Equal("1", Convert(1));
        //}

        //[Fact]
        //public void CanReturn2()
        //{
        //    Assert.Equal("2", Convert(2));
        //}

        //[Theory]
        //[InlineData(3)]
        //[InlineData(6)]

        //public void CanReturnFizz(int value)
        //{
        //    Assert.Equal("Fizz", Convert(value));
        //}

        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(3, "Fizz")]
        [InlineData(236, "236")]
        [InlineData(1, "1")]
        [InlineData(-3, "Fizz")]
        public void CanFizzBuzz(int value, string expected)
        {
            Assert.Equal(expected, Convert(value));
        }

    }
}
