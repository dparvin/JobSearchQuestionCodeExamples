namespace JobSearchCodeExamples.FSharp.Test.TestTaker

open JobSearchCodeExamples.FSharp.TestTaker
open Xunit
open System.Collections.Generic

module LeetCodeTest =
    type UnitTests() =
        static member FizzBuzzTestData 
            with get() : IEnumerable<obj[]>  = 
            let mutable result : List<obj[]> = new List<obj[]>()
            result.Add([| 3; [| "1"; "2"; "Fizz" |] |])
            result.Add([| 5; [| "1"; "2"; "Fizz"; "4"; "Buzz" |] |])
            result.Add([| 15; [| "1"; "2"; "Fizz"; "4"; "Buzz"; "Fizz"; "7"; "8"; "Fizz"; "Buzz"; "11"; "Fizz"; "13"; "14"; "FizzBuzz" |] |])

            result
  
        static member MiddleNodeTestData 
            with get() : IEnumerable<obj[]>  = 
            let mutable result : List<obj[]> = new List<obj[]>()
            result.Add([| [| 1; 2; 3; 4; 5 |]; [| 3; 4; 5 |] |])
            result.Add([| [| 1; 2; 3; 4; 5; 6 |]; [| 4; 5; 6 |] |])
            result.Add([| [| 3 |]; [| 3 |] |])
            result.Add([| null; null |])

            result

        static member PalidromeTestData 
            with get() : IEnumerable<obj[]>  = 
            let mutable result : List<obj[]> = new List<obj[]>()
            result.Add([| [| 1 |]; true |])
            result.Add([| [| 1; 2; 3; 2; 1 |]; true |])
            result.Add([| [| 1; 2; 3; 2 |]; false |])
            result.Add([| [| 1; 2; 3; 3; 2; 1 |]; true |])
            result.Add([| [| 1; 2; 3; 4; 2; 1 |]; false |])
            result.Add([| null; true |])

            result

        static member AddTwoNumbersTestData 
            with get() : IEnumerable<obj[]>  = 
            let mutable result : List<obj[]> = new List<obj[]>()
            result.Add([| [| 0 |]; [| 0 |]; [| 0 |] |])
            result.Add([| [| 2; 4; 3 |]; [| 5; 6; 4 |]; [| 7; 0; 8 |] |])
            result.Add([| [| 2; 4; 3 |]; null; [| 2; 4; 3 |] |])
            result.Add([| [| 9; 9; 9; 9; 9; 9; 9 |]; [| 9; 9; 9; 9 |]; [| 8; 9; 9; 9; 0; 0; 0; 1 |] |])
            result.Add([| [| 9 |]; [| 1; 9; 9; 9; 9; 9; 9; 9; 9; 9 |]; [| 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 1 |] |])
            result.Add([| null; [| 5; 6; 4 |]; [| 5; 6; 4 |] |])
            result.Add([| null; null; null |])

            result

        static member ToListNode(items : int[]) : ListNode =
            let mutable result : ListNode = null

            if not (isNull items) then 
                for i = items.Length - 1 downto 0 do
                    result <- new ListNode(items[i], result)

            result

        static member ToArray(nodes : ListNode) : int[] =
            if isNull nodes then
                null
            else
                let mutable result : List<int> = new List<int>()
                let mutable curr : ListNode = nodes

                if not (isNull nodes) then
                    while (not (isNull curr)) do
                        result.Add(curr.value)
                        curr <- curr.next

                result.ToArray()
    
        [<Theory>]
        [<MemberData("FizzBuzzTestData")>]
        static member FizzBuzz1Test (n : int, expectedResult : string[]) =
            Assert.Equal(expectedResult, LeetCode.FizzBuzz(n))

        [<Theory>]
        [<MemberData("FizzBuzzTestData")>]
        static member FizzBuzz2Test (n : int, expectedResult : string[]) =
            Assert.Equal(expectedResult, LeetCode.FizzBuzz2(n))

        [<Theory>]
        [<MemberData("FizzBuzzTestData")>]
        static member FizzBuzz3Test (n : int, expectedResult : string[]) =
            Assert.Equal(expectedResult, LeetCode.FizzBuzz3(n))

        [<Theory>]
        [<MemberData("FizzBuzzTestData")>]
        static member FizzBuzz4Test (n : int, expectedResult : string[]) =
            Assert.Equal(expectedResult, LeetCode.FizzBuzz4(n))

        [<Theory>]
        [<MemberData("FizzBuzzTestData")>]
        static member FizzBuzz5Test (n : int, expectedResult : string[]) =
            Assert.Equal(expectedResult, LeetCode.FizzBuzz5(n))

        [<Theory>]
        [<MemberData("FizzBuzzTestData")>]
        static member FizzBuzz6Test (n : int, expectedResult : string[]) =
            Assert.Equal(expectedResult, LeetCode.FizzBuzz6(n))

        [<Theory>]
        [<MemberData("MiddleNodeTestData")>]
        static member MiddleNodeTest (items : int[], expectedResult : int[]) =
            Assert.Equal<int[]>(expectedResult, UnitTests.ToArray(LeetCode.MiddleNode(UnitTests.ToListNode(items))))

        [<Theory>]
        [<MemberData("PalidromeTestData")>]
        static member IsPalindrome1Test (items : int[], expectedResult : bool) =
            Assert.Equal(expectedResult, LeetCode.IsPalindrome(UnitTests.ToListNode(items)))

        [<Theory>]
        [<MemberData("PalidromeTestData")>]
        static member IsPalindrome2Test (items : int[], expectedResult : bool) =
            Assert.Equal(expectedResult, LeetCode.IsPalindrome2(UnitTests.ToListNode(items)))

        [<Theory>]
        [<MemberData("PalidromeTestData")>]
        static member IsPalindrome3Test (items : int[], expectedResult : bool) =
            Assert.Equal(expectedResult, LeetCode.IsPalindrome3(UnitTests.ToListNode(items)))

        [<Theory>]
        [<MemberData("AddTwoNumbersTestData")>]
        static member AddTwoNumbers1Test (items1 : int[], items2 : int[], expectedResult : int[]) =
            Assert.Equal<int[]>(expectedResult, UnitTests.ToArray(LeetCode.AddTwoNumbers(UnitTests.ToListNode(items1), UnitTests.ToListNode(items2))))
