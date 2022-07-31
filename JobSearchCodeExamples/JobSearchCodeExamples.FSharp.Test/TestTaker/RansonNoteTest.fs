namespace JobSearchCodeExamples.FSharp.Test.TestTaker

open JobSearchCodeExamples.FSharp.TestTaker
open Xunit

module RansonNoteTest =
    
    [<Theory>]
    [<InlineData("a", "b", false)>]
    [<InlineData("aa", "ab", false)>]
    [<InlineData("aa", "aab", true)>]
    [<InlineData("aa", "b", false)>]
    [<InlineData("aabc", "aabd", false)>]
    let CanConstructTest(ransomNode : string, magazine : string, expectedResult : bool) =
        Assert.Equal(expectedResult, RansomNode.CanConstruct(ransomNode, magazine))