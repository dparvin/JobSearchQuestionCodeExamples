namespace JobSearchCodeExamples.FSharp.TestTaker

module RansomNode =
    let CanConstruct(ransomNote: string, magazine : string) : bool =
        let mutable result : bool = true
        if magazine.Length < ransomNote.Length then
            result <- false
        else
            let mutable source = magazine
            let note : char[] = ransomNote.ToCharArray()
            for i = 0 to note.Length - 1 do
                if source.Contains(note[i]) then
                    source <- source.Remove(source.IndexOf(note[i]), 1)
                else
                    result <- false
        result

