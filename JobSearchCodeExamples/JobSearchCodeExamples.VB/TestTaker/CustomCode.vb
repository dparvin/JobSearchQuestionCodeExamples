Namespace TestTaker

    ''' <summary>
    ''' 
    ''' </summary>
    Public Class CustomCode

        ''' <summary>
        ''' Versions the compare.
        ''' </summary>
        ''' <param name="version1">The version1.</param>
        ''' <param name="version2">The version2.</param>
        ''' <returns></returns>
        Public Shared Function VersionCompare(
            version1 As String,
            version2 As String) As Object

            Dim v1 As String() = version1.Split(".")
            Dim V2 As String() = version2.Split(".")
            Dim longest As Integer = If(v1.Length < V2.Length, V2.Length, v1.Length)
            For i As Integer = 0 To longest
                Dim item1 As Integer = 0
                Dim item2 As Integer = 0
                If i < v1.Length Then item1 = Integer.Parse(v1(i), CultureInfo.InvariantCulture)
                If i < V2.Length Then item2 = Integer.Parse(V2(i), CultureInfo.InvariantCulture)
                Dim results As Integer = If(item1 < item2, -1, If(item1 > item2, 1, 0))
                If results <> 0 Then Return results
            Next

            Return 0

        End Function

        ''' <summary>
        ''' Versions the compare.
        ''' </summary>
        ''' <paramname="version1">The version1.</param>
        ''' <paramname="version2">The version2.</param>
        ''' <returns></returns>
        Public Shared Function LongVersionCompare(
                ByVal version1 As String,
                ByVal version2 As String) As Integer

            Dim v1 As LongVersion = Nothing
            Dim v2 As LongVersion = Nothing
            If Not String.IsNullOrEmpty(version1) Then v1 = New LongVersion(version1)
            If Not String.IsNullOrEmpty(version2) Then v2 = New LongVersion(version2)
            If v1 Is Nothing Then
                If v2 Is Nothing Then Return 0 Else Return -1
            End If

            Return v1.CompareTo(v2)

        End Function

        ''' <summary>
        ''' Finds the missing entry.
        ''' </summary>
        ''' <paramname="values">The array of integers that is missing an item.</param>
        ''' <returns></returns>
        ''' <remarks>
        ''' This function only works when there is only one item missing in the array.  If
        ''' there are more than one then the return will be a sum of the two missing items.
        ''' </remarks>
        Public Shared Function FindMissingEntry(
                ByVal values As Integer()) As Integer

            Return (values.Length + 1) * (values.Length + 2) / 2 - values.Sum()

        End Function

        ''' <summary>
        ''' Compare two long version numbers using equal.
        ''' </summary>
        ''' <param name="version1">The version1.</param>
        ''' <param name="version2">The version2.</param>
        ''' <returns></returns>
        Public Shared Function LongVersionEqual(
                version1 As String,
                version2 As String) As Boolean

            Dim v1 As LongVersion = Nothing
            Dim v2 As LongVersion = Nothing
            If Not String.IsNullOrEmpty(version1) Then v1 = New LongVersion(version1)
            If Not String.IsNullOrEmpty(version2) Then v2 = New LongVersion(version2)

            Return v1 = v2

        End Function

        ''' <summary>
        ''' Compare two long version numbers using equal.
        ''' </summary>
        ''' <param name="version1">The version1.</param>
        ''' <param name="version2">The version2.</param>
        ''' <returns></returns>
        Public Shared Function LongVersionNotEqual(
                version1 As String,
                version2 As String) As Boolean

            Dim v1 As LongVersion = Nothing
            Dim v2 As LongVersion = Nothing
            If Not String.IsNullOrEmpty(version1) Then v1 = New LongVersion(version1)
            If Not String.IsNullOrEmpty(version2) Then v2 = New LongVersion(version2)

            Return v1 <> v2

        End Function

        ''' <summary>
        ''' the version is the same object.
        ''' </summary>
        ''' <paramname="version">The version.</param>
        ''' <returns></returns>
        Public Shared Function LongVersionEqualSame(ByVal version As String) As Boolean

            Dim v As LongVersion = Nothing
            If Not String.IsNullOrEmpty(version) Then v = New LongVersion(version)

            Return v = v

        End Function

        ''' <summary>
        ''' Get the hash code for the version.
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function LongVersionGetHashCode() As Integer

            Dim v = New LongVersion("2.0.0.1")

            Return v.GetHashCode()

        End Function

        ''' <summary>
        ''' Get the string version of the version.
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function LongVersionToString() As String

            Dim v = New LongVersion("2.0.0.1")

            Return v.ToString()

        End Function

        ''' <summary>
        ''' Compare two long version numbers using Greater Than.
        ''' </summary>
        ''' <param name="version1">The version1.</param>
        ''' <param name="version2">The version2.</param>
        ''' <returns></returns>
        Public Shared Function LongVersionGreater(
                version1 As String,
                version2 As String) As Boolean

            Dim v1 As LongVersion = Nothing
            Dim v2 As LongVersion = Nothing
            If Not String.IsNullOrEmpty(version1) Then v1 = New LongVersion(version1)
            If Not String.IsNullOrEmpty(version2) Then v2 = New LongVersion(version2)

            Return v1 > v2

        End Function

        ''' <summary>
        ''' Compare two long version numbers using Greater Than or equal to.
        ''' </summary>
        ''' <param name="version1">The version1.</param>
        ''' <param name="version2">The version2.</param>
        ''' <returns></returns>
        Public Shared Function LongVersionGreaterEqual(
                version1 As String,
                version2 As String) As Boolean

            Dim v1 As LongVersion = Nothing
            Dim v2 As LongVersion = Nothing
            If Not String.IsNullOrEmpty(version1) Then v1 = New LongVersion(version1)
            If Not String.IsNullOrEmpty(version2) Then v2 = New LongVersion(version2)

            Return v1 >= v2

        End Function

        ''' <summary>
        ''' Compare two long version numbers using Less Than.
        ''' </summary>
        ''' <param name="version1">The version1.</param>
        ''' <param name="version2">The version2.</param>
        ''' <returns></returns>
        Public Shared Function LongVersionLess(
                version1 As String,
                version2 As String) As Boolean

            Dim v1 As LongVersion = Nothing
            Dim v2 As LongVersion = Nothing
            If Not String.IsNullOrEmpty(version1) Then v1 = New LongVersion(version1)
            If Not String.IsNullOrEmpty(version2) Then v2 = New LongVersion(version2)

            Return v1 < v2

        End Function

        ''' <summary>
        ''' Compare two long version numbers using Less Than or equal to.
        ''' </summary>
        ''' <param name="version1">The version1.</param>
        ''' <param name="version2">The version2.</param>
        ''' <returns></returns>
        Public Shared Function LongVersionLessEqual(
                version1 As String,
                version2 As String) As Boolean

            Dim v1 As LongVersion = Nothing
            Dim v2 As LongVersion = Nothing
            If Not String.IsNullOrEmpty(version1) Then v1 = New LongVersion(version1)
            If Not String.IsNullOrEmpty(version2) Then v2 = New LongVersion(version2)

            Return v1 <= v2

        End Function

    End Class

End Namespace
