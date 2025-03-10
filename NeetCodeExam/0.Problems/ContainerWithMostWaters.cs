using System;

namespace NeetCodeExam.Problems;

public class ContainerWithMostWaters
{
    public int MaxArea(int[] heights)
    {
        int l = 0;
        int r = heights.Length - 1;
        int maxArea = 0;
        while (l < r)
        {
            int area = (r - l) * Math.Min(heights[r], heights[l]);
            maxArea = Math.Max(maxArea, area);

            if (r <= l)
            {
                r--;
            }
            else
            {
                l++;
            }
        }
        return maxArea;
    }
}
