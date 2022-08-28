using JobSearchCodeExamples.Contest;

namespace JobSearchCodeExamples.Test.Contest;

public partial class LeetCodeContest308Test
{
    #region Question 1 ------------------------------------------

    /// <summary>
    /// </summary>
    /// <returns></returns>
    [Theory]
    [MemberData(nameof(Question1Data))]
    public void Question1Test(int expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest308.Question1());
    }

    #endregion

    #region Question 2 ------------------------------------------

    /// <summary>
    /// </summary>
    /// <returns></returns>
    [Theory]
    [MemberData(nameof(Question1Data))]
    public void Question2Test(int expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest308.Question2());
    }

    #endregion

    #region Question 3 ------------------------------------------

    /// <summary>
    /// </summary>
    /// <returns></returns>
    [Theory]
    [MemberData(nameof(Question3Data))]
    public void Question3Test(int expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest308.Question3());
    }

    #endregion

    #region Question 4 ------------------------------------------

    /// <summary>
    /// </summary>
    /// <returns></returns>
    [Theory]
    [MemberData(nameof(Question4Data))]
    public void Question4Test(int expectedResult)
    {
        Assert.Equal(expectedResult, LeetCodeContest308.Question4());
    }

    #endregion
}
