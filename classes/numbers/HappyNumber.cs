namespace LeetCodeTests.classes.numbers;

public class HappyNumber
{
    public static bool IsHappy(int n)
    {
        var numbers = $"{n}";

        int counter = 31;

        while (counter != 0)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                var num = (int)item - (int)'0';
                sum += num * num;
            }
            if (sum == 1)
                return true;
            numbers = $"{sum}";
            counter--;
        }

        return false;
    }
}
