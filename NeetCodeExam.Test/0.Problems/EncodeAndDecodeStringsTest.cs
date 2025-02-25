namespace NeetCodeExam.Problems;

public class EncodeAndDecodeStringsTest
{
    EncodeAndDecodeStrings app = new();

    [Fact]
    public void TestEncodeDecode_Success_Case1()
    {
        List<string> input = ["neet", "code", "love", "you"];
        string enCoded = app.Encode(input);
        List<string> deCoded = app.Decode(enCoded);

        Assert.Equivalent(input, deCoded);
    }

    [Fact]
    public void TestEncodeDecode_Success_Case2()
    {
        List<string> input = ["we", "say", ":", "yes"];
        string enCoded = app.Encode(input);
        List<string> deCoded = app.Decode(enCoded);

        Assert.Equivalent(input, deCoded);
    }
}
