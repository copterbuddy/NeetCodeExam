using System;

namespace NeetCodeExam.Problems;

public class TrappingRainWaters
{
    public int Trap(int[] height)
    {
        int l = 0, r, maxL = 0, maxR = 0, trap = 0;
        r = height.Length - 1;
        while (l < r)
        {
            if (height[r] < height[l])
            {
                if (height[r] <= maxR)
                {
                    trap += Math.Max(maxR - height[r], 0);
                }
                else
                {
                    maxR = height[r];
                }

                r--;
            }
            else
            {
                if (height[l] <= maxL)
                {
                    trap += Math.Max(maxL - height[l], 0);
                }
                else
                {
                    maxL = height[l];
                }

                l++;
            }
        }

        return trap;
    }
}
