using FizzBuzz_ChainOfStrategies.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz_ChainOfStrategies.Tests
{
    [TestFixture]
    public class IntExtensionsTests
    {
        [Test, Category("Unit")]
        public void GivenMultipleOfInteger_WhenCallingIsDivisibleByInteger_ThenItShouldBeTrue()
        {
            // arrange / act / assert
            const int integer = 5;
            (integer * 2).IsEvenlyDivisibleBy(integer).Should().BeTrue();
        }

        [Test, Category("Unit")]
        public void GivenInteger_WhenCallingIsDivisibleByIntegerPlusOne_ThenItShouldBeFalse()
        {
            // arrange / act / assert
            const int integer = 5;
            integer.IsEvenlyDivisibleBy(integer + 1).Should().BeFalse();
        }

        [Test, Category("Unit")]
        public void GivenOnePlusOne_WhenCallingIsDivisibleByInteger_ThenItShouldBeTrue()
        {
            // arrange / act / assert
            const int integer = 1;
            (integer + 1).IsEvenlyDivisibleBy(integer).Should().BeTrue();
        }

        [Test, Category("Unit")]
        public void GivenIntegerGreaterThanOnePlusOne_WhenCallingIsDivisibleByInteger_ThenItShouldBeFalse()
        {
            // arrange / act / assert
            const int integer = 2;
            (integer + 1).IsEvenlyDivisibleBy(integer).Should().BeFalse();
        }
    }
}