namespace NeetCodeExam.Problems;

public class EncodeAndDecodeStrings
{
    public string Encode(IList<string> strs)
    {
        string builder = string.Empty;
        foreach (var str in strs)
        {
            int length = str.Length;
            builder += length + "#" + str;
        }
        return builder;
    }

    public List<string> Decode(string s)
    {
        List<string> strs = new();
        int startIndexPosition = 0;
        while (startIndexPosition < s.Length)
        {
            int endIndexPosition = startIndexPosition;
            while (s[endIndexPosition].ToString() != "#")
            {
                endIndexPosition++;
            }
            int length;
            int.TryParse(s[startIndexPosition..endIndexPosition].ToString(), out length);
            strs.Add(s.Substring(endIndexPosition + 1, length));
            startIndexPosition = endIndexPosition + 1 + length;
        }
        return strs;
    }
}
