using JobSearchCodeExamples.cs.Contest.LeetCodeContest313;

namespace JobSearchCodeExamples.cs.Test.Contest.LeetCodeContest313;

public partial class Question2Test
{
    #region Question 2 Test -------------------------------------

    /// <summary>
    /// Tests the MaxSum method.
    /// </summary>
    /// <param name="grid">The grid.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(MaxSumTestData))]
    public void MaxSumTest(int[][] grid, int expectedResult)
    {
        Assert.Equal(expectedResult, Question2.MaxSum(grid));
    }

    #endregion
}
