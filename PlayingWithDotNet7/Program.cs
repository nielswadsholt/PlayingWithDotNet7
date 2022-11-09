﻿// See https://aka.ms/new-console-template for more information
using PlayingWithDotNet7;

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
