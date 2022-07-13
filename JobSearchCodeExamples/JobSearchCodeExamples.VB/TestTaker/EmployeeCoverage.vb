Public Class EmployeeCoverage

    ''' <summary>
    ''' Maximums the coverage.
    ''' </summary>
    ''' <paramname="employees">The employees.</param>
    ''' <returns></returns>
    Public Shared Function MaxCoverage(
            ByVal employees As String()) As Integer

        Dim combined As Integer() = New Integer(employees.Length - 1) {}

        For i As Integer = 0 To employees.Length - 1
            Dim years = employees(i).Split("-")
            Dim startDate = Integer.Parse(years(0))
            Dim endDate = Integer.Parse(years(1))
            For j As Integer = i + 1 To employees.Length - 1
                Dim years2 = employees(j).Split("-")
                Dim start = Integer.Parse(years2(0))
                Dim [end] = Integer.Parse(years2(1))
                If startDate <= start AndAlso endDate >= start OrElse
                   startDate <= [end] AndAlso endDate >= [end] OrElse
                   startDate <= start AndAlso endDate >= [end] OrElse
                   startDate >= start AndAlso endDate <= [end] Then
                    combined(i) += If(combined(i) = 0, 2, 1)
                    combined(j) += If(combined(j) = 0, 2, 1)
                End If
            Next
        Next
        Dim maxValue = 0
        For i As Integer = 0 To employees.Length - 1
            If combined(i) > maxValue Then maxValue = combined(i)
        Next

        Return maxValue

    End Function

End Class
