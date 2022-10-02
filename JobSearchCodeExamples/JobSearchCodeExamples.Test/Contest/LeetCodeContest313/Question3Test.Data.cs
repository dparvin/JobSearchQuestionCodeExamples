namespace JobSearchCodeExamples.cs.Test.Contest.LeetCodeContest313;

public partial class Question3Test
{
    /// <summary>
    /// Gets the test data.
    /// </summary>
    /// <value>
    /// The test data.
    /// </value>
    public static IEnumerable<object[]> Question3TestData
    {
        get
        {
            var result = new List<object[]>
                {
                    new object[] { "abaccb", new int[] { 1, 3 }, true },
                    new object[] { "aa", new int[] { 1, 0 }, false },
                    new object[] { "zz", new int[] { 0, 0 }, true }
                };

            return result;
        }
    }
}
