namespace NeetCodeExam.Sortings.QuickSort;

public class QuickSortTest
{
    private QuickSort app = new();
    
    [Fact]
    public async Task Test_Case0()
    {
        int[] input = [13, 11, 19, 14, 15];

        int[] want = [11, 13, 14, 15, 19];
        
        var result = app.Sort(input);

        Assert.Equivalent(want[0], result[0]);
        Assert.Equivalent(want[1], result[1]);
        Assert.Equivalent(want[2], result[2]);
    }

    [Fact]
    public async Task Test_Case1()
    {
        List<Pair> pairs = [new(3, "cat"), new(3, "bird"), new(2, "dog")];

        List<Pair> want = [new(2, "dog"), new(3, "bird"), new(3, "cat")];
        
        var result = app.Sort(pairs);

        Assert.Equivalent(want[0].Key, result[0].Key);
        Assert.Equivalent(want[1].Key, result[1].Key);
        Assert.Equivalent(want[2].Key, result[2].Key);
    }

    [Fact]
    public async Task Test_Case2()
    {
        List<Pair> pairs = [new(5, "apple"), new(9, "banana"), new(9, "cherry"), new(1, "date"), new(9, "elderberry")];
        var result = app.Sort(pairs);

        List<Pair> want = [new(1, "date"), new(5, "apple"), new(9, "elderberry"), new(9, "cherry"), new(9, "banana")];

        Assert.Equivalent(want[0], result[0]);
        Assert.Equivalent(want[1], result[1]);
        Assert.Equivalent(want[2], result[2]);
        Assert.Equivalent(want[2], result[3]);
        Assert.Equivalent(want[2], result[4]);
    }
}