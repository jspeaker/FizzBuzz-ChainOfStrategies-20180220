namespace FizzBuzz_ChainOfStrategies.Text
{
    public class Fizz : Text
    {
        public Fizz() : base("fizz") { }

        public static implicit operator string(Fizz fizz) => fizz.ToString();
    }
}