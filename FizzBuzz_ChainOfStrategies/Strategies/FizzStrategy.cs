using FizzBuzz_ChainOfStrategies.Text;

namespace FizzBuzz_ChainOfStrategies.Strategies
{
    public class FizzStrategy : IntegerToStringStrategy
    {
        public FizzStrategy(int value, IIntegerToStringStrategy nextStrategy) : base(value, 3, new Fizz(), nextStrategy) { }
    }
}