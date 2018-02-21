namespace FizzBuzz_ChainOfStrategies.Strategies
{
    public class TerminalStrategy : IIntegerToStringStrategy
    {
        private readonly int _value;

        public TerminalStrategy(int value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}