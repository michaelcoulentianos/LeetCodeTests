namespace LeetCodeTests.classes.numbers;

public class MergeTwoSortedLists
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1?.val == 0 && list2?.val == 0) return new ListNode(0, new(0));
        ListNode head = null, current = null;

        if (list1 != null)
        {
            head = new ListNode(list1.val);
            list1 = list1?.next;
        }
        else if (list2 != null)
        {
            head = new ListNode(list2.val);
            list2 = list2?.next;

        }
        current = head;

        while (list1 != null || list2 != null)
        {
            if (list2?.val != null)
            {
                current.next = new ListNode(list2.val);
                current = current.next;
            }
            if (list1?.val != null)
            {
                current.next = new ListNode(list1.val);
                current = current.next;
            }

            list2 = list2?.next;
            list1 = list1?.next;
        }

        return head;
    }

    public static ListNode SimpleMergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1?.val == 0 && list2?.val == 0) return new ListNode(0, new(0));

        var test = new List<int>();

        while (list1 != null || list2 != null)
        {
            if (list2?.val != null) test.Add(list2.val);
            if (list1?.val != null) test.Add(list1.val);

            list2 = list2?.next;
            list1 = list1?.next;
        }

        test.Sort();

        ListNode head = null, current = null;

        foreach (var item in test)
        {
            if (head == null)
            {
                head = new(item);
                current = head;
            }
            else
            {
                current.next = new(item);
                current = current.next;
            }
        }

        return head;
    }
}