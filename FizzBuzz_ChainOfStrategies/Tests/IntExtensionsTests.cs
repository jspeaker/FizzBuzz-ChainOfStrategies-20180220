using FizzBuzz_ChainOfStrategies.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz_ChainOfStrategies.Tests
{
    [TestFixture]
    public class IntExtensionsTests
    {
        [Test, Category("Unit")]
        public void GivenFive_WhenCallingIsDivisibleByFive_ThenItShouldBeTrue()
        {
            // arrange / act / assert
            5.IsEvenlyDivisibleBy(5).Should().BeTrue();
        }

        [Test, Category("Unit")]
        public void GivenFive_WhenCallingIsDivisibleBySix_ThenItShouldBeFalse()
        {
            // arrange / act / assert
            5.IsEvenlyDivisibleBy(6).Should().BeFalse();
        }
    }
}