using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static NeetCodeExam.Program;

namespace NeetCodeExam.Test.LinkedLists.SinglyLinkedLists;

public class ReverseALinkedListTest
{
    [Fact]
    public async Task Test_ReverseALinkedList_Success_Case()
    {
        var node3 = new ListNode(3);
        var node2 = new ListNode(2, node3);
        var node1 = new ListNode(1, node2);
        var node0 = new ListNode(0, node1);

        ReverseALinkedList app = new();
        var result = app.ReverseList(node0);

        var node3r = new ListNode(0);
        var node2r = new ListNode(1, node3r);
        var node1r = new ListNode(2, node2r);
        var node0r = new ListNode(3, node1r);
        Assert.Equivalent(node0r, result);
    }
}
