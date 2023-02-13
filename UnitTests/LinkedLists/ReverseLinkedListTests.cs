using LeetCodeTests.classes.linkedLists;

namespace LeetCodeTests.UnitTests.LinkedLists;

public class ReverseLinkedListTests
{
    [TestCase]
    public void Simple_Reverse()
    {
        ListNode l1 = new(1, new(2, new(4)));
        var result = ReverseLinkedList.ReverseList(l1);
    }
}
