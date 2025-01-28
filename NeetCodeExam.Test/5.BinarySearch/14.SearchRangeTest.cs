namespace NeetCodeExam.BinarySearch;

public class SearchRangeTest
{
    private SearchRange app = new();
    
    [Fact]
    public async Task Test_LowerBound_Case1()
    {
        int[] input = [1,3,5,7,9];
        int target = 5;
        int want = 2;
        
        int result = app.LowerBound(input, target);

        Assert.Equivalent(want, result);
    }
    
    [Fact]
    public async Task Test_LowerBound_Case2()
    {
        int[] input = [1,3,5,7,9];
        int target = 4;
        int want = 2;
        
        int result = app.LowerBound(input, target);

        Assert.Equivalent(want, result);
    }
    
    [Fact]
    public async Task Test_LowerBound_Case3()
    {
        int[] input = [1,3,5,7,9];
        int target = 3;
        int want = 1;
        
        int result = app.LowerBound(input, target);

        Assert.Equivalent(want, result);
    }
    
    [Fact]
    public async Task Test_UpperBound_Case1()
    {
        int[] input = [1,3,5,7,9];
        int target = 5;
        int want = 3;
        
        int result = app.UpperBound(input, target);

        Assert.Equivalent(want, result);
    }
    
    [Fact]
    public async Task Test_UpperBound_Case2()
    {
        int[] input = [1,3,5,7,9];
        int target = 4;
        int want = 2;
        
        int result = app.UpperBound(input, target);

        Assert.Equivalent(want, result);
    }
    
    [Fact]
    public async Task Test_UpperBound_Case3()
    {
        int[] input = [1,3,5,7,9];
        int target = 3;
        int want = 2;
        
        int result = app.UpperBound(input, target);

        Assert.Equivalent(want, result);
    }
}