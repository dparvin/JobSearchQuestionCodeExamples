using JobSearchCodeExamples.cs.Contest.LeetCodeContest313;
using Xunit.Abstractions;

namespace JobSearchCodeExamples.cs.Test.Contest.LeetCodeContest313;

public partial class Question4Test(ITestOutputHelper output)
{
    private readonly ITestOutputHelper _output = output;

    #region Question 4 Test -------------------------------------

    /// <summary>
    /// Question 4s the test.
    /// </summary>
    /// <param name="s">The s.</param>
    /// <param name="distance">The distance.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(DeleteStringTestData))]
    public void DeleteStringTest(string s, int expectedResult)
    {
        Assert.Equal(expectedResult, Question4.DeleteString(s, _output.WriteLine));
    }

    #endregion
}
