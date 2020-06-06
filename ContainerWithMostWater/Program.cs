using System;

namespace ContainerWithMostWater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution max water area");

            int[] heights = new int[] { 1, 1 };

            Solution solution = new Solution();
            solution.MaxArea(heights);
        }
    }
}
