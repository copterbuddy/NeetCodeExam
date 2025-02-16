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

    public List<List<string>> GroupAnagrams_By_Map(string[] strs)
    {
        var res = new Dictionary<string, List<string>>();
        foreach (var s in strs)
        {
            int[] count = new int[26];
            foreach (char c in s)
            {
                count[c - 'a']++;
            }
            string key = string.Join(",", count);
            if (!res.ContainsKey(key))
            {
                res[key] = new List<string>();
            }
            res[key].Add(s);
        }
        return res.Values.ToList<List<string>>();
    }
}
