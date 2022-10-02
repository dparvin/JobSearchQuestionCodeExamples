using JobSearchCodeExamples.cs.Contest.LeetCodeContest313;

namespace JobSearchCodeExamples.cs.Test.Contest.LeetCodeContest313;

public partial class Question1Test
{
    #region Question 1 Test -------------------------------------

    /// <summary>
    /// Question1s the test.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(Question1TestData))]
    public void DoQuestion1Test(string s, int[] distance, bool expectedResult)
    {
        Assert.Equal(expectedResult, Question1.DoQuestion1());
    }

    #endregion
}
