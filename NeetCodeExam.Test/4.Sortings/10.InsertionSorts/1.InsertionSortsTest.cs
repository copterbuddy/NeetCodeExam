namespace NeetCodeExam.Sortings;

public class InsertionSortsTest
{
    InsertionSorts app = new();

    [Fact]
    public async Task Test_Case1()
    {
        List<Pair> pairs = [new(5, "apple"), new(2, "banana"), new(9, "cherry")];
        var result = app.Sort(pairs);

        List<List<Pair>> want = [
            [new(5, "apple"), new(2, "banana"), new(9, "cherry")],
            [new(2, "banana"), new(5, "apple"), new(9, "cherry")],
            [new(2, "banana"), new(5, "apple"), new(9, "cherry")]
        ];

        Assert.Equivalent(want[0][0], result[0][0]);
        Assert.Equivalent(want[0][1], result[0][1]);
        Assert.Equivalent(want[0][2], result[0][2]);
        Assert.Equivalent(want[1][0], result[1][0]);
        Assert.Equivalent(want[1][1], result[1][1]);
        Assert.Equivalent(want[1][2], result[1][2]);
        Assert.Equivalent(want[2][0], result[2][0]);
        Assert.Equivalent(want[2][1], result[2][1]);
        Assert.Equivalent(want[2][2], result[2][2]);
    }

    [Fact]
    public async Task Test_Case2()
    {
        List<Pair> pairs = [new(3, "cat"), new(3, "bird"), new(2, "dog")];
        var result = app.Sort(pairs);

        List<List<Pair>> want = [
            [new(3, "cat"), new(3, "bird"), new(2, "dog")],
            [new(3, "cat"), new(3, "bird"), new(2, "dog")],
            [new(2, "dog"), new(3, "cat"), new(3, "bird")]
        ];

        Assert.Equivalent(want[0][0], result[0][0]);
        Assert.Equivalent(want[0][1], result[0][1]);
        Assert.Equivalent(want[0][2], result[0][2]);
        Assert.Equivalent(want[1][0], result[1][0]);
        Assert.Equivalent(want[1][1], result[1][1]);
        Assert.Equivalent(want[1][2], result[1][2]);
        Assert.Equivalent(want[2][0], result[2][0]);
        Assert.Equivalent(want[2][1], result[2][1]);
        Assert.Equivalent(want[2][2], result[2][2]);
    }
}
