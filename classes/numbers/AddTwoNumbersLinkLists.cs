public class AddTwoNumbersLinkLists
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        string first = $"{l1.val}", second = $"{l2.val}";
        //it's a stack approach add number as first index to string (while)
        while (l1.next != null)
        {
            l1 = l1.next;
            l2 = l2.next;
            first += l1.val;
            second += l2.val;
        }
        //convert to number plus together 
        int sum = int.Parse(first) + int.Parse(second);
        char[] nums = $"{sum}".ToArray();

        //add back to ListNode
        return AddListNode(nums);
    }

    public static ListNode AddListNode<T>(T input) where T : IEnumerable<char>
    {
        //add back to ListNode
        ListNode? head = null, current = null;

        foreach (var item in input.Reverse())
        {
            var node = new ListNode((int)Char.GetNumericValue(item));
            if (head == null)
            {
                head = node;
                current = head;
            }
            else
            {
                current.next = node;
                current = current.next;
            }
        }
        return head;
    }
}