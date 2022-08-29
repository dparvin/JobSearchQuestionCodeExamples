using JobSearchCodeExamples.Contest;

namespace JobSearchCodeExamples.Test.Contest;

public partial class LeetCodeContest308Test
{
    #region Longest Subsequence With Limited Sum --------------------

    /// <summary>
    /// Answers the queries test.
    /// </summary>
    /// <param name="nums">The nums.</param>
    /// <param name="queries">The queries.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(AnswerQueriesData))]
    public void AnswerQueriesTest(int[] nums, int[] queries, int[] expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest308.AnswerQueries(nums, queries));
    }

    #endregion

    #region Removing Stars From a String ----------------------------

    /// <summary>
    /// Removes the stars test.
    /// </summary>
    /// <param name="s">The s.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(RemoveStarsData))]
    public void RemoveStars1Test(string s, string expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest308.RemoveStars1(s));
    }

    /// <summary>
    /// Removes the stars test.
    /// </summary>
    /// <param name="s">The s.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(RemoveStarsData))]
    public void RemoveStars2Test(string s, string expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest308.RemoveStars2(s));
    }

    #endregion

    #region Minimum Amount of Time to Collect Garbage ---------------

    /// <summary>
    /// Garbages the collection test.
    /// </summary>
    /// <param name="garbage">The garbage.</param>
    /// <param name="travel">The travel.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(GarbageCollectionData))]
    public void GarbageCollection1Test(string[] garbage, int[] travel, int expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest308.GarbageCollection1(garbage, travel));
    }

    /// <summary>
    /// Garbages the collection test.
    /// </summary>
    /// <param name="garbage">The garbage.</param>
    /// <param name="travel">The travel.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(GarbageCollectionData))]
    public void GarbageCollection2Test(string[] garbage, int[] travel, int expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest308.GarbageCollection2(garbage, travel));
    }

    #endregion

    #region Build a Matrix With Conditions --------------------------

    /// <summary>
    /// </summary>
    /// <returns></returns>
    [Theory]
    [MemberData(nameof(BuildMatrixData))]
    public void BuildMatrixTest(int k, int[][] rowConditions, int[][] colConditions, int[][] expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest308.BuildMatrix(k, rowConditions, colConditions));
    }

    #endregion
}
