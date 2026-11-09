using MathDemo.Core;

Console.WriteLine("1. Arithmetic Progression");
Console.WriteLine("1.a Find terms");

var termsToFind = new[] { 12, 28 };
var arithmeticProgression = new ArithmeticProgression
{
    FirstTerm = 17,
    CommonDifference = 5
};

foreach (var term in termsToFind)
{
    var termValue = arithmeticProgression.GetTerm(term);
    Console.WriteLine($"{term}:{termValue}");
}

Console.WriteLine();
Console.WriteLine("1.b Find Sum of all terms from - to");
const int from = 12;
const int to = 28;

var sum = arithmeticProgression.GetSumRange(from, to);
Console.WriteLine($"From:{from}, To:{to}, Sum:{sum}");

Console.ReadLine();


