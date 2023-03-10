using LeetCodeTests.classes.numbers;

namespace LeetCodeTests.UnitTests.Numbers;

public class HappyNumberTests
{
    [TestCase(2, ExpectedResult = false)]
    public bool Input_2_Expected_False(int input)
    {
        var result = HappyNumber.IsHappy(input);
        return result;
    }

    [TestCase(19, ExpectedResult = true)]
    public bool Input_19_Expected_True(int input)
    {
        var result = HappyNumber.IsHappy(input);
        return result;
    }
}
