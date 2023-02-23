using LeetCodeTests.classes.linkedLists;

namespace LeetCodeTests.UnitTests.linkedLists;

public class MiddleoftheLinkedListTests
{
    [TestCase]
    public void Simple_Odd_Middle()
    {
        ListNode l1 = new(1, new(2, new(3, new(4, new(5)))));
        var result = MiddleoftheLinkedList.MiddleNode(l1);
    }

    [TestCase]
    public void Simple_Even_Middle()
    {
        ListNode l1 = new(1, new(2, new(3, new(4, new(5, new(6))))));
        var result = MiddleoftheLinkedList.MiddleNode(l1);
    }

    [TestCase]
    public void Simple_One_Middle()
    {
        ListNode l1 = new(1);
        var result = MiddleoftheLinkedList.MiddleNode(l1);
    }

    [TestCase]
    public void Simple_Two_Even_Middle()
    {
        ListNode l1 = new(1, new(2));
        var result = MiddleoftheLinkedList.MiddleNode(l1);
    }

    [TestCase]
    public void Simple_Null_Middle()
    {
        ListNode l1 = null;
        var result = MiddleoftheLinkedList.MiddleNode(l1);
    }

    [TestCase]
    public void Simple_Zero_Middle()
    {
        ListNode l1 = new(0);
        var result = MiddleoftheLinkedList.MiddleNode(l1);
    }
}