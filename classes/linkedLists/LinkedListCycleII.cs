using System.Collections;

namespace LeetCodeTests.classes.linkedLists
{
    public class LinkedListCycleII
    {
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