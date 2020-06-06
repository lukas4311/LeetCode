using System;

namespace ContainerWithMostWater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution max water area");

            int[] heights = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            Solution solution = new Solution();
            solution.MaxArea(heights);
        }
    }
}
