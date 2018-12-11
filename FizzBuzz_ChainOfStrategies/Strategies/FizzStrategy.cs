using FizzBuzz_ChainOfStrategies.Extensions;
using FizzBuzz_ChainOfStrategies.Text;

namespace FizzBuzz_ChainOfStrategies.Strategies
{
    public class FizzStrategy : IIntegerToStringStrategy
    {
        private readonly int _value;
        private readonly IIntegerToStringStrategy _nextStrategy;
        private readonly Fizz _fizz = new Fizz();

        public FizzStrategy(int value) : this(value, new TerminalStrategy(value)) { }

        public FizzStrategy(int value, IIntegerToStringStrategy nextStrategy)
        {
            _value = value;
            _nextStrategy = nextStrategy;
        }

        public override string ToString()
        {
            if (!_value.IsEvenlyDivisibleBy(3)) return _nextStrategy.ToString();

            return _fizz;
        }
    }
}