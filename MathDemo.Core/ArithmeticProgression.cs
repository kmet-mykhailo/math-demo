namespace MathDemo.Core;

public class ArithmeticProgression
{
    public required int FirstTerm { get; init; }
    public required int CommonDifference { get; init; }

    public int GetTerm(int n)
    {
        // each element is bigger than previous one
        return FirstTerm + (n - 1) * CommonDifference;
    }

    public int GetSumRange(int from, int to)
    {
        // sum of first n elements equals n * (FirstTerm + (value of n term)) / 2
        // to * (FirstTerm + GetTerm(to)) / 2;  or
        // to * (2 * FirstTerm + (to - 1) * CommonDifference) / 2;
        // var firstTerm = FirstTerm + (from - 1) * CommonDifference;
        // n = to - from;
        return (to - from + 1) * (2 * (FirstTerm + (from - 1) * CommonDifference) + (to - from) * CommonDifference) / 2;
    }
    
    public int GetSumRangeWithAddingTerms(int from, int to)
    {
        var sum = GetTerm(from);
        for (var i = from+1; i <= to; i++)
        {
            sum += GetTerm(i);
        }
        return sum;
    }
}