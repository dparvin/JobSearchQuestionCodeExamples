namespace JobSearchCodeExamples.FSharp.Test.TestTaker

module LinkedListsTest =
    open Xunit
    open System.Collections.Generic
    open JobSearchCodeExamples.FSharp.TestTaker

    [<Fact>]
    let TestLinkedListReverse () =
        let list : LinkedList<string> = new LinkedList<string>()
        list.AddFirst("2") |> ignore
        list.AddLast("3") |> ignore
        list.AddLast("4") |> ignore
        list.AddLast("5") |> ignore

        let result = LinkedList.ReverseList(list)

        Assert.Equal(list.Last.Value, result.First.Value)

    [<Fact>]
    let TestLinkedListNull () =
        let list : LinkedList<string> = null

        let result = LinkedList.ReverseList(list)

        Assert.Null(result)
        
    [<Fact>]
    let TestLinkedListEmpty () =
        let list : LinkedList<string> = new LinkedList<string>()

        let result = LinkedList.ReverseList(list)

        Assert.Empty(result)
