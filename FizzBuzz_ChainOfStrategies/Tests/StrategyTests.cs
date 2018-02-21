using FizzBuzz_ChainOfStrategies.Strategies;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz_ChainOfStrategies.Tests
{
    [TestFixture]
    public class StrategyTests
    {

        [Test, Category("Unit")]
        public void GivenTerminalStrategy_WhenAskingToString_ThenItShouldReturnNumberAsString()
        {
            $"{new TerminalStrategy(2)}".Should().Be("2");
        }

        [Test, Category("Unit")]
        public void GivenTwoAndFizzBuzzStrategy_WhenAskingToString_ThenItShouldReturnNumberAsString()
        {
            $"{new FizzBuzzStrategy(2, new TerminalStrategy(2))}".Should().Be("2");
        }

        [Test, Category("Unit")]
        public void GivenThirtyAndFizzBuzzStrategy_WhenAskingToString_ThenItShouldReturnFizzBuzz()
        {
            $"{new FizzBuzzStrategy(30, new TerminalStrategy(30))}".Should().Be("fizzbuzz");
        }

        [Test, Category("Unit")]
        public void GivenFiveAndBuzzStrategy_WhenAskingToString_ThenItShouldReturnBuzz()
        {
            $"{new BuzzStrategy(5, new TerminalStrategy(5))}".Should().Be("buzz");
        }

        [Test, Category("Unit")]
        public void GivenTwoAndBuzzStrategy_WhenAskingToString_ThenItShouldReturnNumberAsString()
        {
            $"{new BuzzStrategy(2, new TerminalStrategy(2))}".Should().Be("2");
        }

        [Test, Category("Unit")]
        public void GivenSixAndFizzStrategy_WhenAskingToString_ThenItShouldReturnFizz()
        {
            $"{new FizzStrategy(6, new TerminalStrategy(6))}".Should().Be("fizz");
        }

        [Test, Category("Unit")]
        public void GivenElevenAndFizzStrategy_WhenAskingToString_ThenItShouldReturnNumberAsString()
        {
            $"{new FizzStrategy(11, new TerminalStrategy(11))}".Should().Be("11");
        }
    }
}