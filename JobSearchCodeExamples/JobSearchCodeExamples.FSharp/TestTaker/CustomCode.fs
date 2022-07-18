namespace JobSearchCodeExamples.FSharp.TestTaker

open System
open System.Linq

module CustomCode =
    let VersionCompare (version1 : string, version2 : string) : int =
        let v1 : string[] = version1.Split(".")
        let v2 : string[] = version2.Split(".")
        let longest : int = if v1.Length < v2.Length then v2.Length else v1.Length
        let mutable result : int = 0
        for i = 0 to longest - 1 do
            let mutable item1 : int = 0
            let mutable item2 : int = 0
            if i < v1.Length then item1 <- v1[i] |> int
            if i < v2.Length then item2 <- v2[i] |> int
            if result = 0 then 
                result <- if item1 < item2 then -1 else if item1 > item2 then 1 else 0
        result

    let LongVersionCompare (version1 : string, version2 : string) : int =
        let v1 : LongVersion = new LongVersion(version1)
        let v2 : LongVersion = new LongVersion(version2)
        (v1 :> IComparable).CompareTo(v2)

    let FindMissingEntry(values : int array) =
        ((values.Length + 1) * (values.Length + 2) / 2) - values.Sum()
