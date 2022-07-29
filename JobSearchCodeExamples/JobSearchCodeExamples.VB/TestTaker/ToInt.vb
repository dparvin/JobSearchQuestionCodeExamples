Namespace TestTaker

    Public Class ToInt

        ''' <summary>
        ''' Romans to int.
        ''' </summary>
        ''' <paramname="s">The s.</param>
        ''' <returns></returns>
        Public Shared Function RomanToInt(ByVal s As String) As Integer

            Dim pos = 0
            Dim result = 0
            While pos < s.Length
                Dim spos As String = s(pos).ToString()
                Dim snext = String.Empty
                If pos < s.Length - 1 Then snext = s(pos + 1).ToString()
                Select Case spos
                    Case "I"
                        If Equals(snext, "V") Then
                            result += 4
                            pos += 1
                        ElseIf Equals(snext, "X") Then
                            result += 9
                            pos += 1
                        Else
                            result += 1
                        End If
                    Case "V"
                        result += 5
                    Case "X"
                        If Equals(snext, "L") Then
                            result += 40
                            pos += 1
                        ElseIf Equals(snext, "C") Then
                            result += 90
                            pos += 1
                        Else
                            result += 10
                        End If
                    Case "L"
                        result += 50
                    Case "C"
                        If Equals(snext, "D") Then
                            result += 400
                            pos += 1
                        ElseIf Equals(snext, "M") Then
                            result += 900
                            pos += 1
                        Else
                            result += 100
                        End If
                    Case "D"
                        result += 500
                    Case "M"
                        result += 1000

                End Select
                pos += 1
            End While
            Return result

        End Function

        ''' <summary>
        ''' Romans to int.
        ''' </summary>
        ''' <paramname="s">The s.</param>
        ''' <returns></returns>
        Public Shared Function RomanToInt2(ByVal s As String) As Integer

            Dim roman = {"I", "V", "X", "L", "C", "D", "M"}
            Dim values = {1, 5, 10, 50, 100, 500, 1000}
            Dim before = {"I", "X", "C"}
            Dim after = {New String() {"V", "X"}, New String() {"L", "C"}, New String() {"D", "M"}}
            Dim extraValues = {New Integer() {4, 9}, New Integer() {40, 90}, New Integer() {400, 900}}
            Dim pos = 0
            Dim result = 0
            While pos < s.Length
                Dim spos As String = s(pos).ToString()
                Dim snext = String.Empty
                If pos < s.Length - 1 Then snext = s(pos + 1).ToString()
                Dim romanIndex = Array.IndexOf(roman, spos)
                If before.Contains(spos) AndAlso Not String.IsNullOrEmpty(snext) Then
                    Dim beforeIndex = Array.IndexOf(before, spos)
                    If after(beforeIndex).Contains(snext) Then
                        result += extraValues(beforeIndex)(Array.IndexOf(after(beforeIndex), snext))
                        pos += 1
                    Else
                        result += values(romanIndex)
                    End If
                Else
                    result += values(romanIndex)
                End If
                pos += 1
            End While
            Return result

        End Function

        ''' <summary>
        ''' Romans to int.
        ''' </summary>
        ''' <paramname="s">The s.</param>
        ''' <returns></returns>
        Public Shared Function RomanToInt3(ByVal s As String) As Integer

            Dim RomanValues As New Dictionary(Of String, Int32) From {
            {"I", 1},
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000}
        }
            Dim pos = 0
            Dim result = 0
            While pos < s.Length
                Dim spos As String = s(pos).ToString()
                Dim snext = String.Empty
                If pos < s.Length - 1 Then snext = s(pos + 1).ToString()
                If String.IsNullOrEmpty(snext) Then
                    result += RomanValues(spos)
                ElseIf RomanValues(spos) < RomanValues(snext) Then
                    result -= RomanValues(spos)
                Else
                    result += RomanValues(spos)
                End If
                pos += 1
            End While
            Return result
        End Function

    End Class

End Namespace
