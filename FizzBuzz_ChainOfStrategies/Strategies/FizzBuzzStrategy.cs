using FizzBuzz_ChainOfStrategies.Extensions;
using FizzBuzz_ChainOfStrategies.Text;

namespace FizzBuzz_ChainOfStrategies.Strategies
{
    public class FizzBuzzStrategy : IIntegerToStringStrategy
    {
        private readonly int _value;
        private readonly IIntegerToStringStrategy _nextStrategy;
        private readonly FizzBuzz _fizzBuzz = new FizzBuzz();

        public FizzBuzzStrategy(int value) : this(value, new BuzzStrategy(value)) { }

        public FizzBuzzStrategy(int value, IIntegerToStringStrategy nextStrategy)
        {
            _value = value;
            _nextStrategy = nextStrategy;
        }

        public override string ToString()
        {
            if (!_value.IsEvenlyDivisibleBy(15)) return _nextStrategy.ToString();

            return _fizzBuzz;
        }
    }
}