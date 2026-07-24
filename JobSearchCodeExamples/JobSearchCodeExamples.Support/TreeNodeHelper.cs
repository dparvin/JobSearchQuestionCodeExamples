namespace JobSearchCodeExamples.Support
{
    /// <summary>
    /// TreeNodeHelper class
    /// </summary>
    public static class TreeNodeHelper
    {
        /// <summary>
        /// Builds the tree.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public static TreeNode? BuildTree(int[] values)
        {
            if (values == null || values.Length == 0 || values[0] == 0)
                return null;

            var root = new TreeNode((int)values[0]);
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int index = 1;

            while (queue.Count > 0 && index < values.Length)
            {
                var node = queue.Dequeue();

                // Left child
                if (index < values.Length && values[index] != 0)
                {
                    node.left = new TreeNode(values[index]);
                    queue.Enqueue(node.left);
                }
                index++;

                // Right child
                if (index < values.Length && values[index] != 0)
                {
                    node.right = new TreeNode(values[index]);
                    queue.Enqueue(node.right);
                }
                index++;
            }

            return root;
        }
    }
}
