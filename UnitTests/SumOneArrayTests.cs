namespace tests;

public class SumOneArrayTests
{
    [TestCase(new int[] { 1, 3, 4, 5 })]
    public void IsTen_FiveNumbers_ReturnValidArray(int[] number)
    {
        var result = SumOneArray.RunningSum(number);
        var testsdf = "sdfsf";
    }
}