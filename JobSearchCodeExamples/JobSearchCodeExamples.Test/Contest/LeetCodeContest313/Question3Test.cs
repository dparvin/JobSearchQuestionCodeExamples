using JobSearchCodeExamples.cs.Contest.LeetCodeContest313;

namespace JobSearchCodeExamples.cs.Test.Contest.LeetCodeContest313;

public partial class Question3Test
{
    #region Question 3 Test -------------------------------------

    /// <summary>
    /// Question1s the test.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(Question3TestData))]
    public void DoQuestion3Test(string s, int[] distance, bool expectedResult)
    {
        Assert.Equal(expectedResult, Question3.DoQuestion3());
    }

    #endregion
}
