namespace tests;

public class AddTwoNumbersLinkListsTests
{
    [TestCase(ExpectedResult = true)]
    public bool Simple()
    {
        ListNode l1 = new(2, new(4, new(3)));
        ListNode l2 = new(5, new(6, new(4)));

       var result = AddTwoNumbersLinkLists.AddTwoNumbers(l1, l2);

        return true;
    }

[TestCase(ExpectedResult = true)]
     public bool Zero()
    {
        ListNode l1 = new(0);
        ListNode l2 = new(0);

       var result = AddTwoNumbersLinkLists.AddTwoNumbers(l1, l2);

        return true;
    }
}