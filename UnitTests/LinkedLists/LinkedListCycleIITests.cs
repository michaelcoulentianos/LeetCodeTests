
using LeetCodeTests.classes.linkedLists;

namespace LeetCodeTests.UnitTests.LinkedLists;

public class LinkedListCycleIITests
{
    [TestCase]
    public void Simple_Return_Position_1_Index()
    {
        ListNode l1 = new(3, new(2, new(0, new(-4, new(2)))));
        var result = LinkedListCycleII.DetectCycle(l1);
    }

    [TestCase]
    public void Simple_Return_No_Index_OneNode()
    {
        ListNode l1 = new(1, new(2));
        var result = LinkedListCycleII.DetectCycle(l1);
    }

    [TestCase]
    public void Simple_Return_No_Index_TwoNodes()
    {
        ListNode l1 = new(1, new(2, new(1)));
        var result = LinkedListCycleII.DetectCycle(l1);
    }

    //-1,-7,7,-4,19,6,-9,-5,-2,-5
    [TestCase]
    public void Complex()
    {
        ListNode l1 = new(-1, new(-7, new(7, new(-4, new(19, new(6, new(-9, new(-5, new(-2, new(-5))))))))));
        l1.next = new(-9,new(-5, new(-2, new(-5))));
        var result = LinkedListCycleII.DetectCycle(l1);
    }

}