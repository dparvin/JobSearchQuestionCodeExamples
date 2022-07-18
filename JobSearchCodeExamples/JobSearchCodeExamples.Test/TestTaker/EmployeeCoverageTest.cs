namespace JobSearchCodeExamples.Test.TestTaker;

/// <summary>
/// Tests for Employee Coverage
/// </summary>
public class EmployeeCoverageTest
{
    /// <summary>
    /// Maximums the coverage test.
    /// </summary>
    [Fact]
    public void MaxCoverageTest()
    {
        string[] employees = {
            "79-84",
            "80-86",
            "75-83",
            "90-99",
            "87-95" };
        var results = EmployeeCoverage.MaxCoverage(employees);

        Assert.Equal(3, results);
    }
}
