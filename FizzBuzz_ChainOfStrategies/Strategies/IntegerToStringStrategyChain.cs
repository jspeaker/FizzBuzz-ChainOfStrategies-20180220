namespace FizzBuzz_ChainOfStrategies.Strategies
{
    public class IntegerToStringStrategyChain : IIntegerToStringStrategy
    {
        private readonly IIntegerToStringStrategy _strategies;

        public IntegerToStringStrategyChain(int value) : this(
            new FizzBuzzStrategy(value,
                new BuzzStrategy(value, 
                    new FizzStrategy(value, 
                        new StringStrategy(value))))) { }

        public IntegerToStringStrategyChain(IIntegerToStringStrategy strategies) => _strategies = strategies;

        public override string ToString() => _strategies.ToString();
    }
}