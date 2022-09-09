namespace JobSearchCodeExamples.TestTaker;

/// <summary>
/// Questions from LeetCode
/// </summary>
public static class LeetCode
{
    #region FizzBuzz Code -------------------------------------------

    // These are the 6 different tries I did to answer the question.
    // Each of them is a little different, mostly to try to speed up
    // the process, but some of them to also get a smaller memory 
    // footprint.

    /// <summary>
    /// Fizz and buzz items.
    /// </summary>
    /// <param name="n">The n.</param>
    /// <returns></returns>
    public static IList<string> FizzBuzz(int n)
    {
        var result = new List<string>();
        for (var i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                result.Add("FizzBuzz");
            else if (i % 3 == 0)
                result.Add("Fizz");
            else if (i % 5 == 0)
                result.Add("Buzz");
            else
                result.Add(i.ToString());
        }
        return result;
    }

    /// <summary>
    /// Fizz and buzz items.
    /// </summary>
    /// <param name="n">The n.</param>
    /// <returns></returns>
    public static IList<string> FizzBuzz2(int n)
    {
        var result = new string[n];
        for (var i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                result[i - 1] = "FizzBuzz";
            else if (i % 3 == 0)
                result[i - 1] = "Fizz";
            else if (i % 5 == 0)
                result[i - 1] = "Buzz";
            else
                result[i - 1] = i.ToString();
        }
        return result;
    }

    /// <summary>
    /// Fizz and buzz items.
    /// </summary>
    /// <param name="n">The n.</param>
    /// <returns></returns>
    public static IList<string> FizzBuzz3(int n)
    {
        var result = new string[n];
        for (var i = 0; i < n; i++)
        {
            var byThree = (i + 1) % 3 == 0;
            var byFive = (i + 1) % 5 == 0;
            result[i] = string.Empty;
            if (byThree || byFive)
            {
                if (byThree)
                    result[i] += "Fizz";
                if (byFive)
                    result[i] += "Buzz";
            }
            else
                result[i] = (i + 1).ToString();
        }
        return result;
    }

    /// <summary>
    /// Fizz and buzz items.
    /// </summary>
    /// <param name="n">The n.</param>
    /// <returns></returns>
    public static IList<string> FizzBuzz4(int n)
    {
        var result = new string[n];
        for (var i = 0; i < n; i++)
        {
            var byThree = (i + 1) % 3 == 0;
            var byFive = (i + 1) % 5 == 0;
            if (byThree && byFive)
                result[i] = "FizzBuzz";
            else if (byThree)
                result[i] = "Fizz";
            else if (byFive)
                result[i] = "Buzz";
            else
                result[i] = (i + 1).ToString();
        }
        return result;
    }

    /// <summary>
    /// Fizz and buzz items.
    /// </summary>
    /// <param name="n">The n.</param>
    /// <returns></returns>
    public static IList<string> FizzBuzz5(int n)
    {
        var result = new string[n];
        for (var i = 0; i < n; i++)
        {
            var value = i + 1;
            var byThree = value % 3 == 0;
            var byFive = value % 5 == 0;
            if (byThree && byFive)
                result[i] = "FizzBuzz";
            else if (byThree)
                result[i] = "Fizz";
            else if (byFive)
                result[i] = "Buzz";
            else
                result[i] = value.ToString();
        }
        return result;
    }

    /// <summary>
    /// Fizz and buzz items.
    /// </summary>
    /// <param name="n">The n.</param>
    /// <returns></returns>
    public static IList<string> FizzBuzz6(int n)
    {
        string[] result = new string[n];
        for (var i = 0; i < n; i++)
        {
            int value = i + 1;
            bool byThree = value % 3 == 0;
            bool byFive = value % 5 == 0;
            if (byThree && byFive)
                result[i] = "FizzBuzz";
            else if (byThree)
                result[i] = "Fizz";
            else if (byFive)
                result[i] = "Buzz";
            else
                result[i] = value.ToString();
        }
        return result;
    }

    #endregion

    #region Middle of the linked list -------------------------------

    /// <summary>
    /// Middles the node.
    /// </summary>
    /// <param name="head">The head.</param>
    /// <returns></returns>
    public static ListNode? MiddleNode(ListNode? head)
    {
        if (head == null || head.next == null) return head;
        int items = Count(head);
        int mid = items / 2;
        ListNode? curr = head;
        for (var i = 0; i < mid; i++)
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            curr = curr.next;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        return curr;
    }

    #endregion

    #region Palindrome Linked List? ---------------------------------

    /// <summary>
    /// Determines whether the specified head is palindrome.
    /// </summary>
    /// <param name="head">The head.</param>
    /// <returns>
    ///   <c>true</c> if the specified head is palindrome; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsPalindrome(ListNode? head)
    {
        ListNode back = new();
        ListNode? curr = head;
        if (curr == null) return true;
        back.val = curr.val;
        curr = curr.next;
        while (curr != null)
        {
            ListNode newItem = new(curr.val, back);
            back = newItem;
            curr = curr.next;
        }
        curr = head;
        ListNode? rev = back;
        while (curr != null)
        {
            if (curr.val != rev?.val) return false;
            curr = curr.next;
            rev = rev.next;
        }
        return true;
    }

    /// <summary>
    /// Determines whether the specified head is palindrome2.
    /// </summary>
    /// <param name="head">The head.</param>
    /// <returns>
    ///   <c>true</c> if the specified head is palindrome2; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsPalindrome2(ListNode? head)
    {
        if (head?.next == null) return true;

        var curr = head;
        var rev = Reverse(head);
        while (curr != null)
        {
            if (curr.val != rev?.val)
                return false;
            curr = curr.next;
            rev = rev.next;
        }
        return true;
    }

    /// <summary>
    /// Determines whether the specified head is palindrome3.
    /// </summary>
    /// <param name="head">The head.</param>
    /// <returns>
    ///   <c>true</c> if the specified head is palindrome3; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsPalindrome3(ListNode? head)
    {
        if (head?.next == null) return true;

        var midPoint = PalindromeCount(head) / 2 + 1;
        var curr = head;
        var rev = Reverse(curr);
        int count = 0;
        while (curr != null)
        {
            if (curr.val != rev?.val)
                return false;
            if (count > midPoint) break; // past the midpoint so we are done
            curr = curr.next;
            rev = rev.next;
            count++;
        }
        return true;
    }

    #endregion

    #region Add Two Number ------------------------------------------

    /// <summary>
    /// Adds the two numbers.
    /// </summary>
    /// <param name="l1">The l1.</param>
    /// <param name="l2">The l2.</param>
    /// <returns></returns>
    public static ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        if (l1 == null) return l2;
        if (l2 == null) return l1;
        int carry = 0;
        int a = l1.val;
        int b = l2.val;
        ListNode result = new();
        while (l1 != null || l2 != null)
        {
            result.val = a + b + carry;
            if (result.val > 9)
            {
                carry = 1;
                result.val %= 10;
            }
            else
                carry = 0;
            if (l1 != null)
            {
                l1 = l1.next;
                a = l1 == null ? 0 : l1.val;
            }
            if (l2 != null)
            {
                l2 = l2.next;
                b = l2 == null ? 0 : l2.val;
            }
            if (l1 != null || l2 != null)
                result = new ListNode(0, result);
            else if (carry > 0)
                result = new ListNode(carry, result);
        }

        return Reverse(result);
    }

    #endregion

    #region Median of Two Sorted Arrays -----------------------------

    /// <summary>
    /// Finds the median sorted arrays.
    /// </summary>
    /// <param name="nums1">The nums1.</param>
    /// <param name="nums2">The nums2.</param>
    /// <returns></returns>
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        double result = 0;
        int arrayLenth = 0;
        if (nums1 != null) arrayLenth += nums1.Length;
        if (nums2 != null) arrayLenth += nums2.Length;
        if (arrayLenth == 0) return result;
        int[] temp = new int[arrayLenth];
        int Start = 0;
        if (nums1 != null)
        {
            Array.Copy(nums1, 0, temp, Start, nums1.Length);
            Start = nums1.Length;
        }
        if (nums2 != null)
            Array.Copy(nums2, 0, temp, Start, nums2.Length);
        Array.Sort(temp);
        if (arrayLenth % 2 == 0)
        {
            int pos = (arrayLenth / 2) - 1;
            result = ((double)(temp[pos] + temp[pos + 1])) / 2;
        }
        else
            result = temp[arrayLenth / 2];

        return result;
    }

    #endregion

    #region single linked list --------------------------------------

    /// <summary>
    /// Definition for singly-linked list.
    /// </summary>
    public class ListNode
    {
        /// <summary>
        /// The value
        /// </summary>
        public int val;
        /// <summary>
        /// The next
        /// </summary>
        public ListNode? next;
        /// <summary>
        /// Initializes a new instance of the <see cref="ListNode"/> class.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <param name="next">The next.</param>
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    #endregion

    #region Private Support Routines --------------------------------

    /// <summary>
    /// Reverses the specified head.
    /// </summary>
    /// <param name="head">The head.</param>
    /// <returns></returns>
    private static ListNode? Reverse(ListNode? head)
    {
        ListNode? result = null;
        var curr = head;
        while (curr != null)
        {
            result = new(curr.val, result);
            curr = curr.next;
        }
        return result;
    }

    /// <summary>
    /// Counts the specified head.
    /// </summary>
    /// <param name="head">The head.</param>
    /// <returns></returns>
    private static int Count(ListNode? head)
    {
        int result = 0;
        ListNode? curr = head;
        while (curr != null)
        {
            result++;
            curr = curr.next;
        }
        return result;
    }

    /// <summary>
    /// Counts the specified head.
    /// </summary>
    /// <param name="head">The head.</param>
    /// <returns></returns>
    private static int PalindromeCount(ListNode head)
    {
        int result = 0;
        var curr = head;
        while (curr != null)
        {
            result++;
            curr = curr.next;
        }
        return result;
    }

    #endregion

    #region Container With Most Water -------------------------------

    /// <summary>
    /// Maximums the area.
    /// </summary>
    /// <param name="height">The height.</param>
    /// <returns></returns>
    public static int MaxArea(int[] height)
    {
        var result = 0;
        for (var i = 0; i < height.Length; i++)
        {
            for (var j = i + 1; j < height.Length; j++)
            {
                int smaller = Math.Min(height[i], height[j]);
                int width = j - i;
                int area = smaller * width;
                result = Math.Max(result, area);
            }
        }
        return result;
    }

    /// <summary>
    /// Maximums the area.
    /// </summary>
    /// <param name="height">The height.</param>
    /// <returns></returns>
    public static int MaxArea2(int[] height)
    {
        var result = 0;
        var beginnng = 0;
        var ending = height.Length - 1;
        while (beginnng < ending)
        {
            int smaller = Math.Min(height[beginnng], height[ending]);
            int width = ending - beginnng;
            int area = smaller * width;
            result = Math.Max(result, area);
            while (height[beginnng] <= smaller && beginnng < ending) beginnng++;
            while (height[ending] <= smaller && beginnng < ending) ending--;
        }
        return result;
    }

    #endregion

    #region Merge k Sorted Lists ------------------------------------

    /// <summary>
    /// Merges the k lists.
    /// </summary>
    /// <param name="lists">The lists.</param>
    /// <returns></returns>
    public static ListNode? MergeKLists(ListNode?[] lists)
    {
        int[] results = Array.Empty<int>();
        int pos = 0;
        for (int i = 0; i < lists.Length; i++)
        {
            int[]? items = ToArray(lists[i]);
            if (items != null)
            {
                Array.Resize(ref results, items.Length + pos);
                Array.Copy(items, 0, results, pos, items.Length);
                pos += items.Length;
            }
        }
        Array.Sort(results);
        return ToListNode(results);
    }

    /// <summary>
    /// Converts to listnode.
    /// </summary>
    /// <param name="items">The items.</param>
    /// <returns></returns>
    private static ListNode? ToListNode(int[] items)
    {
        if (items == null) return null;
        ListNode? result = null;
        for (int i = items.Length - 1; i >= 0; i--)
            result = new(items[i], result);
        return result;
    }

    /// <summary>
    /// Converts to array.
    /// </summary>
    /// <param name="nodes">The nodes.</param>
    /// <returns></returns>
    private static int[]? ToArray(ListNode? nodes)
    {
        if (nodes == null) return null;
        int[] result = Array.Empty<int>();
        while (nodes != null)
        {
            Array.Resize(ref result, result.Length + 1);
            result[^1] = nodes.val;
            nodes = nodes.next;
        }
        return result;
    }

    #endregion

    #region Substring with Concatenation of All Words ---------------

    /// <summary>
    /// Finds the substring.
    /// </summary>
    /// <param name="s">The s.</param>
    /// <param name="words">The words.</param>
    /// <returns></returns>
    public static IList<int> FindSubstring(string s, string[] words)
    {
        var result = new List<int>();
        if (string.IsNullOrEmpty(s) || words.Length == 0) return result;
        var wordCount = words.Length;
        var wordLength = words[0].Length;
        var sectionLength = wordCount * wordLength;

        if (sectionLength > s.Length) return result;

        var maxSections = s.Length - sectionLength + 1;

        for (int i = 0; i < maxSections; i++)
        {
            var section = s.Substring(i, sectionLength);
            bool found;
            for (int j = 0; j < wordCount; j++)
            {
                (section, found) = RemoveWord(section, words[j]);
                // if the word was not found then go on to the next section
                if (!found) break;
            }
            if (section.Length == 0) result.Add(i);
        }

        return result;
    }

    /// <summary>
    /// Removes the word.
    /// </summary>
    /// <param name="section">The section.</param>
    /// <param name="word">The word.</param>
    /// <returns></returns>
    private static (string, bool) RemoveWord(string section, string word)
    {
        var found = false;
        var subindex = section.IndexOf(word);
        // The index should be on a multiple of the word length
        while (subindex % word.Length != 0 && subindex >= 0)
            subindex = section.IndexOf(word, subindex + 1);
        // if we found the word then remove it and return that we found it.
        if (subindex >= 0)
        {
            section = section.Remove(subindex, word.Length);
            found = true;
        }

        return (section, found);
    }

    #endregion

    #region Course Schedule -----------------------------------------

    /// <summary>
    /// Determines whether this instance can finish the specified number courses.
    /// </summary>
    /// <param name="numCourses">The number courses.</param>
    /// <param name="prerequisites">The prerequisites.</param>
    /// <returns>
    ///   <c>true</c> if this instance can finish the specified number courses; otherwise, <c>false</c>.
    /// </returns>
    public static bool CanFinish(int numCourses, int[][] prerequisites)
    {
        if (numCourses == 0) return false;
        if (prerequisites == null || prerequisites.Length == 0) return false;
        List<int> l = new();
        List<int> s = new();
        for (var i = 0; i < numCourses; i++)
            s.Add(i);
        while (s.Count > 0)
        {
            int course = s[0];
            s.Remove(course);
            l.Add(course);

        }

        return prerequisites.Length == 0;
    }

    #endregion
}