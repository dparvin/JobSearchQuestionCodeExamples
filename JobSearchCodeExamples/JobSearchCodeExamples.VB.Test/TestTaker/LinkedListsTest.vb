Imports Xunit

Public Class LinkedListsTest

    ''' <summary>
    ''' Tests the linked list reverse.
    ''' </summary>
    <Fact>
    Public Sub TestLinkedListReverse()

        Dim list As New LinkedList(Of String)

        list.AddFirst("2")
        list.AddLast("3")
        list.AddLast("4")
        list.AddLast("5")

        Dim result = LinkedLists.ReverseList(list)

        Assert.Equal(list.Last?.Value, result.First?.Value)

    End Sub

    ''' <summary>
    ''' Tests the linked list reverse.
    ''' </summary>
    <Fact>
    Public Sub TestLinkedListNull()

        Dim list As LinkedList(Of String) = Nothing

        Dim result = LinkedLists.ReverseList(list)

        Assert.Null(result)

    End Sub

    ''' <summary>
    ''' Tests the linked list reverse.
    ''' </summary>
    <Fact>
    Public Sub TestLinkedListEmpty()

        Dim list As New LinkedList(Of String)

        Dim result = LinkedLists.ReverseList(list)

        Assert.Empty(result)
    End Sub

End Class
