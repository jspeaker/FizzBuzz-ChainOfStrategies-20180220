using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz_ChainOfStrategies.Tests
{
    [TestFixture]
    public class IntegerTests
    {
        [Test, Category("Unit")]
        public void GivenTwo_WhenAskingForToString_ThenItShouldReturnStringTwo()
        {
            $"{new Integer(2)}".Should().Be("2");
        }

        [Test, Category("Unit")]
        public void GivenSix_WhenAskingForToString_ThenItShouldReturnFizz()
        {
            $"{new Integer(6)}".Should().Be("fizz");
        }

        [Test, Category("Unit")]
        public void GivenTen_WhenAskingForToString_ThenItShouldReturnBuzz()
        {
            $"{new Integer(10)}".Should().Be("buzz");
        }

        [Test, Category("Unit")]
        public void GivenThirty_WhenAskingForToString_ThenItShouldReturnFizzBuzz()
        {
            $"{new Integer(30)}".Should().Be("fizzbuzz");
        }
    }
}