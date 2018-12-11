namespace FizzBuzz_ChainOfStrategies.Text
{
    public class Text : IText
    {
        private readonly string _value;

        public Text(string value) => _value = value;

        public override string ToString() => _value;
    }
}