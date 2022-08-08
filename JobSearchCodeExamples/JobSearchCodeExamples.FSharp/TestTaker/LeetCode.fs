namespace JobSearchCodeExamples.FSharp.TestTaker

open System.Collections.Generic

[<AllowNullLiteral>]
type public ListNode(?val0 : int, ?next0 : ListNode) =
    let mutable value1 = defaultArg val0 0
    let mutable next1 = defaultArg next0 null
    member this.value
        with get() : int = value1
        and set(value : int) = value1 <- value
    member this.next
        with get() : ListNode = next1
        and set(value : ListNode) = next1 <- value 

module LeetCode = 
    let Count(head : ListNode) : int =
        let mutable result = 0
        let mutable curr = head

        while not (isNull curr) do
            result <- result + 1
            curr <- curr.next

        result

    let Reverse(head : ListNode) : ListNode =
        let mutable result : ListNode = null
        let mutable curr : ListNode = head

        while not (isNull curr) do
            result <- new ListNode(curr.value, result)
            curr <- curr.next

        result

    let FizzBuzz (n : int) : IList<string> =
        let mutable result : IList<string> = new List<string>()

        for i = 1 to n do
            if i % 3 = 0 && i % 5 = 0 then
                result.Add("FizzBuzz")
            elif i % 3 = 0 then
                result.Add("Fizz")
            elif i % 5 = 0 then
                result.Add("Buzz")
            else
                result.Add(i.ToString())

        result

    let FizzBuzz2(n : int) : IList<string> =
        let mutable result : string[] = Array.zeroCreate(n)

        for i = 1 to n do
            if i % 3 = 0 && i % 5 = 0 then
                result[i - 1] <- "FizzBuzz"
            elif i % 3 = 0 then
                result[i - 1] <- "Fizz"
            elif i % 5 = 0 then
                result[i - 1] <- "Buzz"
            else
                result[i - 1] <- i.ToString()

        result

    let FizzBuzz3(n : int) : IList<string> =
        let mutable result : string[] = Array.zeroCreate(n)

        for i = 0 to n - 1 do
            let mutable byThree : bool = (i + 1) % 3 = 0
            let mutable byFive : bool =  (i + 1) % 5 = 0
            if byThree || byFive then
                result[i] <- ""
                if byThree then result[i] <- result[i] + "Fizz"
                if byFive then result[i] <- result[i] + "Buzz"
            else
                result[i] <- (i + 1).ToString()

        result

    let FizzBuzz4(n : int) : IList<string> =
        let mutable result : string[] = Array.zeroCreate(n)

        for i = 0 to n - 1 do
            let mutable byThree : bool = (i + 1) % 3 = 0
            let mutable byFive : bool =  (i + 1) % 5 = 0
            if byThree && byFive then
                result[i] <- result[i] + "FizzBuzz"
            elif byThree then 
                result[i] <- result[i] + "Fizz"
            elif byFive then 
                result[i] <- result[i] + "Buzz"
            else
                result[i] <- (i + 1).ToString()

        result

    let FizzBuzz5(n : int) : IList<string> =
        let mutable result : string[] = Array.zeroCreate(n)

        for i = 0 to n - 1 do
            let mutable value = i + 1
            let mutable byThree = value % 3 = 0
            let mutable byFive = value % 5 = 0
            if byThree && byFive then
                result[i] <- result[i] + "FizzBuzz"
            elif byThree then 
                result[i] <- result[i] + "Fizz"
            elif byFive then 
                result[i] <- result[i] + "Buzz"
            else
                result[i] <- value.ToString()

        result

    let FizzBuzz6(n : int) : IList<string> =
        let mutable result : string[] = Array.zeroCreate(n)

        for i = 0 to n - 1 do
            let mutable value : int = i + 1
            let mutable byThree : bool = value % 3 = 0
            let mutable byFive : bool =  value % 5 = 0
            if byThree && byFive then
                result[i] <- result[i] + "FizzBuzz"
            elif byThree then 
                result[i] <- result[i] + "Fizz"
            elif byFive then 
                result[i] <- result[i] + "Buzz"
            else
                result[i] <- value.ToString()

        result

    let MiddleNode(head : ListNode) : ListNode =
        if isNull head || isNull head.next then
            head
        else
            let items : int = Count(head)
            let mid : int = items / 2
            let mutable curr : ListNode = head
            for i = 0 to mid - 1 do
                curr <- curr.next
            curr

    let IsPalindrome(head : ListNode) : bool =
        let mutable result : bool = true
        let mutable back : ListNode = null
        let mutable curr : ListNode = head
        if not (isNull curr) then
            back <- new ListNode(curr.value, back)
            curr <- curr.next
            while not (isNull curr) do
                back <- new ListNode(curr.value, back)
                curr <- curr.next
            curr <- head
            let mutable rev : ListNode = back
            while not (isNull curr) do
                if curr.value <> rev.value then
                    result <- false
                    curr <- null
                else
                    curr <- curr.next
                    rev <- rev.next
        result

    let IsPalindrome2(head : ListNode) : bool =
        let mutable result : bool = true
        if not (isNull head) then
            let mutable curr : ListNode = head
            let mutable rev : ListNode = Reverse(head)
            while not (isNull curr) do
                if curr.value <> rev.value then
                    result <- false
                    curr <- null
                else
                    curr <- curr.next
                    rev <- rev.next
        result

    let IsPalindrome3(head : ListNode) : bool =
        let mutable result : bool = true
        if not (isNull head) && not (isNull head.next) then
            let midPoint : int = Count(head) / 2 + 1
            let mutable curr : ListNode = head
            let mutable rev : ListNode = Reverse(head)
            let mutable count : int = 0
            while not (isNull curr) do
                if curr.value <> rev.value then
                    result <- false
                    curr <- null
                elif count > midPoint then
                    curr <- null
                else
                    curr <- curr.next
                    rev <- rev.next
                    count <- count + 1
        result

    let AddTwoNumbers(l1 : ListNode, l2 : ListNode) : ListNode = 
        if isNull l1 then
            l2
        elif isNull l2 then
            l1
        else
            let mutable i1 : ListNode = l1
            let mutable i2 : ListNode = l2
            let mutable result : ListNode = new ListNode()
            let mutable carry : int = 0
            let mutable a : int = i1.value
            let mutable b : int = i2.value
            while not (isNull i1) || not (isNull i2) do
                result.value <- a + b + carry
                if result.value > 9 then
                    carry <- 1
                    result.value <- result.value % 10
                else
                    carry <- 0
                if not (isNull i1) then
                    i1 <- i1.next
                    if isNull i1 then
                        a <- 0
                    else
                        a <- i1.value
                if not (isNull i2) then
                    i2 <- i2.next
                    if isNull i2 then
                        b<- 0
                    else
                        b <- i2.value
                if not (isNull i1) || not (isNull i2) then
                    result <- new ListNode(0, result)
                elif carry > 0 then
                    result <- new ListNode(carry, result)

            Reverse(result)