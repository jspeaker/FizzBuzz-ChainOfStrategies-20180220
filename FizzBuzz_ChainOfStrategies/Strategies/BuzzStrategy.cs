using FizzBuzz_ChainOfStrategies.Text;

namespace FizzBuzz_ChainOfStrategies.Strategies
{
    public class BuzzStrategy : IntegerToStringStrategy
    {
        public BuzzStrategy(int value, IIntegerToStringStrategy nextStrategy) : base(value, 5, new Buzz(), nextStrategy) { }
    }
}