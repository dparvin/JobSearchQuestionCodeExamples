namespace JobSearchCodeExamples.TestTaker
{
    /// <summary>
    /// Class for doing things with linked lists
    /// </summary>
    public static class LinkedLists
    {
        /// <summary>
        /// Reverses the list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public static LinkedList<T>? ReverseList<T>(LinkedList<T>? list)
        {
            LinkedList<T> results = new();
            if (list == null || list.Count == 0) return list;
            LinkedListNode<T>? currentItem = list.First;
            while (currentItem != null)
            {
                results.AddFirst(currentItem.Value);
                currentItem = currentItem.Next;
            }

            return results;
        }

    }
}
