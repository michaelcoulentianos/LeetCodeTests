namespace tests;

public class Tests
{
    [TestCase(new int[] { 1, 3, 4, 5 }, ExpectedResult = new int[] {1,4,8,13})]
    public int[] IsTen_FiveNumbers_ReturnValidArray(int[] number)
    {
        var result = SumOneArray.RunningSum(number);
        return result;
    }
}