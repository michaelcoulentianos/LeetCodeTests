using LeetCodeTests.classes.Greedy;

namespace LeetCodeTests.UnitTests.Greedy;

public class BuyAndSellTests
{

    [TestCase(ExpectedResult = 5)]
    public int Simple_Profit_Returned_Five()
    {

        int[] prices = new[] { 7, 1, 5, 3, 6, 4 };
        return BuyAndSell.MaxProfit(prices);
    }

    [TestCase(ExpectedResult = 0)]
    public int Simple_Profit_Returned_Zero()
    {
        int[] prices = new[] { 7, 6, 4, 3, 1 };
        return BuyAndSell.MaxProfit(prices);
    }

    [TestCase(ExpectedResult = 0)]
    public int Simple_Profit_Returned_1_Input_Zero()
    {
        int[] prices = new[] { 1 };
        return BuyAndSell.MaxProfit(prices);
    }

    [TestCase(ExpectedResult = 8)]
    public int Simple_Profit_Returned_8()
    {
        int[] prices = new[] { 1, 9 };
        return BuyAndSell.MaxProfit(prices);
    }

    [TestCase(ExpectedResult = 3)]
    public int Simple_Profit_inputs_1_2_4_Returned_3()
    {
        int[] prices = new[] { 1,2,4 };
        return BuyAndSell.MaxProfit(prices);
    }
}
