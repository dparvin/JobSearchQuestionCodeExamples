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
    [MemberData(nameof(MinimizeXorTestData))]
    public void MinimizeXorTest(int num1, int num2, int expectedResult)
    {
        Assert.Equal(expectedResult, Question3.MinimizeXor(num1, num2));
    }

    #endregion
}
