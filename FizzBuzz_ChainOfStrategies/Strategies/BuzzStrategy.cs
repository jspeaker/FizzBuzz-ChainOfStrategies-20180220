using FizzBuzz_ChainOfStrategies.Extensions;

namespace FizzBuzz_ChainOfStrategies.Strategies
{
    public class BuzzStrategy : IIntegerToStringStrategy
    {
        private readonly int _value;
        private readonly IIntegerToStringStrategy _nextStrategy;

        public BuzzStrategy(int value) : this(value, new FizzStrategy(value)) { }

        public BuzzStrategy(int value, IIntegerToStringStrategy nextStrategy)
        {
            _value = value;
            _nextStrategy = nextStrategy;
        }

        public override string ToString()
        {
            if (!_value.IsDivisibleBy(5)) return _nextStrategy.ToString();

            return "buzz";
        }
    }
}