namespace NeetCodeExam.Problems;

public class ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> sDict = new();
        foreach (char s2 in s)
        {
            if (sDict.ContainsKey(s2) == false)
            {
                sDict.Add(s2, 1);
                continue;
            }

            _ = sDict.TryGetValue(s2, out int tmpVal);
            sDict.Remove(s2);
            sDict.Add(s2, tmpVal + 1);
        }

        Dictionary<char, int> tDict = new();
        foreach (char t2 in t)
        {
            if (tDict.ContainsKey(t2) == false)
            {
                tDict.Add(t2, 1);
                continue;
            }

            _ = tDict.TryGetValue(t2, out int tmpVal);
            tDict.Remove(t2);
            tDict.Add(t2, tmpVal + 1);
        }

        foreach (KeyValuePair<char, int> kv in sDict)
        {
            bool canGet = tDict.TryGetValue(kv.Key, out int tmpVal);
            if (canGet == false)
            {
                return false;
            }

            if (kv.Value != tmpVal)
            {
                return false;
            }
        }

        return true;
    }

    public bool IsAnagram_improved(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> sDict = new();
        foreach (char s2 in s)
        {
            if (sDict.ContainsKey(s2) == false)
            {
                sDict.Add(s2, 1);
                continue;
            }

            sDict[s2] += 1;
        }
        int sDictLength = sDict.Count;

        foreach (char t2 in t)
        {
            if (sDict.ContainsKey(t2) == false)
            {
                return false;
            }

            sDict[t2] -= 1;
            if (sDict[t2] < 0)
            {
                return false;
            }

            if (sDict[t2] == 0)
            {
                sDictLength -= 1;
            }
        }

        return sDictLength == 0;
    }
}
