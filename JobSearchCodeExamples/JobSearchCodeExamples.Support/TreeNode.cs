using System;
using System.Collections.Generic;
using System.Text;

namespace JobSearchCodeExamples.Support
{
    /// <summary>
    /// TreeNode class
    /// </summary>
    public class TreeNode
    {
        /// <summary>
        /// The value
        /// </summary>
        public int val;

        /// <summary>
        /// The position
        /// </summary>
        public int pos;

        /// <summary>
        /// The left
        /// </summary>
        public TreeNode? left;

        /// <summary>
        /// The right
        /// </summary>
        public TreeNode? right;

        /// <summary>
        /// Initializes a new instance of the <see cref="TreeNode" /> class.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <param name="pos">The position.</param>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        public TreeNode(int val = 0, int pos = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.pos = pos;
            this.left = left;
            this.right = right;
        }
    }

}
