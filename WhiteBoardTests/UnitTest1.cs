using System;
using Xunit;
using LLLibrary;

namespace WhiteBoardTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnAscending()
        {
            // Arrange
            LinkedList1 l1 = new LinkedList1();
            l1.Insert(8);
            l1.Insert(8);
            l1.Insert(3);
            l1.Insert(2);
            l1.Insert(1);

            // Act


            string value = l1.AscendingDescendingOrNone(l1).ToString();

            string expected = "Ascending to code heaven";
            // Assert
            Assert.Equal(expected, value);

        }


        [Fact]
        public void CanReturnDescending()
        {
            // Arrange
            LinkedList1 l2 = new LinkedList1();
            l2.Insert(1);
            l2.Insert(1);
            l2.Insert(1);
            l2.Insert(9);
            l2.Insert(10);

            // Act


            string value = l2.AscendingDescendingOrNone(l2).ToString();

            string expected = "Descending to madness";
            // Assert
            Assert.Equal(expected, value);

        }

        [Fact]
        public void CanReturnNoneOfTheAbove()
        {
            // Arrange
            LinkedList1 l3 = new LinkedList1();
            l3.Insert(12);
            l3.Insert(9);
            l3.Insert(7);
            l3.Insert(10);
            l3.Insert(10);

            // Act


            string value = l3.AscendingDescendingOrNone(l3).ToString();

            string expected = "None of the above";
            // Assert
            Assert.Equal(expected, value);

        }
    }
}
