Imports System.Reflection.Metadata.Ecma335

Namespace TestTaker

    ''' <summary>
    ''' Assign the theater seats.
    ''' </summary>
    Public Class TheaterSeats

        ''' <summary>
        ''' Assigns the seats.
        ''' </summary>
        ''' <param name="seatsAssign">The seats assign.</param>
        ''' <param name="seatsRequested">The seats requested.</param>
        ''' <returns></returns>
        Public Shared Function AssignSeats(ByRef seatsAssign As Integer(), seatsRequested As Integer()) As Integer()

            Dim results(seatsRequested.Length - 1) As Integer
            Dim usedSeats As List(Of Integer) = seatsAssign.ToList()
            For i As Integer = 0 To seatsRequested.Length - 1
                Dim nextAvailableSeat As Integer = FindNextAvailableSeat(usedSeats, seatsRequested(i))
                results(i) = nextAvailableSeat
                usedSeats.Add(nextAvailableSeat)
            Next
            seatsAssign = usedSeats.ToArray()
            Return results

        End Function

        ''' <summary>
        ''' Finds the next available seat.
        ''' </summary>
        ''' <param name="usedSeats">The used seats.</param>
        ''' <param name="seat">The seat.</param>
        ''' <returns></returns>
        Private Shared Function FindNextAvailableSeat(usedSeats As List(Of Integer), seat As Integer) As Integer

            If Not usedSeats.Contains(seat) Then Return seat

            Dim diff As Integer = 1
            While True
                Dim lowerSeat As Integer = seat - diff
                Dim upperSeat As Integer = seat + diff
                If lowerSeat > 0 AndAlso Not usedSeats.Contains(lowerSeat) Then
                    Return lowerSeat
                ElseIf Not usedSeats.Contains(upperSeat) Then
                    Return upperSeat
                End If
                diff += 1
            End While

            Return 0

        End Function

        ''' <summary>
        ''' Assigns the seats.
        ''' </summary>
        ''' <param name="seatsAssign">The seats assign.</param>
        ''' <param name="seatsRequested">The seats requested.</param>
        ''' <returns></returns>
        Public Shared Function AssignSeats2(ByRef seatsAssign As Integer(), seatsRequested As Integer()) As Integer()

            Dim results As New List(Of Integer)()
            Dim usedSeats As List(Of Integer) = seatsAssign.ToList()
            For Each seat In seatsRequested
                Dim nextAvailableSeat As Integer = FindNextAvailableSeat2(usedSeats, seat)
                results.Add(nextAvailableSeat)
                usedSeats.Add(nextAvailableSeat)
            Next
            seatsAssign = usedSeats.ToArray()
            Return results.ToArray()

        End Function

        ''' <summary>
        ''' Finds the next available seat.
        ''' </summary>
        ''' <param name="usedSeats">The used seats.</param>
        ''' <param name="seat">The seat.</param>
        ''' <returns></returns>
        Private Shared Function FindNextAvailableSeat2(usedSeats As List(Of Integer), seat As Integer) As Integer

            If Not usedSeats.Contains(seat) Then Return seat

            Dim FindSeat As Func(Of Integer, Integer) =
                Function(ByVal diff As Integer) As Integer

                    Dim lowerSeat As Integer = seat - diff
                    Dim upperSeat As Integer = seat + diff

                    If lowerSeat > 0 AndAlso Not usedSeats.Contains(lowerSeat) Then Return lowerSeat
                    If Not usedSeats.Contains(upperSeat) Then Return upperSeat

                    Return FindSeat(diff + 1)

                End Function

            Return FindSeat(1)

        End Function

    End Class

End Namespace