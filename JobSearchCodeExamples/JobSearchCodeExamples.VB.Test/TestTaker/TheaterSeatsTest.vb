Namespace TestTaker

    ''' <summary>
    ''' TheaterSeatsTest class contains unit tests for the TheaterSeats class.
    ''' </summary>
    Public Class TheaterSeatsTest

        <Fact>
        Public Sub AssignSeatsTest()

            Dim seatsAssign = New Integer() {1, 3, 5}
            Dim seatsRequested = New Integer() {2, 3, 4}
            Dim expectedResult = New Integer() {2, 4, 6}
            Dim result = TheaterSeats.AssignSeats(seatsAssign, seatsRequested)
            Assert.Equal(expectedResult, result)

        End Sub

        <Fact>
        Public Sub AssignSeats2Test()

            Dim seatsAssign = New Integer() {1, 3, 5}
            Dim seatsRequested = New Integer() {2, 3, 4}
            Dim expectedResult = New Integer() {2, 4, 6}
            Dim result = TheaterSeats.AssignSeats2(seatsAssign, seatsRequested)
            Assert.Equal(expectedResult, result)

        End Sub

    End Class

End Namespace