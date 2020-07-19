using System.Collections.Generic;
using System.Linq;

namespace NumberOfNodesInTheSubTreeWithTheSameLabel
{
    public class Solution
    {
        public int[] CountSubTrees(int n, int[][] edges, string labels)
        {
            List<List<int>> adj = new List<List<int>>(n);

            for (int i = 0; i < n; i++)
                adj.Add(new List<int>());

            for (int i = 0; i < edges.Length; i++)
            {
                adj[edges[i][0]].Add(edges[i][1]);
                adj[edges[i][1]].Add(edges[i][0]);
            }

            int[] ans = new int[n];
            int[] visited = new int[n];
            Dfs(adj, 0, labels, visited, ans);
            return ans;
        }

        private int[] Dfs(List<List<int>> adj, int root, string labels, int[] visited, int[] ans)
        {
            if (visited[root] == 1)
                return new int[26];

            int[] charCount = new int[26];
            charCount[labels[root] - 'a']++;
            visited[root] = 1;

            for (int i = 0; i < adj[root].Count; i++)
            {
                int[] chCnt = Dfs(adj, adj[root][i], labels, visited, ans);

                for (int j = 0; j < 26; j++)
                    charCount[j] += chCnt[j];
            }

            ans[root] = charCount[labels[root] - 'a'];

            return charCount;
        }
    }
}
