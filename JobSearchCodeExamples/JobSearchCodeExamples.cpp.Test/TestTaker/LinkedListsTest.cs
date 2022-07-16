namespace JobSearchCodeExamples.cpp.Test.TestTaker;

public class LinkedListsTest
{
    /// <summary>
    /// Tests the linked list reverse.
    /// </summary>
    [Fact]
    public void TestLinkedListReverse()
    {
        LinkedList<string> list = new();
        list.AddFirst("2");
        list.AddLast("3");
        list.AddLast("4");
        list.AddLast("5");
        var result = LinkedLists.ReverseList(list);
        Assert.Equal(list.Last?.Value, result?.First?.Value);
    }

    /// <summary>
    /// Tests the linked list reverse.
    /// </summary>
    [Fact]
    public void TestLinkedListNull()
    {
        LinkedList<string>? list = null;
        var result = LinkedLists.ReverseList(list);
        Assert.Null(result);
    }

    /// <summary>
    /// Tests the linked list reverse.
    /// </summary>
    [Fact]
    public void TestLinkedListEmpty()
    {
        LinkedList<string>? list = new();
        var result = LinkedLists.ReverseList(list);
        Assert.Empty(result);
    }
}