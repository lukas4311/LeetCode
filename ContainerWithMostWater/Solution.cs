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
            int leftPointerIndex = 0;
            int rightPointerIndex = height.Length - 1;
            int area;

            while (leftPointerIndex < rightPointerIndex)
            {
                area = (rightPointerIndex - leftPointerIndex) * Math.Min(height[leftPointerIndex], height[rightPointerIndex]);

                if (maxWaterArea < area)
                {
                    maxWaterArea = area;
                }

                if (height[leftPointerIndex] < height[rightPointerIndex])
                {
                    leftPointerIndex += 1;
                }
                else
                {
                    rightPointerIndex -= 1;
                }
            }

            return maxWaterArea;
        }
    }
}