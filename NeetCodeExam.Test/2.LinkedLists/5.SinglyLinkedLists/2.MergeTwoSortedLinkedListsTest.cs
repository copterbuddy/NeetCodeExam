using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        // var node3r = new ListNode(0);
        // var node2r = new ListNode(1, node3r);
        // var node1r = new ListNode(2, node2r);
        // var node0r = new ListNode(3, node1r);
        // Assert.Equivalent(node0r, result);
        Assert.Equal(1, 0);

        //Input: list1 = [1,2,4], list2 = [1,3,5]
        //Output: [1,1,2,3,4,5]
    }
}
