using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz_ChainOfStrategies.Tests
{
    [TestFixture]
    public class IntegerTests
    {
        [Test, Category("Unit")]
        public void GivenTwo_WhenAskingForToStringViaImplicitOperator_ThenItShouldReturnStringTwo()
        {
            $"{new Integer(2)}".Should().Be("2");
        }

        [Test, Category("Unit")]
        public void GivenSix_WhenAskingForToStringViaImplicitOperator_ThenItShouldReturnFizz()
        {
            $"{new Integer(6)}".Should().Be("fizz");
        }

        [Test, Category("Unit")]
        public void GivenTen_WhenAskingForToStringViaImplicitOperator_ThenItShouldReturnBuzz()
        {
            $"{new Integer(10)}".Should().Be("buzz");
        }

        [Test, Category("Unit")]
        public void GivenThirty_WhenAskingForToStringViaImplicitOperator_ThenItShouldReturnFizzBuzz()
        {
            $"{new Integer(30)}".Should().Be("fizzbuzz");
        }
    }
}