Namespace TestTaker

    ''' <summary>
    ''' 
    ''' </summary>
    Public Class RansomNodeTest

        <Theory>
        <InlineData("a", "b", False)>
        <InlineData("aa", "ab", False)>
        <InlineData("aa", "aab", True)>
        <InlineData("aa", "b", False)>
        <InlineData("aabc", "aabd", False)>
        Public Sub CanConstructTest(ByVal Note As String, ByVal magazine As String, ByVal expectedResult As Boolean)
            Assert.Equal(expectedResult, RansomNote.CanConstruct(Note, magazine))
        End Sub

    End Class

End Namespace
