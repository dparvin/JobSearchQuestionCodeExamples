namespace JobSearchCodeExamples.cs.Contest.LeetCodeContest313;

/// <summary>
/// Provides a solution for Question 4.
/// </summary>
public static class Question4
{
    /// <summary>
    /// Deletes the string.
    /// </summary>
    /// <param name="s">The s.</param>
    /// <param name="log">The log.</param>
    /// <returns></returns>
    /// <remarks>
    /// 2430. Maximum Deletions on a String
    /// 
    /// You are given a string s consisting of only lowercase English letters. In one operation, you can:
    /// 
    /// * Delete the entire string s, or
    /// * Delete the first i letters of s if the first i letters of s are equal to the
    /// 
    /// following i letters in s, for any i in the range 1 &lt;= i &lt;= s.length / 2.
    /// 
    /// For example, if s = "ababc", then in one operation, you could delete the first two letters of s to
    /// get "abc", since the first two letters of s and the following two letters of s are both equal to "ab".
    /// 
    /// Return the maximum number of operations needed to delete all of s.
    /// </remarks>
    public static int DeleteString(string s, Action<string>? log = null)
    {
        log?.Invoke($"Trying: {s}");
        int n = s.Length;
        if (n == 1) return 1;

        int[] DP = [.. Enumerable.Repeat<int>(1, n)];
        for (int j = n - 2; j >= 0; j--)
        {
            var best = 1;
            for (int i = 1; i <= (n - j) / 2; ++i)
            {
                if (DP[i + j] + 1 <= best)
                    continue;
                else if (s.AsSpan(j, i).SequenceEqual(s.AsSpan(j + i, i)))
                {
                    log?.Invoke($"Match found for j={j}, i={i}");
                    best = Math.Max(best, 1 + DP[j + i]);
                }
            }
            DP[j] = best;
        }
        return DP[0];
    }
}
