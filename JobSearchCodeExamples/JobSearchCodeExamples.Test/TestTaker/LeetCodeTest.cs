﻿namespace JobSearchCodeExamples.Test.TestTaker;

/// <summary>
/// tests for code from LeetCode
/// </summary>
public class LeetCodeTest
{
    #region FizzBuzz code tests -------------------------------------

    [Theory]
    [InlineData(3, new string[] { "1", "2", "Fizz" })]
    [InlineData(5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
    [InlineData(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
    public void FizzBuss1Test(int n, string[] expectedResult)
    {
        Assert.Equal(expectedResult, LeetCode.FizzBuzz(n).ToArray());
    }

    [Theory]
    [InlineData(3, new string[] { "1", "2", "Fizz" })]
    [InlineData(5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
    [InlineData(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
    public void FizzBuss2Test(int n, string[] expectedResult)
    {
        Assert.Equal(expectedResult, LeetCode.FizzBuzz2(n).ToArray());
    }

    [Theory]
    [InlineData(3, new string[] { "1", "2", "Fizz" })]
    [InlineData(5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
    [InlineData(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
    public void FizzBuss3Test(int n, string[] expectedResult)
    {
        Assert.Equal(expectedResult, LeetCode.FizzBuzz3(n).ToArray());
    }

    [Theory]
    [InlineData(3, new string[] { "1", "2", "Fizz" })]
    [InlineData(5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
    [InlineData(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
    public void FizzBuss4Test(int n, string[] expectedResult)
    {
        Assert.Equal(expectedResult, LeetCode.FizzBuzz4(n).ToArray());
    }

    [Theory]
    [InlineData(3, new string[] { "1", "2", "Fizz" })]
    [InlineData(5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
    [InlineData(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
    public void FizzBuss5Test(int n, string[] expectedResult)
    {
        Assert.Equal(expectedResult, LeetCode.FizzBuzz5(n).ToArray());
    }

    [Theory]
    [InlineData(3, new string[] { "1", "2", "Fizz" })]
    [InlineData(5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
    [InlineData(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
    public void FizzBuss6Test(int n, string[] expectedResult)
    {
        Assert.Equal(expectedResult, LeetCode.FizzBuzz6(n).ToArray());
    }

    #endregion

    #region Middle of the linked list tests -------------------------

    /// <summary>
    /// Middles the node1 test.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 4, 5, 6 })]
    [InlineData(new int[] { 3 }, new int[] { 3 })]
    [InlineData(null, null)]
    public void MiddleNodeTest(int[] items, int[] expectedResult)
    {
        Assert.Equal(expectedResult, ToArray(LeetCode.MiddleNode(ToListNode(items))));
    }

    #endregion

    #region Palindrome Lined List -----------------------------------

    /// <summary>
    /// Determines whether [is palindrome1 test].
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 2, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 2 }, false)]
    [InlineData(new int[] { 1, 2, 3, 3, 2, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4, 2, 1 }, false)]
    [InlineData(null, true)]
    public void IsPalindrome1Test(int[] items, bool expectedResult)
    {
        Assert.Equal(expectedResult, LeetCode.IsPalindrome(ToListNode(items)));
    }

    [Theory]
    [InlineData(new int[] { 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 2, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 2 }, false)]
    [InlineData(new int[] { 1, 2, 3, 3, 2, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4, 2, 1 }, false)]
    [InlineData(null, true)]
    public void IsPalindrome2Test(int[] items, bool expectedResult)
    {
        Assert.Equal(expectedResult, LeetCode.IsPalindrome2(ToListNode(items)));
    }

    [Theory]
    [InlineData(new int[] { 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 2, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 2 }, false)]
    [InlineData(new int[] { 1, 2, 3, 3, 2, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4, 2, 1 }, false)]
    [InlineData(null, true)]
    public void IsPalindrome3Test(int[] items, bool expectedResult)
    {
        Assert.Equal(expectedResult, LeetCode.IsPalindrome3(ToListNode(items)));
    }

    #endregion

    #region Add Two Numbers -----------------------------------------

    /// <summary>
    /// Adds the two numbers1 test.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 0 }, new int[] { 0 }, new int[] { 0 })]
    [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
    [InlineData(new int[] { 2, 4, 3 }, null, new int[] { 2, 4, 3 })]
    [InlineData(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
    [InlineData(new int[] { 9 }, new int[] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 })]
    [InlineData(null, new int[] { 5, 6, 4 }, new int[] { 5, 6, 4 })]
    [InlineData(null, null, null)]
    public void AddTwoNumbers1Test(int[] items1, int[] items2, int[] expectedResult)
    {
        Assert.Equal(expectedResult, ToArray(LeetCode.AddTwoNumbers(ToListNode(items1), ToListNode(items2))));
    }

    #endregion

    #region Test Support functions ----------------------------------

    /// <summary>
    /// Converts to listnode.
    /// </summary>
    /// <param name="items">The items.</param>
    /// <returns></returns>
    private static LeetCode.ListNode? ToListNode(int[] items)
    {
        if (items == null) return null;
        LeetCode.ListNode? result = null;
        for (int i = items.Length - 1; i >= 0; i--)
            result = new(items[i], result);
        return result;
    }

    /// <summary>
    /// Converts to array.
    /// </summary>
    /// <param name="nodes">The nodes.</param>
    /// <returns></returns>
    private static int[]? ToArray(LeetCode.ListNode? nodes)
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
}