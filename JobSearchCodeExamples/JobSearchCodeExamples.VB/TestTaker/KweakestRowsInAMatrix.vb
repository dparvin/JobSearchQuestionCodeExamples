Namespace TestTaker

    Public Class KweakestRowsInAMatrix

        ''' <summary>
        ''' the k weakest rows from the matrix.
        ''' </summary>
        ''' <paramname="mat">The mat.</param>
        ''' <paramname="k">The k.</param>
        ''' <returns></returns>
        Public Shared Function KWeakestRows(
            ByVal mat As Integer()(),
            ByVal k As Integer) As Integer()

            Dim indicies = New Dictionary(Of Integer, Integer)()
            For i = 0 To mat.Length - 1
                Dim solders = 0
                For j = 0 To mat(i).Length - 1
                    If mat(i)(j) = 1 Then solders += 1
                Next
                indicies.Add(i, solders)
            Next
            Dim result = indicies.ToArray()
            Array.Sort(result, Function(item1, item2) Compare(item1, item2))
            Dim ret = New Integer(k - 1) {}
            For i = 0 To k - 1
                ret(i) = result(i).Key
            Next

            Return ret

        End Function

        ''' <summary>
        ''' Compares the specified i1.
        ''' </summary>
        ''' <paramname="i1">The i1.</param>
        ''' <paramname="i2">The i2.</param>
        ''' <returns></returns>
        Private Shared Function Compare(
                ByVal i1 As KeyValuePair(Of Integer, Integer),
                ByVal i2 As KeyValuePair(Of Integer, Integer)) As Integer

            Dim result = i1.Value.CompareTo(i2.Value)

            If result = 0 Then result = i1.Key.CompareTo(i2.Key)

            Return result

        End Function

    End Class

End Namespace
