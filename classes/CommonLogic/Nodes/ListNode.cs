using System.Text;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
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

    public static string AppendToString(ListNode input)
    {
        var result = new StringBuilder($"{input.val}");
        while (input?.next != null)
        {
            input = input.next;
            result.Append(input?.val);
        }
        return result.ToString();
    }
}