using System.Collections.Generic;
using System.Linq;

namespace NumberOfNodesInTheSubTreeWithTheSameLabel
{
    public class Solution
    {
        public int[] CountSubTrees(int n, int[][] edges, string labels)
        {
            Node[] nodes = new Node[n];
            nodes[0] = new Node
            {
                letter = labels[0],
                subNodes = new List<Node>(),
                subnodeLetters = new List<char> { labels[0] }
            };

            for (int i = 1; i <= edges.Length; i++)
            {
                nodes[i] = new Node
                {
                    letter = labels[i],
                    subNodes = new List<Node>(),
                    subnodeLetters = new List<char> { labels[i] }
                };
            }

            for (int i = 0; i < edges.Length; i++)
            {
                nodes[edges[i][0]].subNodes.Add(nodes[edges[i][1]]);
            }

            int[] result = new int[n];

            for (int i = nodes.Length - 1; i >= 0; i--)
            {
                foreach (Node node in nodes[i].subNodes)
                {
                    nodes[i].subnodeLetters.AddRange(node.subnodeLetters);
                }

                result[i] = nodes[i].subnodeLetters.Count(d => d == nodes[i].letter);
            }

            return result;
        }

        struct Node
        {
            public List<Node> subNodes;

            public char letter;

            public List<char> subnodeLetters;
        }
    }
}
