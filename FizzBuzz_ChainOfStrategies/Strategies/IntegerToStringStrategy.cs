using FizzBuzz_ChainOfStrategies.Extensions;

namespace FizzBuzz_ChainOfStrategies.Strategies
{
    public abstract class IntegerToStringStrategy : IIntegerToStringStrategy
    {
        private readonly int _value;
        private readonly int _divisor;
        private readonly Text.Text _parsedValue;
        private readonly IIntegerToStringStrategy _nextStrategy;

        protected IntegerToStringStrategy(int value, int divisor, Text.Text parsedValue, IIntegerToStringStrategy nextStrategy)
        {
            _value = value;
            _divisor = divisor;
            _parsedValue = parsedValue;
            _nextStrategy = nextStrategy;
        }

        public override string ToString()
        {
            if (_value.IsEvenlyDivisibleBy(_divisor) is false) return _nextStrategy.ToString();

            return _parsedValue.ToString();
        }
    }
}