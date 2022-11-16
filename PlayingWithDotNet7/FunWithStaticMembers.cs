namespace PlayingWithDotNet7
{
    public interface IMonoid<TSelf> where TSelf : IMonoid<TSelf>
    {
        public static abstract TSelf operator +(TSelf a, TSelf b);
        public static abstract TSelf operator -(TSelf a, TSelf b);
        public static abstract TSelf Zero { get; }
        public static abstract TSelf Negate(TSelf value);
    }

    public struct MyInt : IMonoid<MyInt>
    {
        readonly int value;

        public MyInt(int i) => value = i;

        public static MyInt operator +(MyInt a, MyInt b) => new MyInt(a.value + b.value);

        public static MyInt operator -(MyInt a, MyInt b) => new MyInt(a.value - b.value);

        public static MyInt Zero => new MyInt(0);

        public static MyInt Negate(MyInt value) => Zero - value;

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
