namespace NeetCodeExam.Sortings.InsertionSorts;

public class InsertionSorts
{
    public List<List<Pair>> Sort(List<Pair> pairs)
    {
        List<List<Pair>> result = [];
        for (int i = 0; i < pairs.Count; i++)
        {
            int j = i - 1;
            while (j >= 0 && pairs[j].Key > pairs[j + 1].Key)
            {
                Pair tmp = pairs[j + 1];
                pairs[j + 1] = pairs[j];
                pairs[j] = tmp;
                j--;
            }
            result.Add(new(pairs));
        }

        return result;
    }
}
