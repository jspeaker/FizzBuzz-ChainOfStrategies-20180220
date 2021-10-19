using FizzBuzz_ChainOfStrategies.Strategies;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz_ChainOfStrategies.Tests
{
    [TestFixture]
    public class FizzStrategyTests
    {
        [Test, System.ComponentModel.Category("Unit")]
        public void GivenIntegerEvenlyDivisibleByThree_WhenAskingToString_ThenItShouldReturnFizz()
        {
            const int input = 6;
            $"{new FizzStrategy(input, new StringStrategy(input))}".Should().Be("fizz");
        }

        [Test, System.ComponentModel.Category("Unit")]
        public void GivenIntegerNotEvenlyDivisibleByThree_WhenAskingToString_ThenItShouldDeferToNextStrategy()
        {
            const int input = 11;
            $"{new FizzStrategy(input, new StringStrategy(input))}".Should().Be("11");
        }
    }
}