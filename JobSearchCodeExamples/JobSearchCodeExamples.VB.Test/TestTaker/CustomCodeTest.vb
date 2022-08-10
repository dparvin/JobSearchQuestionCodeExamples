Namespace TestTaker

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
        ''' Tests the long version compare.
        ''' </summary>
        ''' <param name="version1">The version1.</param>
        ''' <param name="version2">The version2.</param>
        ''' <param name="ExpectedResult">The expected result.</param>
        <Theory>
        <InlineData("", "", 0)>
        <InlineData("", "2.0", -1)>
        <InlineData("2", "", 1)>
        <InlineData("2", "2.0", 0)>
        <InlineData("2", "2.0.0", 0)>
        <InlineData("2", "2.0.0.0", 0)>
        <InlineData("2", "2.0.0.0.0", 0)>
        <InlineData("2", "2.0.0.0.1", -1)>
        <InlineData("2", "2.1", -1)>
        <InlineData("2.1.0", "2.0.1", 1)>
        <InlineData("2.10.0.1", "2.1.0.10", 1)>
        <InlineData("2.0.1", "1.2000.1", 1)>
        Public Sub TestLongVersionCompare(
                ByVal version1 As String,
                ByVal version2 As String,
                ByVal ExpectedResult As Integer)

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

        ''' <summary>
        ''' Tests the version compare.
        ''' </summary>
        ''' <paramname="version1">The version1.</param>
        ''' <paramname="version2">The version2.</param>
        ''' <paramname="ExpectedResult">The expected result.</param>
        <Theory>
        <InlineData("", "", True)>
        <InlineData("", "2.0", False)>
        <InlineData("2", "", False)>
        <InlineData("2", "2.0", True)>
        <InlineData("2.0.0", "2", True)>
        <InlineData("2", "2.0.0.0", True)>
        <InlineData("2", "2.0.0.0.0", True)>
        <InlineData("2", "2.0.0.0.1", False)>
        <InlineData("2", "2.1", False)>
        <InlineData("2.1.0", "2.0.1", False)>
        <InlineData("2.10.0.1", "2.1.0.10", False)>
        <InlineData("2.0.1", "1.2000.1", False)>
        Public Sub TestLongVersionEqual(
                ByVal version1 As String,
                ByVal version2 As String,
                ByVal ExpectedResult As Boolean)

            Dim result As Boolean = CustomCode.LongVersionEqual(version1, version2)
            Assert.Equal(ExpectedResult, result)

        End Sub

        ''' <summary>
        ''' Tests the version compare.
        ''' </summary>
        ''' <paramname="version1">The version1.</param>
        ''' <paramname="version2">The version2.</param>
        ''' <paramname="ExpectedResult">The expected result.</param>
        <Theory>
        <InlineData("", "", False)>
        <InlineData("", "2.0", True)>
        <InlineData("2", "", True)>
        <InlineData("2", "2.0", False)>
        <InlineData("2.0.0", "2", False)>
        <InlineData("2", "2.0.0.0", False)>
        <InlineData("2", "2.0.0.0.0", False)>
        <InlineData("2", "2.0.0.0.1", True)>
        <InlineData("2", "2.1", True)>
        <InlineData("2.1.0", "2.0.1", True)>
        <InlineData("2.10.0.1", "2.1.0.10", True)>
        <InlineData("2.0.1", "1.2000.1", True)>
        Public Sub TestLongVersionNotEqual(
                ByVal version1 As String,
                ByVal version2 As String,
                ByVal ExpectedResult As Boolean)

            Dim result As Boolean = CustomCode.LongVersionNotEqual(version1, version2)
            Assert.Equal(ExpectedResult, result)

        End Sub

        ''' <summary>
        ''' Tests the version compare.
        ''' </summary>
        ''' <paramname="version1">The version1.</param>
        ''' <paramname="version2">The version2.</param>
        ''' <paramname="ExpectedResult">The expected result.</param>
        <Fact>
        Public Sub TestLongVersionEqualSame()

            Dim result = CustomCode.LongVersionEqualSame("2")
            Assert.True(result)

        End Sub

        ''' <summary>
        ''' Longs the version get hash code.
        ''' </summary>
        <Fact>
        Public Sub LongVersionGetHashCode()

            Dim result = CustomCode.LongVersionGetHashCode()
            Assert.Equal(9827, result)

        End Sub

        ''' <summary>
        ''' Longs the version to string.
        ''' </summary>
        <Fact>
        Public Sub LongVersionToString()

            Dim result = CustomCode.LongVersionToString()
            Assert.Equal("2.0.0.1", result)

        End Sub

        ''' <summary>
        ''' Longs the version greater.
        ''' </summary>
        ''' <param name="version1">The version1.</param>
        ''' <param name="version2">The version2.</param>
        ''' <param name="ExpectedResult">if set to <c>true</c> [expected result].</param>
        <Theory>
        <InlineData("", "", False)>
        <InlineData("", "2.0", False)>
        <InlineData("2", "", True)>
        <InlineData("2", "2.0", False)>
        <InlineData("2", "2.0.0", False)>
        <InlineData("2", "2.0.0.0", False)>
        <InlineData("2", "2.0.0.0.0", False)>
        <InlineData("2", "2.0.0.0.1", False)>
        <InlineData("2", "2.1", False)>
        <InlineData("2.1.0", "2.0.1", True)>
        <InlineData("2.10.0.1", "2.1.0.10", True)>
        <InlineData("2.0.1", "1.2000.1", True)>
        Public Sub LongVersionGreater(
                ByVal version1 As String,
                ByVal version2 As String,
                ByVal ExpectedResult As Boolean)

            Dim result As Boolean = CustomCode.LongVersionGreater(version1, version2)
            Assert.Equal(ExpectedResult, result)

        End Sub

        ''' <summary>
        ''' Longs the version greater equal.
        ''' </summary>
        ''' <param name="version1">The version1.</param>
        ''' <param name="version2">The version2.</param>
        ''' <param name="ExpectedResult">if set to <c>true</c> [expected result].</param>
        <Theory>
        <InlineData("", "", True)>
        <InlineData("", "2.0", False)>
        <InlineData("2", "", True)>
        <InlineData("2", "2.0", True)>
        <InlineData("2", "2.0.0", True)>
        <InlineData("2", "2.0.0.0", True)>
        <InlineData("2", "2.0.0.0.0", True)>
        <InlineData("2", "2.0.0.0.1", False)>
        <InlineData("2", "2.1", False)>
        <InlineData("2.1.0", "2.0.1", True)>
        <InlineData("2.10.0.1", "2.1.0.10", True)>
        <InlineData("2.0.1", "1.2000.1", True)>
        Public Sub LongVersionGreaterEqual(
                ByVal version1 As String,
                ByVal version2 As String,
                ByVal ExpectedResult As Boolean)

            Dim result As Boolean = CustomCode.LongVersionGreaterEqual(version1, version2)
            Assert.Equal(ExpectedResult, result)

        End Sub

        ''' <summary>
        ''' Longs the version less.
        ''' </summary>
        ''' <param name="version1">The version1.</param>
        ''' <param name="version2">The version2.</param>
        ''' <param name="ExpectedResult">if set to <c>true</c> [expected result].</param>
        <Theory>
        <InlineData("", "", False)>
        <InlineData("", "2.0", True)>
        <InlineData("2", "", False)>
        <InlineData("2", "2.0", False)>
        <InlineData("2", "2.0.0", False)>
        <InlineData("2", "2.0.0.0", False)>
        <InlineData("2", "2.0.0.0.0", False)>
        <InlineData("2", "2.0.0.0.1", True)>
        <InlineData("2", "2.1", True)>
        <InlineData("2.1.0", "2.0.1", False)>
        <InlineData("2.10.0.1", "2.1.0.10", False)>
        <InlineData("2.0.1", "1.2000.1", False)>
        Public Sub LongVersionLess(
                ByVal version1 As String,
                ByVal version2 As String,
                ByVal ExpectedResult As Boolean)

            Dim result As Boolean = CustomCode.LongVersionLess(version1, version2)
            Assert.Equal(ExpectedResult, result)

        End Sub

        ''' <summary>
        ''' Longs the version less equal.
        ''' </summary>
        ''' <param name="version1">The version1.</param>
        ''' <param name="version2">The version2.</param>
        ''' <param name="ExpectedResult">if set to <c>true</c> [expected result].</param>
        <Theory>
        <InlineData("", "", True)>
        <InlineData("", "2.0", True)>
        <InlineData("2", "", False)>
        <InlineData("2", "2.0", True)>
        <InlineData("2", "2.0.0", True)>
        <InlineData("2", "2.0.0.0", True)>
        <InlineData("2", "2.0.0.0.0", True)>
        <InlineData("2", "2.0.0.0.1", True)>
        <InlineData("2", "2.1", True)>
        <InlineData("2.1.0", "2.0.1", False)>
        <InlineData("2.10.0.1", "2.1.0.10", False)>
        <InlineData("2.0.1", "1.2000.1", False)>
        Public Sub LongVersionLessEqual(
                ByVal version1 As String,
                ByVal version2 As String,
                ByVal ExpectedResult As Boolean)

            Dim result As Boolean = CustomCode.LongVersionLessEqual(version1, version2)
            Assert.Equal(ExpectedResult, result)

        End Sub

    End Class

End Namespace
