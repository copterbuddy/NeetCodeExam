namespace NeetCodeExam.BinarySearch;

public class SearchArrayTest
{
    private SearchArray app = new();
    
    [Fact]
    public async Task Test_Case1()
    {
        int[] input = [1,2,3,4,5,6,7,8,9,10];
        int searchValue = 5;
        
        int result = app.GetNumber(input, searchValue);

        Assert.Equivalent(4, result);
    }
    
    [Fact]
    public async Task Test_Case2()
    {
        int[] input = [1,2,3,4,5,6,7,8,9,10];
        int searchValue = 8;
        
        int result = app.GetNumber(input, searchValue);

        Assert.Equivalent(7, result);
    }
    
    [Fact]
    public async Task Test_Case3()
    {
        int[] input = [1,2,3,4,5,6,7,8,9,10];
        int searchValue = 0;
        
        int result = app.GetNumber(input, searchValue);

        Assert.Equivalent(-1, result);
    }
    
    [Fact]
    public async Task Test_Case4()
    {
        int[] input = [1,2,3,4,5,6,7,8,9,10];
        int searchValue = 11;
        
        int result = app.GetNumber(input, searchValue);

        Assert.Equivalent(-1, result);
    }
}