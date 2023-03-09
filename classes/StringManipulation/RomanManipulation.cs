namespace LeetCodeTests.classes.StringManipulation;

public class RomanManipulation
{
    public static string Format(int n)
    {
        int limit = 3999;
        if (n == 0)
            return "Nullus";
        if (n > limit)
            return $"Please enter an integer less than or equal to {limit}";
        if (n < 0)
            return "Please enter a positive integer";

        string[] m = { "", "M", "MM", "MMM" };
        string[] c = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] x = { "", "X", "XX", "XXX","XL","L", "LX", "LXX", "LXXX","XC" };
        string[] i = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        (var thousands, var number) = RomanNumber(n, m, 1000);
        (var hundereds, number) = RomanNumber(number, c, 100);
        (var tens, number) = RomanNumber(number, x, 10);
        (var ones, number) = RomanNumber(number, i, 1);

        var ans = thousands + hundereds + tens + ones;
        return ans;
    }

    private static (string, int) RomanNumber(int input, string[] collection, int num)
    {
        var index = (input / num);
        if (input / num > -1) return (collection[index], input -= (index) * num);
        return ("", input);
    }
}
