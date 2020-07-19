﻿namespace WaterBottles
{
    public class Solution
    {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            int sum = numBottles;

            while (numBottles >= numExchange)
            {
                sum += numBottles / numExchange;
                numBottles = (numBottles % numExchange) + (numBottles / numExchange);
            }

            return sum;
        }
    }
}
