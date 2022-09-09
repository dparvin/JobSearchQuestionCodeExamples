using static System.Net.WebRequestMethods;

namespace JobSearchCodeExamples.Contest;

/// <summary>
/// Routines for contest questions for LeetCode Contest 309
/// </summary>
/// <see cref="https://leetcode.com/contest/weekly-contest-309/"/>
public static class LeetCodeContest309
{
    #region Check Distances Between Same Letters --------------------

    /// <summary>
    /// Question1s the specified value.
    /// </summary>
    /// <param name="s">The s.</param>
    /// <param name="distance">The distance.</param>
    /// <returns></returns>
    public static bool CheckDistances(string s, int[] distance)
    {
        foreach (var letter in s.ToCharArray())
        {
            int letterIndex = letter - 'a';
            int index1 = s.IndexOf(letter);
            int index2 = s.IndexOf(letter, index1 + 1);
            if (index2 - index1 - 1 != distance[letterIndex])
                return false;
        }
        return true;
    }

    #endregion

    #region Number of Ways to Reach a Position After Exactly k Steps

    /// <summary>
    /// Question2s the specified value.
    /// </summary>
    /// <param name="startPos">The start position.</param>
    /// <param name="endPos">The end position.</param>
    /// <param name="k">The k.</param>
    /// <returns></returns>
    public static int NumberOfWays(int startPos, int endPos, int k)
    {
        if (endPos - startPos > k)
            return 0;
        int[][] dp = new int[k * 2 + 1][];
        for (int i = 0; i < k * 2 + 1; i++)
            dp[i] = new int[k * 2 + 1];

        return Distance(dp, k, Math.Abs(startPos - endPos));
    }

    private static int Distance(int[][] dp, int k, int d)
    {
        const int mod = 10 ^ 9 + 7;
        if (d >= k)
            return d == k ? 1 : 0;
        if (dp[k][d] == 0)
            dp[k][d] = (1 + Distance(dp, k - 1, d + 1) + Distance(dp, k - 1, Math.Abs(d - 1))) % mod;

        return Math.Abs(dp[k][d] - 1);
    }

    #endregion

    #region Longest Nice Sub-array ----------------------------------

    /// <summary>
    /// Question3s the specified value.
    /// </summary>
    /// <param name="nums">The nums.</param>
    /// <returns></returns>
    public static int LongestNiceSubarray(int[] nums)
    {
        return 0;
    }

    #endregion

    #region Meeting Rooms III ---------------------------------------

    /// <summary>
    /// Question4s the specified value.
    /// </summary>
    /// <param name="n">The n.</param>
    /// <param name="meetings">The meetings.</param>
    /// <returns></returns>
    /// <see cref="https://leetcode.com/contest/weekly-contest-309/problems/meeting-rooms-iii/"/>
    public static int MostBooked(int n, int[][] meetings)
    {
        int[] startTimes = new int[meetings.Length];
        int[] endTimes = new int[meetings.Length];
        for (int i = 0; i < meetings.Length; i++)
        {
            startTimes[i] = meetings[i][0];
            endTimes[i] = meetings[i][1];
        }
        Array.Sort(startTimes, endTimes);
        long[][] rooms = new long[n][];

        for (int i = 0; i < n; i++)
            rooms[i] = new long[2];
        for (int i = 0; i < meetings.Length; i++)
        {
            bool scheduled = false;
            for (int j = 0; j < n; j++)
            {
                if (startTimes[i] >= rooms[j][0])
                {
                    if (rooms[j][0] < startTimes[i]) rooms[j][0] = startTimes[i];
                    rooms[j][0] += endTimes[i] - startTimes[i];
                    rooms[j][1] += 1;
                    scheduled = true;
                    break;
                }
            }
            if (!scheduled)
            {
                int earliest = 0;
                long earliestTime = long.MaxValue;
                for (int j = 0; j < n; j++)
                {
                    if (rooms[j][0] < earliestTime)
                    {
                        earliest = j;
                        earliestTime = rooms[j][0];
                    }
                }
                rooms[earliest][0] += endTimes[i] - startTimes[i];
                rooms[earliest][1] += 1;
            }
        }
        int result = 0;
        long MostMeetings = 0;
        for (var i = 0; i < n; i++)
            if (rooms[i][1] > MostMeetings)
            {
                MostMeetings = rooms[i][1];
                result = i;
            }

        return result;
    }

    #endregion
}
