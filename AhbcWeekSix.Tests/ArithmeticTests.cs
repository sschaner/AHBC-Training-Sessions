using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AhbcWeekSix.Tests
{
    public class ArithmeticTests
    {
        // Happy path
        [Theory] // Label for the method that is used by Xunit
        [InlineData(2,3,5)]
        [InlineData(-2, -3, -5)]
        [InlineData(2000, 3000, 5000)]
        [InlineData(-2, 3, 1)]
        [InlineData(4, 0, 4)]
        public void TwoNumbersAreGiven_NumbersWillBeAddedTogether(int numberOne, int numberTwo, int result)
        {
            // Arrange - Object that we're testing
            ArithmeticHelper subject = new ArithmeticHelper();

            // Act - What action from that object
            int testTotal = subject.Sum(numberOne, numberTwo);

            // Assert
            Assert.Equal(result, testTotal);
        }

        // Happy path
        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(4, 3, 1)]
        [InlineData(-3, 3, -6)]
        [InlineData(10000, 5000, 5000)]
        [InlineData(-4, -4, 0)]
        [InlineData(0, 0, 0)]
        public void TwoNumbersAreGiven_NumbersWillBeSubtractedTogether(int numberOne, int numberTwo, int result)
        {
            // Arrange
            ArithmeticHelper subject = new ArithmeticHelper();

            // Act
            int testTotal = subject.Subtract(numberOne, numberTwo);

            // Asert
            Assert.Equal(result, testTotal);
        }

        // Sad path
        // We're ensuring an exception is thrown
        [Fact]
        public void TheSameNumberIsGivenTwice_AnExceptionIsThrown()
        {
            // Arrange
            ArithmeticHelper subject = new ArithmeticHelper();

            // Act
            // Action is a method call
            Action test = () => subject.Sum(2, 2);

            // Assert
            Assert.Throws<InvalidOperationException>(test);
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(4, 2, 2)]
        [InlineData(-3, 3, -1)]
        [InlineData(10000, 5000, 2)]
        [InlineData(-4, -4, 1)]
        [InlineData(60, 10, 6)]
        public void TwoNumbersAreGiven_NumbersWillBeDividedTogether(int numberOne, int numberTwo, int result)
        {
            // Arrange
            ArithmeticHelper subject = new ArithmeticHelper();

            // Act
            int testTotal = subject.Divide(numberOne, numberTwo);

            // Asert
            Assert.Equal(result, testTotal);
        }

        [Fact]
        public void TheSecondNumberGivenIsZero_AnExceptionIsThrown()
        {
            // Arrange
            ArithmeticHelper subject = new ArithmeticHelper();

            // Act
            Action test = () => subject.Divide(2, 0);

            // Assert
            Assert.Throws<DivideByZeroException>(test);
        }

        
    }
}
