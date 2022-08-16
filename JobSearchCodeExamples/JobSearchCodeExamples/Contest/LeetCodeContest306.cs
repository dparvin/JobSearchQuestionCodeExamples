namespace JobSearchCodeExamples.Contest;

/// <summary>
/// 
/// </summary>
public class LeetCodeContest306
{
    /// <summary>
    /// Largest the local.
    /// </summary>
    /// <param name="grid">The grid.</param>
    /// <returns></returns>
    public static int[][] LargestLocal(int[][] grid)
    {
        int[][] result = new int[grid.Length - 2][];
        for (var i = 1; i < grid.Length - 1; i++)
        {
            result[i - 1] = new int[grid.Length - 2];
            for (var j = 1; j < grid.Length - 1; j++)
            {
                for (var k = -1; k < 2; k++)
                {
                    for (var l = -1; l < 2; l++)
                    {
                        if (grid[k + i][l + j] > result[i - 1][j - 1])
                            result[i - 1][j - 1] = grid[k + i][l + j];
                    }
                }
            }
        }
        return result;
    }

    /// <summary>
    /// Edges the score.
    /// </summary>
    /// <param name="edges">The edges.</param>
    /// <returns></returns>
    public static int EdgeScore(int[] edges)
    {
        var edgeCount = new Dictionary<int, long>();
        for (var i = 0; i < edges.Length; i++)
            if (edgeCount.ContainsKey(edges[i]))
                edgeCount[edges[i]] += i;
            else
                edgeCount.Add(edges[i], i);
        int largestNode = -1;
        for (var i = 0; i < edges.Length; i++)
        {
            if (edgeCount.ContainsKey(i))
                if (largestNode < 0)
                    largestNode = i;
                else if (edgeCount[i] > edgeCount[largestNode])
                    largestNode = i;
        }
        return largestNode;
    }

    /// <summary>
    /// Smallest the number.
    /// </summary>
    /// <param name="pattern">The pattern.</param>
    /// <returns></returns>
    public static string SmallestNumber(string pattern)
    {
        var n = pattern.Length;
        var result = "123456789".Substring(0, n + 1);
        var changed = true;
        while (changed)
        {
            changed = false;
            for (var i = 0; i < n; i++)
            {
                if (pattern[i] == 'I')
                {
                    if (result[i] >= result[i + 1])
                    {
                        var item = result[i];
                        var sec = result[i + 1];

                        result = result.Remove(result.IndexOf(sec), 1);
                        result = result.Replace(item, sec);
                        result = result.Insert(result.IndexOf(sec) + 1, item.ToString());
                        changed = true;
                        break;
                    }
                }
                if (pattern[i] == 'D')
                {
                    if (result[i] <= result[i + 1])
                    {
                        var item = result[i];
                        var sec = result[i + 1];

                        result = result.Remove(result.IndexOf(sec), 1);
                        result = result.Replace(item, sec);
                        result = result.Insert(result.IndexOf(sec) + 1, item.ToString());
                        changed = true;
                        break;
                    }
                }
            }
        }
        return result;
    }

    #region Count Special Numbers -----------------------------------

    /// <summary>
    /// Counts the special numbers.
    /// </summary>
    /// <param name="n">The n.</param>
    /// <returns></returns>
    /// <remarks>
    /// This is a brute force process of checking each number in the range and making sure each
    /// number does not have duplicate numbers.  As you can see from the tests it has a very long
    /// run for large numbers.
    /// </remarks>
    public static int CountSpecialNumbers(int n)
    {
        int result = 0;
        for (var i = 1; i <= n; i++)
        {
            if (i < 11)
                result++;
            else
            {
                var digits = i.ToString();
                var good = true;
                for (var j = 0; j < digits.Length; j++)
                {
                    if (digits.IndexOf(digits[j], j + 1) >= 0)
                    {
                        good = false;
                        break;
                    }
                }
                if (good)
                    result++;
            }
        }
        return result;
    }

    /// <summary>
    /// Counts the special numbers.
    /// </summary>
    /// <param name="n">The n.</param>
    /// <returns></returns>
    public static int CountSpecialNumbers2(int n)
    {
        if (n <= 11) return n;
        return (int)GetCount(n, 0L, 0) - 1;
    }

    /// <summary>
    /// Gets the count.
    /// </summary>
    /// <param name="maxNumber">The maximum number.</param>
    /// <param name="current">The current number to process.</param>
    /// <param name="mask">The bit mask to use.</param>
    /// <returns></returns>
    /// <remarks>
    /// This is a recursive routine to get the count of the Special Numbers.
    /// The way it works is to cycle through 0 to 9 and when the passed in mask has the bit 
    /// turned on, then the digit is skipped.  The mast starts at 0 for the first cycle
    /// and when it is checking for digit 0, it ands 2^0 to 0 to see that it has not been used.
    /// Because the recursion would never end when current and the digit are zero, it is 
    /// skipped (and according to the design 0 is not included in the range).  Then this routine 
    /// is called again with current (first time through is 0) * 10 + the digit (1) giving a 
    /// current of 1 for the next current and the next mask is 1 (2^0).  
    /// 
    /// During the second cycle, with current at 1 and mask at 1, the zero digit is skipped and
    /// so the first time we get to the call for recursing again we have a current of 1 and a digit
    /// of 1 and a mask of 1, which then calls this again with a current of 11 and a mask of 3 
    /// (2^0 or 2^1) witch is the same as 1+2 = 3.
    /// 
    /// Basically the code checks to see if a digit has been used in a previous cycle and so does 
    /// not try to add to the count if it has been.  If the passed current is larger than the max number
    /// it returns 0, and so each valid call to this routine returns at least 1, but if there are multiples
    /// of that number to be included in the count then a recursion will return that count.
    /// 
    /// This routine always returns one more then the actual number of special numbers in the range.
    /// </remarks>
    private static long GetCount(int maxNumber, long current, int mask)
    {
        if (current > maxNumber) return 0;

        long result = 1;
        for (int d = 0; d < 10; d++)
        {
            if (current == 0 && d == 0) continue;
            if ((mask & (1 << d)) != 0) continue;
            result += GetCount(maxNumber, current * 10 + d, mask | (1 << d));
        }

        return result;
    }

    #endregion
}
