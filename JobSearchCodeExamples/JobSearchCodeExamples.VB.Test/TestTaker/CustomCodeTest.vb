Imports JobSearchCodeExamples.VB.JobSeearchCodeExamples.VB.TestTaker
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

        ''' <summary>
        ''' Finds the missing number.
        ''' </summary>
        ''' <remarks>
        ''' Question: How do you find the missing number in an array of 1-100?
        ''' This routine will mathematically figure out which number is missing.  The Arrange
        ''' part creates an array of integers with one item missing.  The Act part gets a total
        ''' of all of the items in the array and calculates what the total should be if all of
        ''' the items were in the array ( formula: n(n+1)/2 ).  Subtracting the two numbers 
        ''' gives you the value that is missing from the array.
        ''' 
        ''' This test actually randomly removes the item that is missing, so the item missing 
        ''' is different every time the routine is run.
        ''' </remarks>
        <Fact>
        Public Sub FindMissingNumber()
            ' Arrange
            Dim expectedMax = 100
            Dim a As Integer()
            ReDim a(expectedMax - 2)
            Dim missing As Integer = New Random().Next(expectedMax) + 1
            Dim i = 1
            For j = 0 To a.Length - 1
                If i = missing Then i += 1
                a(j) = i
                i += 1
            Next

            ' Act
            Dim FoundMissing As Integer = CustomCode.FindMissingEntry(a)

            ' Assert
            Assert.Equal(missing, FoundMissing)
        End Sub
    End Class

End Namespace

