using FizzBuzz_ChainOfStrategies.Extensions;

namespace FizzBuzz_ChainOfStrategies.Strategies
{
    public class FizzStrategy : IIntegerToStringStrategy
    {
        private readonly int _value;
        private readonly IIntegerToStringStrategy _nextStrategy;

        public FizzStrategy(int value) : this(value, new TerminalStrategy(value)) { }

        public FizzStrategy(int value, IIntegerToStringStrategy nextStrategy)
        {
            _value = value;
            _nextStrategy = nextStrategy;
        }

        public override string ToString()
        {
            if (!_value.IsDivisibleBy(3)) return _nextStrategy.ToString();

            return "fizz";
        }
    }
}