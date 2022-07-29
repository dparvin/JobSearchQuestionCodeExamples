Imports JobSearchCodeExamples.VB.TestTaker
Imports Xunit

Namespace TestTaker

    Public Class WeakestRowsTest

        ''' <summary>
        ''' k the weakest rows in a matrix test.
        ''' </summary>
        <Fact>
        Public Sub KWeakestRowsInAMatrixTest()

            Dim testArray = {
                New Integer() {1, 1, 0, 0, 0},
                New Integer() {1, 1, 1, 1, 0},
                New Integer() {1, 0, 0, 0, 0},
                New Integer() {1, 1, 0, 0, 0},
                New Integer() {1, 1, 1, 1, 1}}

            Dim expectedResult = {2, 0, 3}

            Dim result As Integer() = KweakestRowsInAMatrix.KWeakestRows(testArray, 3)

            Assert.Equal(3, result.Length)
            Assert.Equal(expectedResult, result)

        End Sub

    End Class

End Namespace
