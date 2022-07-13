Imports JobSearchCodeExamples.VB.JobSeearchCodeExamples.VB.TestTaker
Imports JobSearchCodeExamples.VB.TestTaker
Imports Xunit

Namespace JobSearchCodeExamples.VB.Test

    ''' <summary>
    ''' Tests for code that is in the Custom Code class
    ''' </summary>
    Public Class CustomCodeTest

        ''' <summary>
        ''' Tests the version compare.
        ''' </summary>
        ''' <param name="version1">The version1.</param>
        ''' <param name="version2">The version2.</param>
        ''' <param name="ExpectedResults">The expected results.</param>
        <Theory>
        <InlineData("2", "2.0", 0)>
        <InlineData("2", "2.0.0", 0)>
        <InlineData("2", "2.0.0.0", 0)>
        <InlineData("2", "2.0.0.0.0", 0)>
        <InlineData("2", "2.0.0.0.1", -1)>
        <InlineData("2", "2.1", -1)>
        <InlineData("2.1.0", "2.0.1", 1)>
        <InlineData("2.10.0.1", "2.1.0.10", 1)>
        <InlineData("2.0.1", "1.2000.1", 1)>
        Public Sub TestVersionCompare(
            version1 As String,
            version2 As String,
            ExpectedResults As Integer)

            Dim result = CustomCode.VersionCompare(version1, version2)
            Assert.Equal(ExpectedResults, result)

        End Sub

        ''' <summary>
        ''' Tests the version compare.
        ''' </summary>
        ''' <paramname="version1">The version1.</param>
        ''' <paramname="version2">The version2.</param>
        ''' <paramname="ExpectedResult">The expected result.</param>
        <Theory>
        <InlineData("2", "2.0", 0)>
        <InlineData("2", "2.0.0", 0)>
        <InlineData("2", "2.0.0.0", 0)>
        <InlineData("2", "2.0.0.0.0", 0)>
        <InlineData("2", "2.0.0.0.1", -1)>
        <InlineData("2", "2.1", -1)>
        <InlineData("2.1.0", "2.0.1", 1)>
        <InlineData("2.10.0.1", "2.1.0.10", 1)>
        <InlineData("2.0.1", "1.2000.1", 1)>
        Public Sub TestLongVersionCompare(ByVal version1 As String, ByVal version2 As String, ByVal ExpectedResult As Integer)

            Dim result = CustomCode.LongVersionCompare(version1, version2)
            Assert.Equal(ExpectedResult, result)

        End Sub

    End Class

End Namespace

