namespace FizzBuzz_ChainOfStrategies.Strategies
{
    public class StringStrategy : IIntegerToStringStrategy
    {
        private readonly Text.Text _text;

        public StringStrategy(int value) : this(new Text.Text(value.ToString())) { }

        private StringStrategy(Text.Text text) => _text = text;

        public override string ToString() => _text.ToString();
    }
}