namespace JobSearchCodeExamples.FSharp.TestTaker

open System
[<AllowNullLiteral>]
type public LongVersion(version : string) =
    class
        let mutable _parts : int[] = LongVersion.ParseVersion(version)

        member this.Parts  
            with get() : int[] = _parts
            and set(value : int[]) = _parts <- value

        static member private ParseVersion(version : string) : int[] =
            let parts : string[] = version.Split(".")
            let Parts :int[] = Array.zeroCreate parts.Length
            let mutable i : int = 0
            for part : string in parts do
                Parts[i] <- part |> int
                i <- i + 1
            Parts

        interface IComparable with
            member this.CompareTo(obj : obj) : int = 
                if System.Object.ReferenceEquals(this, obj) || isNull obj then
                    0
                else
                    let other : LongVersion = obj :?> LongVersion
                    let longest : int = if this.Parts.Length < other.Parts.Length then other.Parts.Length else this.Parts.Length
                    let mutable result : int = 0
                    for i = 0 to longest - 1 do
                        let mutable item1 = 0
                        let mutable item2 = 0
                        if i < this.Parts.Length then item1 <- this.Parts[i]
                        if i < other.Parts.Length then item2 <- other.Parts[i]
                        if result = 0 then
                            result <- if item1 < item2 then -1 else if item1 > item2 then 1 else 0
                    result

        override this.Equals(obj : obj) : bool =
            if System.Object.ReferenceEquals(this, obj) then
                true
            elif isNull obj then
                false
            else
                (this :> IComparable).CompareTo(obj) = 0

        override this.GetHashCode() : int =
            let mutable hash = 0
            for i = 0 to this.Parts.Length - 1 do
                hash <- hash * 17 + this.Parts[i].GetHashCode()
            hash

        static member op_Equality (left : LongVersion, right : LongVersion) : bool =
            if isNull left then
                isNull right
            else
                left.Equals(right)

        static member op_LessThan (left : LongVersion, right : LongVersion) : bool =
            if isNull left then
                not (isNull right)
            else
                (left :> IComparable).CompareTo(right) < 0

        static member op_LessThanOrEqual (left : LongVersion, right : LongVersion) : bool =
            isNull left || (left :> IComparable).CompareTo(right) <= 0

        static member op_GreaterThan (left : LongVersion, right : LongVersion) : bool =
            not (isNull left) && (left :> IComparable).CompareTo(right) > 0

        static member op_GreaterThanOrEqual (left : LongVersion, right : LongVersion) : bool =
            if isNull left then
                isNull right
            else
                (left :> IComparable).CompareTo(right) >= 0

        override this.ToString() : string =
            let mutable result : string = String.Empty
            for item in this.Parts do
                result <- result + "." + item.ToString()
            result[1..]
    end