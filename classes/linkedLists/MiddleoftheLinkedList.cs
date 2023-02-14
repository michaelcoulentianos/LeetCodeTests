namespace LeetCodeTests.classes.linkedLists
{
    public class MiddleoftheLinkedList
    {
        public static ListNode MiddleNode(ListNode head)
        {
            ListNode current = head;
            int numberOfNodes = new();

            while (current != null)
            {
                numberOfNodes++;
                current = current?.next;
            }
            int quotient = numberOfNodes / 2;
            if (quotient == 0) quotient = 1;

            ListNode pointer = head;
            int counter = new();
            while (counter != quotient)
            {
                if (pointer?.next == null) return pointer;
                pointer = pointer.next;
                counter++;
                if (counter == quotient)
                return pointer;
            }

            return null;
        }
    }
}