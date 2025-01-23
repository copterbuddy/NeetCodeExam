namespace NeetCodeExam.Sortings.MergeSorts;

public class MergeKListsTest
{
    private MergeKLists app = new();
    
    [Fact]
    public async Task Test_Case1()
    {
        ListNode list1_2 = new ListNode(4);
        ListNode list1_1 = new ListNode(2, list1_2);
        ListNode list1_0 = new ListNode(1, list1_1);
        
        ListNode list2_2 = new ListNode(5);
        ListNode list2_1 = new ListNode(3, list2_2);
        ListNode list2_0 = new ListNode(1, list2_1);
        
        ListNode list3_1 = new ListNode(6);
        ListNode list3_0 = new ListNode(3, list3_1);

        ListNode[] lists = [list1_0, list2_0, list3_0];
        
        
        ListNode want_8 = new ListNode(6);
        ListNode want_7 = new ListNode(5, want_8);
        ListNode want_6 = new ListNode(4, want_7);
        ListNode want_5 = new ListNode(3, want_6);
        ListNode want_4 = new ListNode(3, want_5);
        ListNode want_3 = new ListNode(2, want_4);
        ListNode want_2 = new ListNode(1, want_3);
        ListNode want_1 = new ListNode(1, want_2);

        ListNode result = app.Sort(lists);

        while (result != null)
        {
            Assert.Equal(want_1.val, result.val);
            result = result.next;
            want_1 = want_1.next;
        }
    }
    
    [Fact]
    public async Task Test_Case2()
    {
        int[][] input = [[1,2,4],[1,3,5],[3,6]];

        int[] want = [1,1,2,3,3,4,5,6];

        int[] result = app.Sort2(input);

        for (int i = 0; i < result.Length; i++)
        {
            Assert.Equal(want[i], result[i]);
        }
    }
}