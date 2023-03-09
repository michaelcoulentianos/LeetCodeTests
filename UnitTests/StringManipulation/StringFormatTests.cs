using LeetCodeTests.classes.StringManipulation;

namespace LeetCodeTests.UnitTests.StringManipulation;

public class StringFormatTests
{
    [TestCase("My password is 12#$ab_?cd34", ExpectedResult = "My password is 12ab_cd34")]
    public string Simple(string input)
    {
        var result = StringFormat.FormatString(input);
        return result;
    }
}
