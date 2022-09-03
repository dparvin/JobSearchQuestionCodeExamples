using JobSearchCodeExamples.Contest;

namespace JobSearchCodeExamples.Test.Contest;

public partial class LeetCodeContest309Test
{
    #region Question 1 ----------------------------------------------

    /// <summary>
    /// Question1s the test.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(Question1TestData))]
    public void Question1Test(int value, int expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest309.Question1(value));
    }

    #endregion

    #region Question 2 ----------------------------------------------

    /// <summary>
    /// Question2s the test.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(Question2TestData))]
    public void Question2Test(int value, int expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest309.Question2(value));
    }

    #endregion

    #region Question 3 ----------------------------------------------

    /// <summary>
    /// Question3s the test.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(Question3TestData))]
    public void Question3Test(int value, int expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest309.Question3(value));
    }

    #endregion

    #region Question 4 ----------------------------------------------

    /// <summary>
    /// Question4s the test.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(Question4TestData))]
    public void Question4Test(int value, int expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest309.Question4(value));
    }

    #endregion
}
