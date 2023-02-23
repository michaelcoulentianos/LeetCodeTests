namespace LeetCodeTests;

public class LongestPalindromeTests
{
    [TestCase(ExpectedResult = 7)]
    public int Simple_LongestPalindrome_return_7()
    {
        return LongestPalindrome.SetLongestPalindrome("abccccdd");
    }

    [TestCase(ExpectedResult = 1)]
    public int Simple_LongestPalindrome_return_1()
    {
        return LongestPalindrome.SetLongestPalindrome("a");
    }

    [TestCase(ExpectedResult = 3)]
    public int Simple_LongestPalindrome_return_3()
    {
        return LongestPalindrome.SetLongestPalindrome("ccc");
    }

    [TestCase(ExpectedResult = 983)]
    public int Simple_LongestPalindrome_return_983()
    {
        return LongestPalindrome.SetLongestPalindrome("civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth");
    }
}