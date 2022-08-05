namespace JobSearchCodeExamples.FSharp.TestTaker

open System
open System.Linq
open System.Collections.Generic

module ToInt =
    let RomanToInt(s : string) : int =
        let mutable pos = 0
        let mutable result = 0
        while pos < s.Length do
            let mutable spos : string = s[pos].ToString()
            let mutable snext : string = ""
            if (pos < s.Length - 1) then
                snext <- s[pos + 1].ToString()
            match spos with
            | "I" -> 
                match snext with
                | "V" ->
                    result <- result + 4
                    pos <- pos + 1
                | "X" ->
                    result <- result + 9
                    pos <- pos + 1
                | _ -> result <- result + 1
            | "V" -> result <- result + 5
            | "X" ->
                match snext with
                | "L" ->
                    result <- result + 40
                    pos <- pos + 1
                | "C" ->
                    result <- result + 90
                    pos <- pos + 1
                | _ -> result <- result + 10
            | "L" -> result <- result + 50
            | "C" ->
                match snext with
                | "D" ->
                    result <- result + 400
                    pos <- pos + 1
                | "M" ->
                    result <- result + 900
                    pos <- pos + 1
                | _ -> result <- result + 100
            | "D" -> result <- result + 500
            | "M" -> result <- result + 1000
            pos <- pos + 1
        result

    let RomanToInt2(s : string) : int =
        let roman : string[] = [|"I"; "V"; "X"; "L"; "C"; "D"; "M"|]
        let values : int[] = [|1; 5; 10; 50; 100; 500; 1000|]
        let before : string[] = [| "I"; "X"; "C" |]
        let after : string [][] = [| [| "V"; "X" |]; [| "L"; "C" |]; [| "D"; "M" |] |]
        let extraValues : int[][] = [| [| 4; 9 |]; [| 40; 90 |]; [| 400; 900 |] |]
        let mutable pos = 0
        let mutable result = 0
        while pos < s.Length do
            let mutable spos : string =  s[pos].ToString()
            let mutable snext : string = ""
            if pos < s.Length - 1 then
                snext <- s[pos + 1].ToString()
            let mutable romanIndex = Array.IndexOf(roman,spos)
            if before.Contains(spos) &&  not (String.IsNullOrEmpty snext) then
                let mutable beforeIndex = Array.IndexOf(before, spos)
                if after[beforeIndex].Contains(snext) then
                    result <- result + extraValues[beforeIndex][Array.IndexOf(after[beforeIndex], snext)]
                    pos <- pos + 1
                else
                    result <- result + values[romanIndex]
            else
                result <- result + values[romanIndex]
            pos <- pos + 1
        result

    let RomanToInt3(s : string) : int =
        let mutable RomanValues : Dictionary<string, int> = new Dictionary<string, int>()
        RomanValues.Add("I", 1)
        RomanValues.Add("V", 5)
        RomanValues.Add("X", 10)
        RomanValues.Add("L", 50)
        RomanValues.Add("C", 100)
        RomanValues.Add("D", 500)
        RomanValues.Add("M", 1000)
        let mutable pos : int = 0
        let mutable result : int = 0
        while pos < s.Length do
            let mutable spos : string = s[pos].ToString()
            let mutable snext : string = ""
            if pos < s.Length - 1 then
                snext <- s[pos + 1].ToString()
            if String.IsNullOrEmpty snext then
                result <- result + RomanValues[spos]
            elif RomanValues[spos] < RomanValues[snext] then
                result <- result - RomanValues[spos]
            else
                result <- result + RomanValues[spos]
            pos <- pos + 1
        result
