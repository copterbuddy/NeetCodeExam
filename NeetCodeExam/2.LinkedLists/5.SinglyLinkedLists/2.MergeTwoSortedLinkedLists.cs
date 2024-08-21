namespace NeetCodeExam;
partial class Program
{
    public class MergeTwoSortedLinkedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode mergeList = null;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    if (mergeList == null)
                    {
                        mergeList = list2;
                        list2 = list2.next;
                        continue;
                    }

                    mergeList.next = list2;
                    list2 = list2.next;
                    continue;
                }

                if (mergeList == null)
                {
                    mergeList = list1;
                    list1 = list1.next;
                    continue;
                }

                mergeList.next = list1;
                list1 = list1.next;
                continue;
            }


            return default;
        }
    }
}