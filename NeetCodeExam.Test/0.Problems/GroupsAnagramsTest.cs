namespace NeetCodeExam.Problems;

public class GroupsAnagramsTest
{
    GroupsAnagrams app = new();

    [Fact]
    public void TestGroupAnagrams_By_List_Success_Case1()
    {
        string[] strs = ["act", "pots", "tops", "cat", "stop", "hat"];
        List<List<string>> result = app.GroupAnagrams_By_List(strs);
        List<List<string>> want = [["hat"], ["act", "cat"], ["stop", "pots", "tops"]];
        Assert.Equivalent(want, result);
    }
}
