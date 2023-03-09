using LeetCodeTests.classes.StringManipulation;

namespace LeetCodeTests.UnitTests.StringManipulation;

public class RomanManipulationTests
{
    [TestCase(3, ExpectedResult = "III")]
    public string Input_3_Expected_III(int input)
    {
        var result = RomanManipulation.Format(input);
        return result;
    }

    [TestCase(3999, ExpectedResult = "MMMCMXCIX")]
    public string Input_3999_Expected_MMMCMXCIX(int input)
    {
        var result = RomanManipulation.Format(input);
        return result;
    }

    [TestCase(4000, ExpectedResult = "Please enter an integer less than or equal to 3999")]
    public string Input_4000_Expected_Over_Limit(int input)
    {
        var result = RomanManipulation.Format(input);
        return result;
    }

    [TestCase(0, ExpectedResult = "Nullus")]
    public string Input_0_Expected_Nullus(int input)
    {
        var result = RomanManipulation.Format(input);
        return result;
    }

    [TestCase(-1, ExpectedResult = "Please enter a positive integer")]
    public string Input_MinusOne_Expected_Enter_Positive_Number(int input)
    {
        var result = RomanManipulation.Format(input);
        return result;
    }

    [TestCase(1010, ExpectedResult = "MX")]
    public string Input_1010_Expected_MX(int input)
    {
        var result = RomanManipulation.Format(input);
        return result;
    }
}
