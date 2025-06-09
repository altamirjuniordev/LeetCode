namespace LeetCode.Problems
{
    public static class MergeTwoSortedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode? next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode Solution(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            current.next = list1 ?? list2;

            return dummy.next;
        }

        public static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write($"{node.val} ");
                node = node.next;
            }
            Console.WriteLine();
        }
    }
}