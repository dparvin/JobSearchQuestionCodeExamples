using JobSearchCodeExamples.cs.Contest.LeetCodeContest313;

namespace JobSearchCodeExamples.cs.Test.Contest.LeetCodeContest313;

public partial class Question4Test
{
    #region Question 4 Test -------------------------------------

    /// <summary>
    /// Question 4s the test.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(Question4TestData))]
    public void DoQuestion3Test(string s, int[] distance, bool expectedResult)
    {
        Assert.Equal(expectedResult, Question4.DoQuestion4());
    }

    #endregion
}
