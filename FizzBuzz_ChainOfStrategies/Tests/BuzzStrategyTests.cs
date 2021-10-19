using FizzBuzz_ChainOfStrategies.Strategies;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz_ChainOfStrategies.Tests
{
    [TestFixture]
    public class BuzzStrategyTests
    {
        [Test, System.ComponentModel.Category("Unit")]
        public void GivenIntegerEvenlyDivisibleByFive_WhenAskingToString_ThenItShouldReturnBuzz()
        {
            const int input = 5;
            $"{new BuzzStrategy(input, new StringStrategy(input))}".Should().Be("buzz");
        }

        [Test, System.ComponentModel.Category("Unit")]
        public void GivenIntegerNotEvenlyDivisibleByFive_WhenAskingToString_ThenItShouldDeferToNextStrategy()
        {
            const int input = 2;
            $"{new BuzzStrategy(input, new StringStrategy(input))}".Should().Be("2");
        }
    }
}