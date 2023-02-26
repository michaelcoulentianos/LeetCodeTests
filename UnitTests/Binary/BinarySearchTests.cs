using LeetCodeTests.classes.Binary;

namespace LeetCodeTests.UnitTests.Binary;

public class BinarySearchTests
{
    [TestCase(ExpectedResult = -1)]
    public int Binary_Search_Input_3_5_7_Target_0_Expected_Negative_1()
    {
        var result = BinarySearch.Search(new int[] { 3, 5, 7 }, 0);
        return result;
    }

    [TestCase(ExpectedResult = 4)]
    public int Binary_Search_Expected_Negative_9()
    {
        var result = BinarySearch.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9);
        return result;
    }

    [TestCase(ExpectedResult = 0)]
    public int Binary_Search_Expected_0()
    {
        var result = BinarySearch.Search(new int[] { 3 }, 3);
        return result;
    }

    [TestCase(ExpectedResult = -1)]
    public int Binary_Search_Expected_Negative_1()
    {
        var result = BinarySearch.Search(null, -1);
        return result;
    }

    [TestCase(ExpectedResult = 1)]
    public int Binary_Search_Target_4_Expected_1()
    {
        var result = BinarySearch.Search(new int[] { 3, 4, 5 }, 4);
        return result;
    }
}
