namespace NeetCodeExam;
partial class Program
{
    public class MergeTwoSortedLinkedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode dummy = new();
            var tail = dummy;

            while (l1 is not null && l2 is not null)
            {
                if (l1.val < l2.val)
                {
                    tail.next = l1;
                    l1 = l1.next;
                }else{
                    tail.next = l2;
                    l2 = l2.next;
                }
                tail = tail.next;
            }

            if (l1 is not null)
            {
                tail.next = l1;
            }
            else if (l2 is not null)
            {
                tail.next = l2;
            }

            return dummy.next;
        }
    }
}