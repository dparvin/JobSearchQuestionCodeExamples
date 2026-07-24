namespace JobSearchCodeExamples.Support
{
    /// <summary>
    /// Represents a node in an undirected graph.
    /// </summary>
    public class GraphNode
    {
        /// <summary>
        /// The value
        /// </summary>
        public int val;
        /// <summary>
        /// The neighbors
        /// </summary>
        public IList<GraphNode> neighbors;

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNode"/> class.
        /// </summary>
        public GraphNode()
        {
            val = 0;
            neighbors = [];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNode"/> class.
        /// </summary>
        /// <param name="_val">The value.</param>
        public GraphNode(int _val)
        {
            val = _val;
            neighbors = [];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNode"/> class.
        /// </summary>
        /// <param name="_val">The value.</param>
        /// <param name="_neighbors">The neighbors.</param>
        public GraphNode(int _val, List<GraphNode> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
}
