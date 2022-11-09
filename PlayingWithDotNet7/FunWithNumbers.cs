using System.Numerics;

namespace PlayingWithDotNet7
{
    public static class FunWithNumbers
    {
        public static T AddAll<T>(this T[] arrayOfNumbers) where T : INumber<T>
        {
            var sum = T.Zero;

            foreach (var number in arrayOfNumbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
