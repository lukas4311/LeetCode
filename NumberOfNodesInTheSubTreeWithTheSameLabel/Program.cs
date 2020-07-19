using System;

namespace NumberOfNodesInTheSubTreeWithTheSameLabel
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            //int[][] edges = new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 1, 4 }, new int[] { 1, 5 }, new int[] { 2, 3 }, new int[] { 2, 6 } };
            //solution.CountSubTrees(7, edges, "abaedcd");

            int[][] edges = new int[][] { new int[] { 0, 2 }, new int[] { 0, 3 }, new int[] { 1, 2 } };
            solution.CountSubTrees(4, edges, "aeed");
        }
}
}
