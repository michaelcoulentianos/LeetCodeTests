using System.Text;
using LeetCodeTests.classes.CommonLogic.StringManipulations;

public class AddTwoNumbersLinkLists
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = new ListNode();
        var pointer = head;
        int curval = 0;
        while (l1 != null || l2 != null)
        {
            curval = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + curval;
            pointer.next = new ListNode(curval % 10);
            pointer = pointer.next;
            // overflow decimal, like 12, we keep 1 for the next loop
            curval = curval / 10;
            // if next l1/l2 is not null, go to the next node
            l1 = l1?.next;
            l2 = l2?.next;
        }
        // if there is overflow left, add a node
        if (curval != 0) pointer.next = new ListNode(curval);
        return head.next;
    }
}