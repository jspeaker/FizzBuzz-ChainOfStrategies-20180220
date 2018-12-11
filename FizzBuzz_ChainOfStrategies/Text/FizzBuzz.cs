namespace FizzBuzz_ChainOfStrategies.Text
{
    public class FizzBuzz : Text
    {
        public FizzBuzz() : base("fizzbuzz")  {}

        public static implicit operator string(FizzBuzz fizzBuzz) => fizzBuzz.ToString();
    }
}