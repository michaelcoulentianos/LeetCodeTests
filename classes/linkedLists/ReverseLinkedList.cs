namespace LeetCodeTests.classes.linkedLists;

public class ReverseLinkedList
{
    public static ListNode ReverseList(ListNode head)
    {
        ListNode current = new();
        current = head;

        Stack<int> numbers = new();

        while (current != null)
        {
            numbers.Push(current.val);
            current = current.next;
        }

        ListNode result = null, pointer = null;

        foreach (var item in numbers)
        {
            if (result == null)
            {
                result = new(item);
                pointer = result;
            }
            else
            {
                pointer.next = new(item);
                pointer = pointer.next;
            }
        }

        return result;
    }
}