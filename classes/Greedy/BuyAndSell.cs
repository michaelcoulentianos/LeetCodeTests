namespace LeetCodeTests.classes.Greedy;
public class BuyAndSell
{
    public static int MaxProfit(int[] prices)
    {
        int min = 10000;
        int maxDiff = 0;
        
        int size = prices.Count();
        
        for (int i = 0; i < size; i++){
            min = Math.Min(prices[i], min);
            maxDiff = Math.Max(prices[i] - min, maxDiff);
         }
        return maxDiff;
    }
}