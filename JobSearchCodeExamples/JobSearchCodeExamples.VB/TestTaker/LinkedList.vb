Namespace TestTaker

    ''' <summary>
    ''' Class for doing things with linked lists
    ''' </summary>
    Public Class LinkedLists

        ''' <summary>
        ''' Reverses the list.
        ''' </summary>
        ''' <paramname="list">The list.</param>
        ''' <returns></returns>
        Public Shared Function ReverseList(Of T)(
            ByVal list As LinkedList(Of T)) As LinkedList(Of T)

            Dim results As New LinkedList(Of T)
            If list Is Nothing OrElse list.Count = 0 Then Return list
            Dim currentItem As LinkedListNode(Of T) = list.First
            While currentItem IsNot Nothing
                results.AddFirst(currentItem.Value)
                currentItem = currentItem.Next
            End While

            Return results

        End Function

    End Class

End Namespace
