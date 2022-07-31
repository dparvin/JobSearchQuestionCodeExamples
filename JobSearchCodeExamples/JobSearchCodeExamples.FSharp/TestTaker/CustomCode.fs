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
        let mutable v1 : LongVersion = null
        let mutable v2 : LongVersion = null
        if not (String.IsNullOrEmpty(version1)) then v1 <- new LongVersion(version1) 
        if not (String.IsNullOrEmpty(version2)) then v2 <- new LongVersion(version2)
        if isNull v1 then 
            if isNull v2 then 
                0
            else
                -1
        else
            (v1 :> IComparable).CompareTo(v2)

    let FindMissingEntry(values : int array) =
        ((values.Length + 1) * (values.Length + 2) / 2) - values.Sum()

    let LongVersionEqual(version1 : string, version2 : string) : bool =
        let mutable v1 : LongVersion = null
        let mutable v2 : LongVersion = null
        if not (String.IsNullOrEmpty(version1)) then v1 <- new LongVersion(version1) 
        if not (String.IsNullOrEmpty(version2)) then v2 <- new LongVersion(version2) 
        v1 = v2

    let LongVersionNotEqual(version1 : string, version2 : string) : bool =
        let mutable v1 : LongVersion = null
        let mutable v2 : LongVersion = null
        if not (String.IsNullOrEmpty(version1)) then v1 <- new LongVersion(version1) 
        if not (String.IsNullOrEmpty(version2)) then v2 <- new LongVersion(version2) 
        v1 <> v2

    let LongVersionEqualSame(version : string) : bool =
        let mutable v : LongVersion = null
        if not (String.IsNullOrEmpty(version)) then 
            v <- new LongVersion(version)
        v = v

    let LongVersionGetHashCode() : int =
        let v = new LongVersion("2.0.0.1")
        v.GetHashCode()

    let LongVersionToString() : string =
        let v = new LongVersion("2.0.0.1")
        v.ToString()

    let LongVersionGreater(version1 : string, version2 : string) : bool =
        let mutable v1 : LongVersion = null
        let mutable v2 : LongVersion = null
        if not (String.IsNullOrEmpty(version1)) then v1 <- new LongVersion(version1) 
        if not (String.IsNullOrEmpty(version2)) then v2 <- new LongVersion(version2) 
        v1 > v2

    let LongVersionGreaterEqual(version1 : string, version2 : string) : bool =
        let mutable v1 : LongVersion = null
        let mutable v2 : LongVersion = null
        if not (String.IsNullOrEmpty(version1)) then v1 <- new LongVersion(version1) 
        if not (String.IsNullOrEmpty(version2)) then v2 <- new LongVersion(version2) 
        v1 >= v2

    let LongVersionLess(version1 : string, version2 : string) : bool =
        let mutable v1 : LongVersion = null
        let mutable v2 : LongVersion = null
        if not (String.IsNullOrEmpty(version1)) then v1 <- new LongVersion(version1) 
        if not (String.IsNullOrEmpty(version2)) then v2 <- new LongVersion(version2) 
        v1 < v2

    let LongVersionLessEqual(version1 : string, version2 : string) : bool =
        let mutable v1 : LongVersion = null
        let mutable v2 : LongVersion = null
        if not (String.IsNullOrEmpty(version1)) then v1 <- new LongVersion(version1) 
        if not (String.IsNullOrEmpty(version2)) then v2 <- new LongVersion(version2) 
        v1 <= v2

