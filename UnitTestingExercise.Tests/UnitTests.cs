using System;
using Xunit;
using Xunit.Sdk;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(5, 5, 5, 15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 0)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var tester = new UnitTestMethods();
            //Act
            var actual = tester.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(5, 4, 20)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var tester = new UnitTestMethods();
            //Act
            var actual = tester.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(20, 5, 4)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 5, 4, 10, 50, 99 }, 99)]
        public void GetMax(int[] numbers, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.GetMax(numbers);
            //Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(new int[] { 2, 5, 8, 9}, 2)]
           public void GetMin(int[] numbers, int expected)
           {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.GetMin(numbers);
            //Assert
            Assert.Equal(expected, actual);

           }
         
    }
}       

       

            
            
    

