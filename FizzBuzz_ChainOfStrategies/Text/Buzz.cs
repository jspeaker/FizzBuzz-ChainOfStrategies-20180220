namespace FizzBuzz_ChainOfStrategies.Text
{
    public class Buzz : Text
    {
        public Buzz() : base("buzz") { }

        public static implicit operator string(Buzz buzz) => buzz.ToString();
    }
}