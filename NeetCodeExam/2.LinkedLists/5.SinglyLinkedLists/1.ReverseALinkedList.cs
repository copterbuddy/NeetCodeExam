namespace NeetCodeExam;
partial class Program
{
    public class ReverseALinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;

            while (curr != null)
            {
                var nxt = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nxt;
            }

            return prev;
        }
    }
}