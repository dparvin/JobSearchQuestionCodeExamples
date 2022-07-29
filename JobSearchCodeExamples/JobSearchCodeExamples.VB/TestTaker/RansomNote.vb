Namespace TestTaker

    Public Class RansomNote

        ''' <summary>
        ''' Determines whether this instance can construct the specified ransom node.
        ''' </summary>
        ''' <param name="ransomNode">The ransom node.</param>
        ''' <param name="magazine">The magazine.</param>
        ''' <returns>
        '''   <c>true</c> if this instance can construct the specified ransom node; otherwise, <c>false</c>.
        ''' </returns>
        Public Shared Function CanConstruct(
        ByVal ransomNode As String,
        ByVal magazine As String) As Boolean

            If magazine.Length < ransomNode.Length Then Return False
            Dim source As String = magazine
            Dim note As Char() = ransomNode.ToCharArray()
            For i As Integer = 0 To ransomNode.Length - 1
                If source.Contains(note(i)) Then
                    source = source.Remove(source.IndexOf(note(i)), 1)
                Else
                    Return False
                End If
            Next

            Return True

        End Function

    End Class

End Namespace
