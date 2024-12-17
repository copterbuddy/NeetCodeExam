using static NeetCodeExam.Program;

namespace NeetCodeExam.Test.LinkedLists.SinglyLinkedLists;

public class MergeTwoSortedLinkedListsTest
{
    [Fact]
    public async Task MergeTwoSortedLinkedLists_Success_Case()
    {
        var node0_2 = new ListNode(4);
        var node0_1 = new ListNode(2, node0_2);
        var node0_0 = new ListNode(1, node0_1);

        var node1_2 = new ListNode(5);
        var node1_1 = new ListNode(3, node1_2);
        var node1_0 = new ListNode(1, node1_1);

        var app = new MergeTwoSortedLinkedLists();
        var result = app.MergeTwoLists(node0_0, node1_0);

        var node5r = new ListNode(5);
        var node4r = new ListNode(4, node5r);
        var node3r = new ListNode(3, node4r);
        var node2r = new ListNode(2, node3r);
        var node1r = new ListNode(1, node2r);
        var node0r = new ListNode(1, node1r);
        Assert.Equivalent(node0r, result);
    }
}
