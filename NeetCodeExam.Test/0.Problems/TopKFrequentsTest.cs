namespace NeetCodeExam.Problems;

public class TopKFrequentsTest
{
    TopKFrequents app = new();

    [Fact]
    public void TestTopKFrequent_Success_Case1()
    {
        int[] nums = [1, 2, 2, 3, 3, 3];
        int k = 2;
        int[] result = app.TopKFrequent(nums, k);
        int[] want = [2, 3];
        Assert.Equivalent(want, result);
    }

    [Fact]
    public void TestTopKFrequent_Success_Case2()
    {
        int[] nums = [7, 7];
        int k = 1;
        int[] result = app.TopKFrequent(nums, k);
        int[] want = [7];
        Assert.Equivalent(want, result);
    }
}
