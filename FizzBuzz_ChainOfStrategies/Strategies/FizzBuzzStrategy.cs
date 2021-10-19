using FizzBuzz_ChainOfStrategies.Text;

namespace FizzBuzz_ChainOfStrategies.Strategies
{
    public class FizzBuzzStrategy : IntegerToStringStrategy
    {
        public FizzBuzzStrategy(int value, IIntegerToStringStrategy nextStrategy) : base(value, 3 * 5, new FizzBuzz(), nextStrategy) { }
    }
}