namespace JobSearchCodeExamples.FSharp.TestTaker

open System.Collections.Generic
open System.Linq

module KWeakestRowsInAMatrix = 
    let Compare(i1 : KeyValuePair<int,int>) (i2 : KeyValuePair<int,int>) : int =
        let mutable result : int = i1.Value.CompareTo(i2.Value)
        if result = 0 then result <- i1.Key.CompareTo(i2.Key)
        result

    let KWeakestRows(mat : int[][], k : int) : int[] =
        let mutable indicies = new Dictionary<int, int>()
        for i = 0 to mat.Length - 1 do
            let mutable solders : int = 0
            for j = 0 to mat[i].Length - 1 do
                if (mat[i][j] = 1) then
                    solders <- solders + 1
            indicies.Add(i, solders)
        let mutable result : KeyValuePair<int, int> array = indicies.ToArray()  
        Array.sortInPlaceWith Compare result
        let mutable ret : int array = Array.zeroCreate(k)
        for i = 0 to k - 1 do
            ret[i] <- result[i].Key
        ret
