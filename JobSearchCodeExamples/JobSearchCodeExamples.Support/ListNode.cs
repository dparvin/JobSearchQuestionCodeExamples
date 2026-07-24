namespace JobSearchCodeExamples.Support
{
    /// <summary>
    /// Represents a node in a singly linked list.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="ListNode"/> class.
    /// </remarks>
    /// <param name="val">The value.</param>
    /// <param name="next">The next.</param>
    public class ListNode(
        int val = 0,
        ListNode? next = null)
    {
        /// <summary>
        /// The value
        /// </summary>
        public int val = val;
        /// <summary>
        /// The next
        /// </summary>
        public ListNode? next = next;
    }
}
