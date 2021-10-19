using FizzBuzz_ChainOfStrategies.Strategies;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz_ChainOfStrategies.Tests
{
    [TestFixture]
    public class StringStrategyTests
    {
        [Test, System.ComponentModel.Category("Unit")]
        public void GivenIntegerNotEvenlyDivisibleByThreeOrFive_WhenAskingToString_ThenItShouldReturnIntegerAsString()
        {
            $"{new StringStrategy(2)}".Should().Be("2");
        }

    }
}