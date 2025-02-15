namespace NeetCodeExam.Problems;

public class ContainDuplicateTest
{
    ContainDuplicate app = new();

    [Fact]
    public void TestContainDuplicate_Want_True_Success_Case1()
    {
        int[] nums = [1, 2, 3, 1];
        bool result = app.ContainsDuplicate(nums);
        Assert.True(result);
    }

    [Fact]
    public void TestContainDuplicate_Want_False_Success_Case1()
    {
        int[] nums = [1, 2, 3, 4];
        bool result = app.ContainsDuplicate(nums);
        Assert.False(result);
    }
}
