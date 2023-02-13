using LeetCodeTests.classes.numbers;

namespace LeetCodeTests.UnitTests;
public class MergeTwoSortedListsTests
{
    [TestCase]
    public void Simple_ThreeDigits()
    {
        ListNode l1 = new(1, new(2, new(4)));
        ListNode l2 = new(1, new(3, new(4)));

        var result = MergeTwoSortedLists.SimpleMergeTwoLists(l1, l2);
    }

    [TestCase]
    public void Empty_Both_L1_And_L2_ListNodes()
    {
        ListNode l1 = new();
        ListNode l2 = new();

        var result = MergeTwoSortedLists.MergeTwoLists(l1, l2);
    }

    [TestCase]
    public void Empty_L1_Zero_L2_ListNodes()
    {
        ListNode l1 = null;
        ListNode l2 = new(0);

        var result = MergeTwoSortedLists.MergeTwoLists(l1, l2);
    }

    [TestCase]
    public void L1_Two_L2_One()
    {
        ListNode l1 = new(2);
        ListNode l2 = new(1);

        var result = MergeTwoSortedLists.SimpleMergeTwoLists(l1, l2);
    }
}