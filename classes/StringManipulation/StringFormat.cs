namespace LeetCodeTests.classes.StringManipulation;

public class StringFormat
{
    public static string FormatString(string sentence)
    {
        var result = string.Empty;
        for (var i = 0; i < sentence.Length; i++)
        {
            var upperCase = char.ToUpper(sentence[i]);
            if (
                (upperCase >= 65 && upperCase <= 90)
                || (upperCase >= 48 && upperCase <= 57)
                || upperCase == 32
                || upperCase == 45
                || upperCase == 95
            )
            {
                result += sentence[i];
            }
        }

        if (string.IsNullOrEmpty(result)) return "NA";

        return result;
    }
}
