using JobSearchCodeExamples.cs.Contest;

namespace JobSearchCodeExamples.cs.Test.Contest;

/// <summary>
/// 
/// </summary>
public partial class LeetCodeContest309Test
{
    #region Check Distances Between Same Letters --------------------

    /// <summary>
    /// Test for checking distances between same letters.
    /// </summary>
    /// <param name="s">The s.</param>
    /// <param name="distance">The distance.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(CheckDistancesTestData))]
    public void CheckDistancesTest(string s, int[] distance, bool expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest309.CheckDistances(s, distance));
    }

    #endregion

    #region Number of Ways to Reach a Position After Exactly k Steps

    /// <summary>
    /// Test for the number of ways to reach a position after exactly k steps.
    /// </summary>
    /// <param name="startPos">The start position.</param>
    /// <param name="endPos">The end position.</param>
    /// <param name="k">The exact number of steps between the start and end positions.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(NumberOfWaysTestData))]
    public void NumberOfWaysTest(int startPos, int endPos, int k, int expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest309.NumberOfWays(startPos, endPos, k));
    }

    #endregion

    #region Longest Nice Sub-array ----------------------------------

    /// <summary>
    /// Test for the longest nice sub array.
    /// </summary>
    /// <param name="nums">The nums.</param>
    /// <param name="expectedResult">The expected result.</param>
    /// <remarks>
    /// 2401. Longest Nice SubArray
    /// You are given an array nums consisting of positive integers.
    /// We call a sub-array of nums nice if the bitwise AND of every pair of elements
    /// that are in different positions in the sub-array is equal to 0.
    /// Return the length of the longest nice sub-array.
    /// A sub-array is a contiguous part of an array.
    /// Note that sub-arrays of length 1 are always considered nice.
    /// </remarks>
    [Theory]
    [MemberData(nameof(LongestNiceSubArrayTestData))]
    public void LongestNiceSubArrayTest(Int64[] nums, int expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest309.LongestNiceSubArray(nums));
    }

    #endregion

    #region Meeting Rooms III ---------------------------------------

    /// <summary>
    /// Meeting Room III Brute Force test.
    /// </summary>
    /// <param name="n">The number of rooms.</param>
    /// <param name="meetings">The meetings.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(MostBookedTestData))]
    public void MostBookedBruteForceTest(int n, int[][] meetings, int expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest309.MostBookedBruteForce(n, meetings));
    }

    /// <summary>
    /// Meeting Room III Priority Queue test.
    /// </summary>
    /// <param name="n">The number of rooms.</param>
    /// <param name="meetings">The meetings.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(MostBookedTestData))]
    public void MostBookedPriorityQueueTest(int n, int[][] meetings, int expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest309.MostBookedPriorityQueue(n, meetings));
    }

    #endregion
}
