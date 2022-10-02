using JobSearchCodeExamples.cs.Contest.LeetCodeContest313;

namespace JobSearchCodeExamples.cs.Test.Contest.LeetCodeContest313;

public partial class Question2Test
{
    #region Question 2 Test -------------------------------------

    /// <summary>
    /// Question1s the test.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(Question2TestData))]
    public void DoQuestion2Test(string s, int[] distance, bool expectedResult)
    {
        Assert.Equal(expectedResult, Question2.DoQuestion2());
    }

    #endregion
}
