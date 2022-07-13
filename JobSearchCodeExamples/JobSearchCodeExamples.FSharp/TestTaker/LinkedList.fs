namespace JobSearchCodeExamples.FSharp.TestTaker

open System.Collections.Generic

module LinkedList =
    let ReverseList (list : LinkedList<'T>) : LinkedList<'T> =
       if isNull list || list.Count = 0 then 
            list 
       else 
            let result : LinkedList<'T> = new LinkedList<'T>()
            let mutable currentItem : LinkedListNode<'T> = list.First
            while ``not`` (isNull currentItem) do
                result.AddFirst(currentItem.Value) |> ignore
                currentItem <- currentItem.Next
            result
       