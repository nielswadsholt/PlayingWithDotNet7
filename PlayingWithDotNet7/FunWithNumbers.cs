using System.Numerics;

namespace PlayingWithDotNet7
{
    public static class FunWithNumbers
    {
        public static T AddAll<T>(this T[] values) where T : INumber<T> => values switch
        {
            [] => T.Zero,
            [var first, .. var rest] => first + AddAll(rest.AsSpan())
        };

        private static T AddAll<T>(this Span<T> values) where T : INumber<T> => values switch
        {
            [] => T.Zero,
            [var first, .. var rest] => first + AddAll(rest)
        };
    }
}
