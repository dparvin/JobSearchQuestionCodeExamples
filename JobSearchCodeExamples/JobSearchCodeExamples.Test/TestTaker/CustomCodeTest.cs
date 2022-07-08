namespace JobSearchCodeExamples.Test.TestTaker;

/// <summary>
/// Tests for code that is in the Custom Code class
/// </summary>
public class CustomCodeTest
{
    /// <summary>
    /// Tests the version compare.
    /// </summary>
    /// <param name="version1">The version1.</param>
    /// <param name="version2">The version2.</param>
    /// <param name="ExpectedResult">The expected result.</param>
    [Theory]
    [InlineData("2", "2.0", 0)]
    [InlineData("2", "2.0.0", 0)]
    [InlineData("2", "2.0.0.0", 0)]
    [InlineData("2", "2.0.0.0.0", 0)]
    [InlineData("2", "2.0.0.0.1", -1)]
    [InlineData("2", "2.1", -1)]
    [InlineData("2.1.0", "2.0.1", 1)]
    [InlineData("2.10.0.1", "2.1.0.10", 1)]
    [InlineData("2.0.1", "1.2000.1", 1)]
    public void TestVersionCompare(string version1, string version2, int ExpectedResult)
    {
        var result = CustomCode.VersionCompare(version1, version2);
        Assert.Equal(ExpectedResult, result);
    }
}
