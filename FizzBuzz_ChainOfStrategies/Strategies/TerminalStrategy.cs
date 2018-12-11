namespace FizzBuzz_ChainOfStrategies.Strategies
{
    public class TerminalStrategy : IIntegerToStringStrategy
    {
        private readonly Text.Text _text;

        public TerminalStrategy(int value) : this(new Text.Text(value.ToString())) { }

        private TerminalStrategy(Text.Text text) => _text = text;

        public override string ToString() => _text.ToString();
    }
}