using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeExam.Test.Stacks.MinStack;

public class TestMinStack
{
    [Fact]
    public void TestTestMinStack_Success_Case1()
    {
        Program.MinStack minStack = new Program.MinStack();
        minStack.Push(-2);
        minStack.Push(0);
        minStack.Push(-3);
        minStack.GetMin(); // return -3
        minStack.Pop();
        minStack.Top();    // return 0
        minStack.GetMin(); // return -2
    }

    [Fact]
    public void TestTestMinStack_Success_Case2()
    {
        Program.MinStack minStack = new Program.MinStack();
        minStack.Push(2);
        minStack.Push(0);
        minStack.Push(3);
        minStack.Push(0);
        minStack.GetMin(); // return 0
        minStack.Pop();
        minStack.GetMin(); // return 0
        minStack.Pop();
        minStack.GetMin(); // return 0
        minStack.Pop();
        minStack.GetMin(); // return 2
    }
}
