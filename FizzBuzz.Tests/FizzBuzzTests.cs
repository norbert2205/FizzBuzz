using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void Given_MultipleOfThree_When_Processed_Then_ReturnFizz(int number)
        {
            FizzBuzz.GetResult(number).Should().Be("Fizz");
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        public void Given_MultipleOfFive_When_Processed_Then_ReturnBuzz(int number)
        {
            FizzBuzz.GetResult(number).Should().Be("Buzz");
        }


        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void Given_MultipleOfThreeAndFive_When_Processed_Then_ReturnFizzBuzz(int number)
        {
            FizzBuzz.GetResult(number).Should().Be("FizzBuzz");
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(7)]
        [TestCase(23)]
        [TestCase(41)]
        public void Given_NotMultipleOfThreeAndFive_When_Processed_Then_ReturnNumber(int number)
        {
            FizzBuzz.GetResult(number).Should().Be(number.ToString());
        }
    }
}