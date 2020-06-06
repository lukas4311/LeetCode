using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            if(height.Length < 2)
            {
                return 0;
            }

            int maxWaterArea = 0;
            int minHeight;
            int maxFoundHeight = 0;

            for (int i = 0; i < height.Length - 1; i++)
            {
                if (height[i] < maxFoundHeight)
                {
                    continue;
                }
                else
                {
                    maxFoundHeight = height[i];
                }

                for (int j = i + 1; j < height.Length; j++)
                {
                    if (height[i] > height[j])
                    {
                        minHeight = height[j];
                    }
                    else
                    {
                        minHeight = height[i];
                    }

                    if (maxWaterArea < minHeight * (j - i))
                    {
                        maxWaterArea = minHeight * (j - i);
                    }
                }
            }

            return maxWaterArea;
        }
    }
}