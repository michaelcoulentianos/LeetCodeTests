public class LongestPalindrome
{
    public static int SetLongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        bool isPalindrome = true;
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - i - 1])
            {
                isPalindrome = false;
                break;
            }
        }
        if (isPalindrome) return s.Length;

        var dict = new Dictionary<char, int>();
        foreach (var item in s)
        {
            if (!dict.ContainsKey(item)) dict[item] = 1;
            else dict[item]++;
        }

        var maxOdd = dict.Where(f => f.Value % 2 != 0).DefaultIfEmpty().MaxBy(x => x.Value);

        var answer = dict
                    .DefaultIfEmpty()
                    .Where(w => w.Key != maxOdd.Key)
                    .Sum(x => RemoveRemainder(x.Value, 2)) + maxOdd.Value;

        return answer;
    }

    public static int RemoveRemainder(int input, int division)
    {
        var remainder = input % division;
        return input - remainder;
    }
}