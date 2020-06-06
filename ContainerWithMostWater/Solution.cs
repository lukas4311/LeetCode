using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int maxWaterArea = 0;
            int maxFoundHeight = 0;

            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i; j < height.Length - i; j++)
                {
                    if(height[j] > maxFoundHeight)
                    {

                    }
                }
            }

            return maxWaterArea;
        }
    }
}