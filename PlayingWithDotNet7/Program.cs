// See https://aka.ms/new-console-template for more information
using PlayingWithDotNet7;
using System.Text;

var ints = new[] { 1, 3, 6, 4, 2, 8 };
var doubles = new[] { 1, 3, 6, 4.0, 2, 8 };
var decimals = new[] { 1, 3M, 6, 4, 2, 8 };
byte[] bytes = { 0, 15, 42, 255 };
var chars = new[] { 'a', 'b', 'c' };

Console.WriteLine("========== Fun with numbers ==========");
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

Console.WriteLine("\n========== Fun with static members ==========");
var myFirstNumber = new MyInt();
var mySecondNumber = MyInt.Zero;
var myThirdNumber = new MyInt(1);
var myFourthNumber = new MyInt(2);
var myFifthNumber = MyInt.Negate(myFourthNumber);
Console.WriteLine(myFirstNumber + mySecondNumber + myThirdNumber + myFourthNumber - myFifthNumber);
