using System;

namespace NeetCodeExam;

public class MyLinkedList
{

    public int Val { get; set; }

    public MyLinkedList NodeResult { get; set; }
    public MyLinkedList Next { get; set; }
    public MyLinkedList Prev { get; set; }

    //public MyLinkedList Head { get; set; } = new MyLinkedList();
    //public MyLinkedList Tail { get; set; } = new MyLinkedList();

    public MyLinkedList(int val = 0)
    {
        Val = val;
    }

    public int Get(int index)
    {
        MyLinkedList dummy = this;
        int i = 0;
        while (i < index)
        {
            dummy = dummy.Next;
            i++;
        }

        return dummy?.Val ?? -1;
    }

    public void AddAtHead(int val)
    {
    }

    public void AddAtTail(int val)
    {

    }

    public void AddAtIndex(int index, int val)
    {
    }

    public void DeleteAtIndex(int index) 
    {
    }


}
