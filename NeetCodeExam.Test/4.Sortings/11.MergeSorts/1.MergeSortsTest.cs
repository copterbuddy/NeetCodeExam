namespace NeetCodeExam.Sortings.MergeSorts;

public class MergeSortsTest
{
    MergeSorts app = new();

    [Fact]
    public async Task Test_Case1()
    {
        int[] input = [3, 2, 3];

        int[] want = [2, 3, 3];

        int[] result = app.Sort(input);

        Assert.Equal(want[0], result[0]);
        Assert.Equal(want[1], result[1]);
        Assert.Equal(want[2], result[2]);
    }
}
