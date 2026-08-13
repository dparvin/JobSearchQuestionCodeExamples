Public Class ByValTest

    ''' <summary>
    ''' test of a parameter's ByVal option.
    ''' </summary>
    ''' <remarks>
    ''' This test shows that when a Value Type is passed as ByVal,
    ''' changing the parameter inside does not send the value back
    ''' out to the calling routine. With an Array, changing the
    ''' value of one of the elements of the array changes the value
    ''' in the original array. However, assigning a new array to the
    ''' parameter does not change which array the calling routine's
    ''' variable references.
    ''' </remarks>
    <Fact>
    Public Sub ByValTest()

        Dim item As Integer = 5
        Dim testArray() As Integer = {5, 12, 23, 52}
        Dim test2Array() As Integer = {5, 12, 23, 52}

        TestRoutine(item, testArray, test2Array)

        Assert.Equal(5, item)
        Assert.Equal({5, 12, 23, 52}, testArray)
        Assert.Equal(15, test2Array(1))

    End Sub

    Private Shared Sub TestRoutine(ByVal item As Integer, ByVal array() As Integer, ByVal array2() As Integer)

        item = 10
        array = {7, 15, 27, 72}
        array2(1) = 15

    End Sub

    <Fact>
    Public Sub ByRefTest()

        Dim item As Integer = 5
        Dim testArray() As Integer = {5, 12, 23, 52}
        Dim test2Array() As Integer = {5, 12, 23, 52}

        Assert.Equal(12, testArray(1))

        TestRoutine2(item, testArray, test2Array)

        Assert.Equal(10, item)
        Assert.Equal({7, 15, 27, 72}, testArray)
        Assert.Equal(15, test2Array(1))

    End Sub

    Private Shared Sub TestRoutine2(ByRef item As Integer, ByRef array() As Integer, ByRef array2() As Integer)

        item = 10
        array = {7, 15, 27, 72}
        array2(1) = 15

    End Sub

End Class
