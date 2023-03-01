using System.Diagnostics;
using LeetCodeTests.classes.numbers;

namespace LeetCodeTests.UnitTests.Numbers;

public class PossibleTwoPairsTests
{
    private Stopwatch _StopWatch;

    public PossibleTwoPairsTests() => _StopWatch = new();

    [TestCase(ExpectedResult = 6)]
    public int PossibleTwoPairs_Expected_6()
    {
        return PossibleTwoPairs.FindPairs(4);
    }

    [TestCase(1000)]
    public void PossibleTwoPairs_Expected_1000_ms(int n)
    {
        _StopWatch.Start();
        var result = PossibleTwoPairs.FindPairs(n);
        _StopWatch.Stop();

        var timeLasped = _StopWatch.ElapsedMilliseconds;

        var test = "sdfsfd";
    }
}
