Imports JobSearchCodeExamples.VB.TestTaker
Imports Xunit

Public Class EmployeeCoverageTest

    ''' <summary>
    ''' Maximums the coverage test.
    ''' </summary>
    <Fact>
    Public Sub MaxCoverageTest()

        Dim employees = {
            "79-84",
            "80-86",
            "75-83",
            "90-99",
            "87-95"}
        Dim results = EmployeeCoverage.MaxCoverage(employees)

        Assert.Equal(3, results)

    End Sub

    ''' <summary>
    ''' Maximums the coverage test.
    ''' </summary>
    <Fact>
    Public Sub MaxCoverageFillBranchTest()

        Dim employees = {
            "79-84",
            "80-86",
            "75-83",
            "74-99",
            "87-95",
            "65-67"}
        Dim results = EmployeeCoverage.MaxCoverage(employees)

        Assert.Equal(5, results)

    End Sub

End Class
