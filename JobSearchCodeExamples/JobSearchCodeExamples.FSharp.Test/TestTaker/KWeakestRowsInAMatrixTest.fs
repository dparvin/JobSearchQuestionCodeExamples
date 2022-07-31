namespace JobSearchCodeExamples.FSharp.Test.TestTaker

open JobSearchCodeExamples.FSharp.TestTaker
open Xunit

module KWeakestRowsInAMatrixTest =

    [<Fact>]
    let KWeakestRowsInAMatrixTest() =
        let testArray : int [][] = 
            [| 
                [|1;1;0;0;0|]; 
                [|1;1;1;1;0|]; 
                [|1;0;0;0;0|]; 
                [|1;1;0;0;0|]; 
                [|1;1;1;1;1|] 
                |]
        let expectedResult : int[] = [|2;0;3|]
        let result : int[] = KWeakestRowsInAMatrix.KWeakestRows(testArray, 3)
        Assert.Equal(expectedResult.Length, result.Length)

