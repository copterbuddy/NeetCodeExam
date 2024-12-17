using System;

namespace NeetCodeExam.Test.LinkedLists.DoublyLinkedLists;

public class MyLinkedListTest
{
    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */

    public MyLinkedListTest()
    {
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public async Task TestGetValueByIndex(int give)
    {
        MyLinkedList node2 = new MyLinkedList(2);
        MyLinkedList node1 = new MyLinkedList(1);
        MyLinkedList node0 = new MyLinkedList(0);
        node1.Next = node2;
        node0.Next = node1;

        int param_1 = node0.Get(give);
        Assert.Equal(give, param_1);
    }

    [Theory]
    [InlineData(3)]
    public async Task TestGetValueMoreThanIndex(int give)
    {
        MyLinkedList node2 = new MyLinkedList(2);
        MyLinkedList node1 = new MyLinkedList(1);
        MyLinkedList node0 = new MyLinkedList(0);
        node1.Next = node2;
        node0.Next = node1;

        int param_1 = node0.Get(give);
        Assert.Equal(-1, param_1);
    }

    [Fact]
    public async Task TestAddAtHead()
    {
    }

    [Fact]
    public async Task TestAddToEnd()
    {
    }

    [Fact]
    public async Task TestAddAtIndex()
    {
    }

    [Fact]
    public async Task DeleteAtIndex()
    {
    }

    [Fact]
    public async Task FullTest()
    {

        MyLinkedList myLinkedList = new MyLinkedList();
        myLinkedList.AddAtHead(1);
        myLinkedList.AddAtTail(3);
        myLinkedList.AddAtIndex(1, 2);    // linked list becomes 1->2->3
        int v = myLinkedList.Get(1);              // return 2
        myLinkedList.DeleteAtIndex(1);    // now the linked list is 1->3
        int v1 = myLinkedList.Get(1);              // return 3

    }
}
