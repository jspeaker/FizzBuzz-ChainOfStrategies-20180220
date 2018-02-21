using FizzBuzz_ChainOfStrategies.Extensions;

namespace FizzBuzz_ChainOfStrategies.Strategies
{
    public class FizzBuzzStrategy : IIntegerToStringStrategy
    {
        private readonly int _value;
        private readonly IIntegerToStringStrategy _nextStrategy;

        public FizzBuzzStrategy(int value) : this(value, new BuzzStrategy(value)) { }

        public FizzBuzzStrategy(int value, IIntegerToStringStrategy nextStrategy)
        {
            _value = value;
            _nextStrategy = nextStrategy;
        }

        public override string ToString()
        {
            if (!_value.IsDivisibleBy(15)) return _nextStrategy.ToString();

            return "fizzbuzz";
        }
    }
}