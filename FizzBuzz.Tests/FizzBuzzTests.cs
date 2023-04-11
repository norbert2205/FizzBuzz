using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(12, "Fizz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(20, "Buzz")]
        [TestCase(25, "Buzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(45, "FizzBuzz")]

        public void Given_MultipleOfThreeOrFive_When_Processed_Then_ExpectedWordReturned(int number, string result)
        {
            FizzBuzz.GetResult(number).Should().Be(result);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(7)]
        [TestCase(23)]
        [TestCase(41)]
        public void Given_NotMultipleOfThreeOrFive_When_Processed_Then_ReturnNumber(int number)
        {
            FizzBuzz.GetResult(number).Should().Be(number.ToString());
        }
    }
}