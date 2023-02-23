namespace LeetCodeTests.UnitTests;

public class SumOneArray
{
    public static int[] RunningSum(int[] nums)
    {
        var result = new List<int>();

        var number = 0;
        foreach (var num in nums)
        {
            number += num;
            result.Add(number);
        }

        return result.ToArray();
    }
}