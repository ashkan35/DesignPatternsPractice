using System.Collections.Generic;

namespace Composite
{
    public class Group:INode
    {
        public List<INode> Nodes { get; set; }
        public string Name { get; set; }

        public int Score
        {
            get
            {
                var score = 0;
                foreach (var node in Nodes)
                {
                    score += node.Score;
                }

                return score;
            }
            set
            {
                var scorePerNode = value / Nodes.Count;
                foreach (var node in Nodes)
                {
                    node.Score = scorePerNode;
                }
            }
        }
    }
}