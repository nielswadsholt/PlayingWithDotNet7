// See https://aka.ms/new-console-template for more information
using PlayingWithDotNet7;
using System.Numerics;
using System.Text;


Console.WriteLine("========== Fun with numbers ==========");

var ints = new[] { 1, 3, 6, 4, 2, 8 };
var doubles = new[] { 1, 3, 6, 4.0, 2, 8 };
var decimals = new[] { 1, 3M, 6, 4, 2, 8 };
byte[] bytes = { 0, 15, 42, 255 };
var chars = new[] { 'a', 'b', 'c' };

Console.WriteLine(ints.AddAll());
Console.WriteLine(doubles.AddAll());
Console.WriteLine(decimals.AddAll());
Console.WriteLine(bytes.AddAll());
Console.WriteLine(chars.AddAll());


Console.WriteLine("\n========== Fun with strings ==========");

var u8 = "UTF-8 string literals FTW!"u8;
Console.WriteLine(Encoding.UTF8.GetString(u8));

Console.WriteLine(""""

    By wrapping in at least three """'s, I can write

        <div class="yes">
            <div>
                \n stands for nothing.
            </div>
        </div>
    
    and you can't touch me!

    """");

Console.WriteLine($""""
    Or I can write
        Interpolated {Encoding.UTF8.GetString(u8)}
    if I please (which I do).

    """");

Console.WriteLine($$""""
    But what if the text already contains curly braces?
    Just add an extra dollar sign + pair of curly braces!
    {
        answer: {{42}}
    }

    """");


Console.WriteLine("\n========== Fun with static members ==========");
var myFirstNumber = new MyInt();
var mySecondNumber = MyInt.Zero;
var myThirdNumber = new MyInt(1);
var myFourthNumber = new MyInt(2);
var myFifthNumber = MyInt.Negate(myFourthNumber);
Console.WriteLine(myFirstNumber + mySecondNumber + myThirdNumber + myFourthNumber - myFifthNumber);


Console.WriteLine("\n========== Fun with list patterns ==========");
var awesomeArray = new[] { 1, 2, 3 };
Console.WriteLine(awesomeArray is [1, 2, 3]);
Console.WriteLine(awesomeArray is [1, 2, 4]);
Console.WriteLine(awesomeArray is [1, 2, 3, 4]);
Console.WriteLine(awesomeArray is [<2, >=2, <=1+2]);
Console.WriteLine(awesomeArray is [<2, ..]);
Console.WriteLine(awesomeArray is [.., 4]);
Console.WriteLine(awesomeArray is [var first, <=1, ..] ? first : "No match");

var accountTotal = 0.0;
var transactions = new object[][] {
    new object[] {"01-11-2022", "deposit", 1000 },
    new object[] {"01-11-2022", "withdrawal", 150 },
    new object[] {"02-11-2022", "deposit", 200 },
    new object[] {"03-11-2022", "withdrawal", 139.5 },
    new object[] {"05-11-2022", "withdrawal", 600 },
    new object[] {"08-11-2022", "withdrawal", 300 },
    new object[] {"08-11-2022", "robbing", 1000000 }
};

var asDouble = (object numericObject) =>
{
    return numericObject switch
    {
        int => (int)numericObject,
        double => (double)numericObject,
        _ => throw new ArgumentException()
    };
};

var performTransaction = (double amount) =>
{
    accountTotal += amount;

    return accountTotal;
};

foreach (var transaction in transactions)
{
    var receipt = transaction switch
    {
        [var date, "deposit", var amount] => $"{date}: {amount} deposited. New total: {performTransaction(asDouble(amount))}",
        [var date, "withdrawal", var amount] => $"{date}: {amount} withdrawn. New total: {performTransaction(-asDouble(amount))}",
        _ => "Illegal transaction was cancelled."
    };

    Console.WriteLine(receipt);
}