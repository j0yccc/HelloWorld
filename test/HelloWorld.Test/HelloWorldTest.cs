using System;
using Xunit;

namespace HelloWorld.Test
{
    public class HelloWorldTest
    {
        [Fact]
        public void HelloWorldReturnString()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = "Hello World!";

            //Act
            var actual = helloWorld.HelloWorldString();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseString()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = "xxxelpelgooG";

            //Act
            var actual = helloWorld.ReverseString("Googleplexxx");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseStringNullOrEmpty()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = "Empty string";

            //Act
            var actual = helloWorld.ReverseString("");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseIntegerPositive()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = 54321;

            //Act
            var actual = helloWorld.ReverseInteger(12345);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseIntegerZero()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = 0;

            //Act
            var actual = helloWorld.ReverseInteger(0);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseIntegerNegative()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = -654321;

            //Act
            var actual = helloWorld.ReverseInteger(-123456);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveDuplicateString()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = "Goglepx";

            //Act
            var actual = helloWorld.RemoveDuplicateChar("Googleplexxx");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveDuplicateInteger()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var arr = new int[] { 1, 1, 2, 2, 3, 3, 4, 4 };
            var expected = 4;

            //Act
            var actual = helloWorld.RemoveDuplicateInteger(arr);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveDuplicateStringInTwoArrays()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            var expected = new string[] { "Ava", "Emma", "Olivia", "Sophia" };

            //Act
            var actual = helloWorld.RemoveDuplicateStringInTwoArrays(names1, names2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveDuplicateStringInTwoDuplicateArrays()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Ava", "Emma", "Olivia" };
            var expected = new string[] { "Ava", "Emma", "Olivia" };

            //Act
            var actual = helloWorld.RemoveDuplicateStringInTwoArrays(names1, names2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CountCharacter()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = 12;

            //Act
            var actual = helloWorld.CountCharacter("Googleplexxx");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CountCharacterEmpty()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = 0;

            //Act
            var actual = helloWorld.CountCharacter("");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CountWord()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = 9;

            //Act
            var actual = helloWorld.CountWord("This is my beautiful cat sitting at the beach.");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SumOfDigit()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = 6;

            //Act
            var actual = helloWorld.SumOfDigit(123);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PalindromeOddNumber()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = true;

            //Act
            var actual = helloWorld.PalindromeNumber(13231);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PalindromeEvenNumber()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = true;

            //Act
            var actual = helloWorld.PalindromeNumber(1331);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PalindromeNegativeNumber()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = false;

            //Act
            var actual = helloWorld.PalindromeNumber(-1331);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PalindromeNullString()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = false;

            //Act
            var actual = helloWorld.PalindromeString(null);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PalindromeEmptyString()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = false;

            //Act
            var actual = helloWorld.PalindromeString("");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PalindromeString()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = true;

            //Act
            var actual = helloWorld.PalindromeString("Deleveled");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AnagramStringTrue()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = true;

            //Act
            var actual = helloWorld.AnagramString("rasp", "sarp");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AnagramStringFalse()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = false;

            //Act
            var actual = helloWorld.AnagramString("rasp", "gasp");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AnagramInt()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = true;

            //Act
            var actual = helloWorld.AnagramString("test12", "21tset");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindPatternCount()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = 3;

            //Act
            var actual = helloWorld.FindPatternCount("aA", "aAAbbbb");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindRepeatedNumberInArray()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = 3;

            //Act
            var actual = helloWorld.FindRepeatedNumberInArray(new int[] {1,2,3,3});

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindLongestCommonPrefix()
        {
            //Arrange
            var helloWorld = new HelloWorld();
            var expected = "fl";

            //Act
            var actual = helloWorld.FindLongestCommonPrefix(new string[] {"flower", "fly", "flew"});

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
