using JobSearchCodeExamples.cs.Contest.LeetCodeContest313;
using Xunit.Abstractions;

namespace JobSearchCodeExamples.cs.Test.Contest.LeetCodeContest313;

/// <summary>
/// Initializes a new instance of the <see cref="Question1Test"/> class.
/// </summary>
/// <param name="output">The output.</param>
public partial class Question1Test(ITestOutputHelper output)
{
    private readonly ITestOutputHelper _output = output;

    #region Question 1 Test -------------------------------------

    /// <summary>
    /// Tests the CommonFactors method.
    /// </summary>
    /// <param name="a">The first integer.</param>
    /// <param name="b">The second integer.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [MemberData(nameof(CommonFactorsTestData))]
    public void CommonFactorsTest(int a, int b, int expectedResult)
    {
        Assert.Equal(expectedResult, Question1.CommonFactors(a, b, _output.WriteLine));
    }

    #endregion
}
