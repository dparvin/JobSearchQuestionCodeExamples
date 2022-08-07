Public Class LeetCode

#Region " FizzBuzz Code --------------------------------------------- "

    ' These are the 6 different tries I did to answer the question.
    ' Each of them is a little different, mostly to try to speed up
    ' the process, but some of them to also get a smaller memory 
    ' footprint.

    ''' <summary>
    ''' Fizz and buzz items.
    ''' </summary>
    ''' <paramname="n">The n.</param>
    ''' <returns></returns>
    Public Shared Function FizzBuzz(ByVal n As Integer) As IList(Of String)

        Dim result = New List(Of String)()
        For i = 1 To n
            If i Mod 3 = 0 AndAlso i Mod 5 = 0 Then
                result.Add("FizzBuzz")
            ElseIf i Mod 3 = 0 Then
                result.Add("Fizz")
            ElseIf i Mod 5 = 0 Then
                result.Add("Buzz")
            Else
                result.Add(i.ToString())
            End If
        Next
        Return result

    End Function

    ''' <summary>
    ''' Fizz and buzz items.
    ''' </summary>
    ''' <paramname="n">The n.</param>
    ''' <returns></returns>
    Public Shared Function FizzBuzz2(ByVal n As Integer) As IList(Of String)

        Dim result = New String(n - 1) {}
        For i = 1 To n
            If i Mod 3 = 0 AndAlso i Mod 5 = 0 Then
                result(i - 1) = "FizzBuzz"
            ElseIf i Mod 3 = 0 Then
                result(i - 1) = "Fizz"
            ElseIf i Mod 5 = 0 Then
                result(i - 1) = "Buzz"
            Else
                result(i - 1) = i.ToString()
            End If
        Next
        Return result

    End Function

    ''' <summary>
    ''' Fizz and buzz items.
    ''' </summary>
    ''' <paramname="n">The n.</param>
    ''' <returns></returns>
    Public Shared Function FizzBuzz3(ByVal n As Integer) As IList(Of String)

        Dim result = New String(n - 1) {}
        For i = 0 To n - 1
            Dim byThree = (i + 1) Mod 3 = 0
            Dim byFive = (i + 1) Mod 5 = 0
            result(i) = String.Empty
            If byThree OrElse byFive Then
                If byThree Then result(i) += "Fizz"
                If byFive Then result(i) += "Buzz"
            Else
                result(i) = (i + 1).ToString()
            End If
        Next
        Return result

    End Function

    ''' <summary>
    ''' Fizz and buzz items.
    ''' </summary>
    ''' <paramname="n">The n.</param>
    ''' <returns></returns>
    Public Shared Function FizzBuzz4(ByVal n As Integer) As IList(Of String)

        Dim result = New String(n - 1) {}
        For i = 0 To n - 1
            Dim byThree = (i + 1) Mod 3 = 0
            Dim byFive = (i + 1) Mod 5 = 0
            If byThree AndAlso byFive Then
                result(i) = "FizzBuzz"
            ElseIf byThree Then
                result(i) = "Fizz"
            ElseIf byFive Then
                result(i) = "Buzz"
            Else
                result(i) = (i + 1).ToString()
            End If
        Next
        Return result

    End Function

    ''' <summary>
    ''' Fizz and buzz items.
    ''' </summary>
    ''' <paramname="n">The n.</param>
    ''' <returns></returns>
    Public Shared Function FizzBuzz5(ByVal n As Integer) As IList(Of String)

        Dim result = New String(n - 1) {}
        For i = 0 To n - 1
            Dim value = i + 1
            Dim byThree = value Mod 3 = 0
            Dim byFive = value Mod 5 = 0
            If byThree AndAlso byFive Then
                result(i) = "FizzBuzz"
            ElseIf byThree Then
                result(i) = "Fizz"
            ElseIf byFive Then
                result(i) = "Buzz"
            Else
                result(i) = value.ToString()
            End If
        Next
        Return result

    End Function

    ''' <summary>
    ''' Fizz and buzz items.
    ''' </summary>
    ''' <paramname="n">The n.</param>
    ''' <returns></returns>
    Public Shared Function FizzBuzz6(ByVal n As Integer) As IList(Of String)

        Dim result = New String(n - 1) {}
        For i = 0 To n - 1
            Dim value As Integer = i + 1
            Dim byThree = value Mod 3 = 0
            Dim byFive = value Mod 5 = 0
            If byThree AndAlso byFive Then
                result(i) = "FizzBuzz"
            ElseIf byThree Then
                result(i) = "Fizz"
            ElseIf byFive Then
                result(i) = "Buzz"
            Else
                result(i) = value.ToString()
            End If
        Next
        Return result

    End Function

#End Region

#Region " Middle of the linked list --------------------------------- "

    ''' <summary>
    ''' Middles the node.
    ''' </summary>
    ''' <paramname="head">The head.</param>
    ''' <returns></returns>
    Public Shared Function MiddleNode(ByVal head As ListNode) As ListNode

        If head Is Nothing OrElse head.next Is Nothing Then Return head
        Dim items = Count(head)
        Dim mid As Integer = items / 2
        Dim curr = head
        For i = 0 To mid - 1
            curr = curr.next
        Next
        Return curr

    End Function

    ''' <summary>
    ''' Counts the specified head.
    ''' </summary>
    ''' <paramname="head">The head.</param>
    ''' <returns></returns>
    Private Shared Function Count(ByVal head As ListNode) As Integer
        Dim result = 0
        Dim curr = head
        While curr IsNot Nothing
            result += 1
            curr = curr.next
        End While
        Return result
    End Function

#Region " single linked list ---------------------------------------- "

    ''' <summary>
    ''' Definition for singly-linked list.
    ''' </summary>
    Public Class ListNode
        ''' <summary>
        ''' The value
        ''' </summary>
        Public val As Integer
        ''' <summary>
        ''' The next
        ''' </summary>
        Public [next] As ListNode
        ''' <summary>
        ''' Initializes a new instance of the <seecref="ListNode"/> class.
        ''' </summary>
        ''' <paramname="val">The value.</param>
        ''' <paramname="next">The next.</param>
        Public Sub New(ByVal Optional val As Integer = 0, ByVal Optional [next] As ListNode = Nothing)
            Me.val = val
            Me.next = [next]
        End Sub
    End Class


#End Region

#End Region

#Region " Palindrome Linked List? ----------------------------------- "

    ''' <summary>
    ''' Determines whether the specified head is palindrome.
    ''' </summary>
    ''' <paramname="head">The head.</param>
    ''' <returns>
    '''   <c>true</c> if the specified head is palindrome; otherwise, <c>false</c>.
    ''' </returns>
    Public Shared Function IsPalindrome(ByVal head As ListNode) As Boolean

        Dim back As New ListNode()
        Dim curr As ListNode = head
        If curr Is Nothing Then Return True
        back.val = curr.val
        curr = curr.next
        While curr IsNot Nothing
            Dim newitem As New ListNode(curr.val, back)
            back = newitem
            curr = curr.next
        End While
        curr = head
        Dim rev As ListNode = back
        While curr IsNot Nothing
            If curr.val <> rev.val Then Return False
            curr = curr.next
            rev = rev.next
        End While

        Return True

    End Function

    ''' <summary>
    ''' Determines whether the specified head is palindrome2.
    ''' </summary>
    ''' <paramname="head">The head.</param>
    ''' <returns>
    '''   <c>true</c> if the specified head is palindrome2; otherwise, <c>false</c>.
    ''' </returns>
    Public Shared Function IsPalindrome2(ByVal head As ListNode) As Boolean

        If head?.next Is Nothing Then Return True

        Dim curr = head
        Dim rev = Reverse(curr)
        While curr IsNot Nothing
            If curr.val <> rev.val Then Return False
            curr = curr.next
            rev = rev.next
        End While

        Return True

    End Function

    ''' <summary>
    ''' Determines whether the specified head is palindrome3.
    ''' </summary>
    ''' <paramname="head">The head.</param>
    ''' <returns>
    '''   <c>true</c> if the specified head is palindrome3; otherwise, <c>false</c>.
    ''' </returns>
    Public Shared Function IsPalindrome3(ByVal head As ListNode) As Boolean

        If head?.next Is Nothing Then Return True

        Dim midPoint = PalindromeCount(head) / 2 + 1
        Dim curr = head
        Dim rev = Reverse(curr)
        Dim count = 0

        While curr IsNot Nothing
            If curr.val <> rev.val Then Return False
            If count > midPoint Then Return True ' past the midpoint so we are done
            curr = curr.next
            rev = rev.next
        End While

        Return True

    End Function

    ''' <summary>
    ''' Adds the two numbers.
    ''' </summary>
    ''' <paramname="l1">The l1.</param>
    ''' <paramname="l2">The l2.</param>
    ''' <returns></returns>
    Public Shared Function AddTwoNumbers(ByVal l1 As ListNode, ByVal l2 As ListNode) As ListNode

        If l1 Is Nothing Then Return l2
        If l2 Is Nothing Then Return l1
        Dim carry = 0
        Dim a As Integer = l1.val
        Dim b As Integer = l2.val
        Dim result As New ListNode()
        While l1 IsNot Nothing OrElse l2 IsNot Nothing
            result.val = a + b + carry
            If result.val > 9 Then
                carry = 1
                result.val = result.val Mod 10
            Else
                carry = 0
            End If
            If l1 IsNot Nothing Then
                l1 = l1.next
                a = If(l1 Is Nothing, 0, l1.val)
            End If
            If l2 IsNot Nothing Then
                l2 = l2.next
                b = If(l2 Is Nothing, 0, l2.val)
            End If
            If l1 IsNot Nothing OrElse l2 IsNot Nothing Then
                result = New ListNode(0, result)
            ElseIf carry > 0 Then
                result = New ListNode(carry, result)
            End If
        End While

        Return Reverse(result)

    End Function

#End Region

#Region " Private Support Routines ---------------------------------- "

    ''' <summary>
    ''' Reverses the specified head.
    ''' </summary>
    ''' <paramname="head">The head.</param>
    ''' <returns></returns>
    Private Shared Function Reverse(ByVal head As ListNode) As ListNode

        Dim result As ListNode = Nothing
        Dim curr = head

        While curr IsNot Nothing
            result = New ListNode(curr.val, result)
            curr = curr.next
        End While

        Return result

    End Function

    ''' <summary>
    ''' Counts the specified head.
    ''' </summary>
    ''' <paramname="head">The head.</param>
    ''' <returns></returns>
    Private Shared Function PalindromeCount(ByVal head As ListNode) As Integer

        Dim result = 0
        Dim curr As ListNode = head

        While curr IsNot Nothing
            result += 1
            curr = curr.next
        End While

        Return result

    End Function

#End Region

End Class
