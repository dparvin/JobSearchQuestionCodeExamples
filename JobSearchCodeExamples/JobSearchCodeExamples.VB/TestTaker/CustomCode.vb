Imports System.Globalization

Namespace JobSeearchCodeExamples.VB.TestTaker

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
        Public Shared Function LongVersionCompare(ByVal version1 As String, ByVal version2 As String) As Integer
            'Insert your code here 
            Dim v1 = New LongVersion(version1)
            Dim v2 = New LongVersion(version2)

            Return v1.CompareTo(v2)
        End Function
    End Class

End Namespace
