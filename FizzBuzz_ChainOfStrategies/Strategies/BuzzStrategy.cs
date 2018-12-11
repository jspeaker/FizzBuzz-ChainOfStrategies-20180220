using FizzBuzz_ChainOfStrategies.Extensions;
using FizzBuzz_ChainOfStrategies.Text;

namespace FizzBuzz_ChainOfStrategies.Strategies
{
    public class BuzzStrategy : IIntegerToStringStrategy
    {
        private readonly int _value;
        private readonly IIntegerToStringStrategy _nextStrategy;
        private readonly Buzz _buzz = new Buzz();

        public BuzzStrategy(int value) : this(value, new FizzStrategy(value)) { }

        public BuzzStrategy(int value, IIntegerToStringStrategy nextStrategy)
        {
            _value = value;
            _nextStrategy = nextStrategy;
        }

        public override string ToString()
        {
            if (!_value.IsEvenlyDivisibleBy(5)) return _nextStrategy.ToString();

            return _buzz;
        }
    }
}