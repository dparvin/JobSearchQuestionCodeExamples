Namespace TestTaker

    ''' <summary>
    ''' tests for code from LeetCode
    ''' </summary>
    Public Class LeetCodeTest

#Region " FizzBuzz code tests --------------------------------------- "

        <Theory>
        <InlineData(3, New String() {"1", "2", "Fizz"})>
        <InlineData(5, New String() {"1", "2", "Fizz", "4", "Buzz"})>
        <InlineData(15, New String() {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"})>
        Public Sub FizzBuss1Test(ByVal n As Integer, ByVal expectedResult As String())
            Assert.Equal(expectedResult, LeetCode.FizzBuzz(n).ToArray())
        End Sub

        <Theory>
        <InlineData(3, New String() {"1", "2", "Fizz"})>
        <InlineData(5, New String() {"1", "2", "Fizz", "4", "Buzz"})>
        <InlineData(15, New String() {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"})>
        Public Sub FizzBuss2Test(ByVal n As Integer, ByVal expectedResult As String())
            Assert.Equal(expectedResult, LeetCode.FizzBuzz2(n).ToArray())
        End Sub

        <Theory>
        <InlineData(3, New String() {"1", "2", "Fizz"})>
        <InlineData(5, New String() {"1", "2", "Fizz", "4", "Buzz"})>
        <InlineData(15, New String() {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"})>
        Public Sub FizzBuss3Test(ByVal n As Integer, ByVal expectedResult As String())
            Assert.Equal(expectedResult, LeetCode.FizzBuzz3(n).ToArray())
        End Sub

        <Theory>
        <InlineData(3, New String() {"1", "2", "Fizz"})>
        <InlineData(5, New String() {"1", "2", "Fizz", "4", "Buzz"})>
        <InlineData(15, New String() {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"})>
        Public Sub FizzBuss4Test(ByVal n As Integer, ByVal expectedResult As String())
            Assert.Equal(expectedResult, LeetCode.FizzBuzz4(n).ToArray())
        End Sub

        <Theory>
        <InlineData(3, New String() {"1", "2", "Fizz"})>
        <InlineData(5, New String() {"1", "2", "Fizz", "4", "Buzz"})>
        <InlineData(15, New String() {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"})>
        Public Sub FizzBuss5Test(ByVal n As Integer, ByVal expectedResult As String())
            Assert.Equal(expectedResult, LeetCode.FizzBuzz5(n).ToArray())
        End Sub

        <Theory>
        <InlineData(3, New String() {"1", "2", "Fizz"})>
        <InlineData(5, New String() {"1", "2", "Fizz", "4", "Buzz"})>
        <InlineData(15, New String() {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"})>
        Public Sub FizzBuss6Test(ByVal n As Integer, ByVal expectedResult As String())
            Assert.Equal(expectedResult, LeetCode.FizzBuzz6(n).ToArray())
        End Sub

#End Region

#Region " Middle of the linked list tests --------------------------- "

        ''' <summary>
        ''' Middles the node1 test.
        ''' </summary>
        <Theory>
        <InlineData(New Integer() {1, 2, 3, 4, 5}, New Integer() {3, 4, 5})>
        <InlineData(New Integer() {1, 2, 3, 4, 5, 6}, New Integer() {4, 5, 6})>
        <InlineData(New Integer() {3}, New Integer() {3})>
        <InlineData(Nothing, Nothing)>
        Public Sub MiddleNodeTest(ByVal items As Integer(), ByVal expectedResult As Integer())
            Assert.Equal(expectedResult, ToArray(LeetCode.MiddleNode(ToListNode(items))))
        End Sub

#End Region

#Region " Palindrome Lined List ------------------------------------- "

        ''' <summary>
        ''' Determines whether [is palindrome1 test].
        ''' </summary>
        <Theory>
        <InlineData(New Integer() {1}, True)>
        <InlineData(New Integer() {1, 2, 3, 2, 1}, True)>
        <InlineData(New Integer() {1, 2, 3, 2}, False)>
        <InlineData(New Integer() {1, 2, 3, 3, 2, 1}, True)>
        <InlineData(New Integer() {1, 2, 3, 4, 2, 1}, False)>
        <InlineData(Nothing, True)>
        Public Sub IsPalindrome1Test(ByVal items As Integer(), ByVal expectedResult As Boolean)
            Assert.Equal(expectedResult, LeetCode.IsPalindrome(ToListNode(items)))
        End Sub

        <Theory>
        <InlineData(New Integer() {1}, True)>
        <InlineData(New Integer() {1, 2, 3, 2, 1}, True)>
        <InlineData(New Integer() {1, 2, 3, 2}, False)>
        <InlineData(New Integer() {1, 2, 3, 3, 2, 1}, True)>
        <InlineData(New Integer() {1, 2, 3, 4, 2, 1}, False)>
        <InlineData(Nothing, True)>
        Public Sub IsPalindrome2Test(ByVal items As Integer(), ByVal expectedResult As Boolean)
            Assert.Equal(expectedResult, LeetCode.IsPalindrome2(ToListNode(items)))
        End Sub

        <Theory>
        <InlineData(New Integer() {1}, True)>
        <InlineData(New Integer() {1, 2, 3, 2, 1}, True)>
        <InlineData(New Integer() {1, 2, 3, 2}, False)>
        <InlineData(New Integer() {1, 2, 3, 3, 2, 1}, True)>
        <InlineData(New Integer() {1, 2, 3, 4, 2, 1}, False)>
        <InlineData(Nothing, True)>
        Public Sub IsPalindrome3Test(ByVal items As Integer(), ByVal expectedResult As Boolean)
            Assert.Equal(expectedResult, LeetCode.IsPalindrome3(ToListNode(items)))
        End Sub

#End Region

#Region " Add Two Numbers ------------------------------------------- "

        ''' <summary>
        ''' Adds the two numbers1 test.
        ''' </summary>
        <Theory>
        <InlineData(New Integer() {0}, New Integer() {0}, New Integer() {0})>
        <InlineData(New Integer() {2, 4, 3}, New Integer() {5, 6, 4}, New Integer() {7, 0, 8})>
        <InlineData(New Integer() {2, 4, 3}, Nothing, New Integer() {2, 4, 3})>
        <InlineData(New Integer() {9, 9, 9, 9, 9, 9, 9}, New Integer() {9, 9, 9, 9}, New Integer() {8, 9, 9, 9, 0, 0, 0, 1})>
        <InlineData(New Integer() {9}, New Integer() {1, 9, 9, 9, 9, 9, 9, 9, 9, 9}, New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1})>
        <InlineData(Nothing, New Integer() {5, 6, 4}, New Integer() {5, 6, 4})>
        <InlineData(Nothing, Nothing, Nothing)>
        Public Sub AddTwoNumbers1Test(ByVal items1 As Integer(), ByVal items2 As Integer(), ByVal expectedResult As Integer())
            Assert.Equal(expectedResult, ToArray(LeetCode.AddTwoNumbers(ToListNode(items1), ToListNode(items2))))
        End Sub

#End Region

#Region " Median of Two Sorted Arrays ------------------------------- "

        ''' <summary>
        ''' Finds the median sorted arrays.
        ''' </summary>
        ''' <paramname="nums1">The nums1.</param>
        ''' <paramname="nums2">The nums2.</param>
        ''' <paramname="expectedResults">The expected results.</param>
        <Theory>
        <InlineData(New Integer() {1, 2}, New Integer() {3, 4}, 2.5)>
        <InlineData(New Integer() {1, 3}, New Integer() {2}, 2)>
        <InlineData(New Integer() {1, 3}, Nothing, 2)>
        <InlineData(Nothing, New Integer() {2}, 2)>
        <InlineData(Nothing, Nothing, 0)>
        Public Sub FindMedianSortedArrays(ByVal nums1 As Integer(), ByVal nums2 As Integer(), ByVal expectedResults As Double)
            Assert.Equal(expectedResults, LeetCode.FindMedianSortedArrays(nums1, nums2))
        End Sub

#End Region

#Region " Test Support functions ------------------------------------ "

        ''' <summary>
        ''' Converts to ListNode.
        ''' </summary>
        ''' <param name="items">The items.</param>
        ''' <returns></returns>
        Private Shared Function ToListNode(ByVal items As Integer()) As LeetCode.ListNode

            If items Is Nothing Then Return Nothing
            Dim result As LeetCode.ListNode = Nothing

            For i = items.Length - 1 To 0 Step -1
                result = New LeetCode.ListNode(items(i), result)
            Next

            Return result

        End Function

        ''' <summary>
        ''' Converts to array.
        ''' </summary>
        ''' <param name="nodes">The nodes.</param>
        ''' <returns></returns>
        Private Shared Function ToArray(ByVal nodes As LeetCode.ListNode) As Integer()

            If nodes Is Nothing Then Return Nothing
            Dim result() As Integer = Array.Empty(Of Integer)()

            Do While (nodes IsNot Nothing)
                ReDim Preserve result(result.Length)
                result(result.Length - 1) = nodes.val
                nodes = nodes.next
            Loop

            Return result

        End Function

#End Region

    End Class

End Namespace
