using FizzBuzz_ChainOfStrategies.Strategies;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz_ChainOfStrategies.Tests
{
    [TestFixture]
    public class FizzBuzzStrategyTests
    {
        [Test, System.ComponentModel.Category("Unit")]
        public void GivenThirtyAndFizzBuzzStrategy_WhenAskingToString_ThenItShouldReturnFizzBuzz()
        {
            const int input = 30;
            $"{new FizzBuzzStrategy(input, new StringStrategy(input))}".Should().Be("fizzbuzz");
        }

        [Test, System.ComponentModel.Category("Unit")]
        public void GivenIntegerNotEvenlyDivisibleByThreeOrFive_WhenAskingToString_ThenItShouldDeferToNextStrategy()
        {
            const int input = 2;
            $"{new FizzBuzzStrategy(input, new StringStrategy(input))}".Should().Be("2");
        }
    }
}