using System;

namespace NeetCodeExam.Problems;

public class GroupsAnagrams
{
    public List<List<string>> GroupAnagrams_By_List(string[] strs)
    {
        Dictionary<string, List<string>> dict = new();
        foreach (string str in strs)
        {
            char[] ch = str.ToArray();
            Array.Sort(ch);
            string sortedStr = new string(ch);

            if (dict.ContainsKey(sortedStr))
            {
                dict[sortedStr].Add(str);
                continue;
            }

            dict.Add(sortedStr, new List<string>() { str });
        }
        return dict.Values.ToList();
    }
}
