namespace FizzBuzz_ChainOfStrategies.Extensions
{
    public static class IntExtensions
    {
        public static bool IsEvenlyDivisibleBy(this int dividend, int divisor) => dividend % divisor == 0;
    }
}