using System.Collections;

namespace LeetCodeTests.classes.linkedLists
{
    public class LinkedListCycleII
    {
        // public static ListNode DetectCycle(ListNode head)
        // {
        //     ListNode current = head;
        //     Hashtable ht = new();
        //     int index = 0;
        //     int position = 0;
        //     while (current?.next != null)
        //     {
        //         if (ht.ContainsKey(current.val))
        //         {
        //             position = (int)ht[current.val];
        //             break;
        //         }
        //         ht.Add(current.val, index++);
        //         current = current.next;
        //     }

        //     for (int i = 0; i < position; i++) head = head.next;

        //     if (head?.next?.next is null) return head?.next?.next;

        //     return head;
        // }

        public static ListNode DetectCycle(ListNode head)
        {
            ListNode current = head;
            HashSet<ListNode> ht = new();

            while (current != null)
            {
                if (ht.Contains(current))
                {
                    return current;
                }
                ht.Add(current);
                current = current.next;
            }

            return null;
        }

        public static ListNode BetterDetectCycle(ListNode head)
        {
            ListNode start = head;
            ListNode slow = head;
            ListNode fast = head;

            while (slow.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    fast = start;
                    while (fast != slow)
                    {
                        fast = fast.next;
                        slow = slow.next;
                    }
                    return fast;
                }
            }

            return null;
        }
    }
}