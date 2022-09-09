using JobSearchCodeExamples.Contest;

namespace JobSearchCodeExamples.Test.Contest;

public partial class LeetCodeContest309Test
{
    #region Check Distances Between Same Letters --------------------

    /// <summary>
    /// Question1s the test.
    /// </summary>
    /// <param name="value">The value.</param>
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
    /// Question2s the test.
    /// </summary>
    /// <param name="startPos">The start position.</param>
    /// <param name="endPos">The end position.</param>
    /// <param name="k">The k.</param>
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
    /// Question3s the test.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(LongestNiceSubarrayTestData))]
    public void LongestNiceSubarrayTest(int[] nums, int expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest309.LongestNiceSubarray(nums));
    }

    #endregion

    #region Meeting Rooms III ---------------------------------------

    /// <summary>
    /// Question4s the test.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(MostBookedTestData))]
    public void MostBookedTest(int n, int[][] meetings, int expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest309.MostBooked(n, meetings));
    }

    #endregion
}
