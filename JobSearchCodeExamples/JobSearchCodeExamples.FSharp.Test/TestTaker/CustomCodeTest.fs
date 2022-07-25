namespace JobSearchCodeExamples.FSharp.Test.TestTaker

open System

module CustomCodeTest =
    open Xunit
    open JobSearchCodeExamples.FSharp.TestTaker

    [<Theory>]
    [<InlineData("2", "2.0", 0)>]
    [<InlineData("2", "2.0.0", 0)>]
    [<InlineData("2", "2.0.0.0", 0)>]
    [<InlineData("2", "2.0.0.0.0", 0)>]
    [<InlineData("2", "2.0.0.0.1", -1)>]
    [<InlineData("2", "2.1", -1)>]
    [<InlineData("2.1.0", "2.0.1", 1)>]
    [<InlineData("2.10.0.1", "2.1.0.10", 1)>]
    [<InlineData("2.0.1", "1.2000.1", 1)>]
    let TestVersionCompare (version1 : string, version2 : string, expectedResult : int) =
        let result = CustomCode.VersionCompare(version1, version2)
        Assert.Equal(expectedResult, result)

    /// <summary>Test for the custom code LongVersion CompareTo function</summary>
    [<Theory>]
    [<InlineData("", "", 0)>]
    [<InlineData("", "2.0", -1)>]
    [<InlineData("2", "", 1)>]
    [<InlineData("2", "2.0", 0)>]
    [<InlineData("2", "2.0.0", 0)>]
    [<InlineData("2", "2.0.0.0", 0)>]
    [<InlineData("2", "2.0.0.0.0", 0)>]
    [<InlineData("2", "2.0.0.0.1", -1)>]
    [<InlineData("2", "2.1", -1)>]
    [<InlineData("2.1.0", "2.0.1", 1)>]
    [<InlineData("2.10.0.1", "2.1.0.10", 1)>]
    [<InlineData("2.0.1", "1.2000.1", 1)>]
    let TestLongVersionCompare (version1 : string, version2 : string, expectedResult : int) =
        let result : int = CustomCode.LongVersionCompare(version1, version2)
        Assert.Equal(expectedResult, result)

    [<Fact>]
    let FindMissingNumber() =
        // Arrange
        let expectedMax : int = 100
        let a : int array = Array.zeroCreate (expectedMax - 1)
        let missing : int = (new Random()).Next(expectedMax) + 1
        let mutable i = 1
        for j = 0 to a.Length - 1 do
            if i = missing then i <- i + 1
            a[j] <- i
            i <- i + 1 

        // Act
        let FoundMissing : int = CustomCode.FindMissingEntry(a)

        // Assert
        Assert.Equal(missing, FoundMissing)

    [<Theory>]
    [<InlineData("", "", true)>]
    [<InlineData("", "2.0", false)>]
    [<InlineData("2", "", false)>]
    [<InlineData("2", "2.0", true)>]
    [<InlineData("2", "2.0.0", true)>]
    [<InlineData("2", "2.0.0.0", true)>]
    [<InlineData("2", "2.0.0.0.0", true)>]
    [<InlineData("2", "2.0.0.0.1", false)>]
    [<InlineData("2", "2.1", false)>]
    [<InlineData("2.1.0", "2.0.1", false)>]
    [<InlineData("2.10.0.1", "2.1.0.10", false)>]
    [<InlineData("2.0.1", "1.2000.1", false)>]
    let LongVersionEqual(version1 : string, version2 : string, expectedResult : bool) =
        let result = CustomCode.LongVersionEqual(version1, version2)
        Assert.Equal(expectedResult, result)

    [<Theory>]
    [<InlineData("", "", false)>]
    [<InlineData("", "2.0", false)>]
    [<InlineData("2", "", true)>]
    [<InlineData("2", "2.0", false)>]
    [<InlineData("2", "2.0.0", false)>]
    [<InlineData("2", "2.0.0.0", false)>]
    [<InlineData("2", "2.0.0.0.0", false)>]
    [<InlineData("2", "2.0.0.0.1", false)>]
    [<InlineData("2", "2.1", false)>]
    [<InlineData("2.1.0", "2.0.1", true)>]
    [<InlineData("2.10.0.1", "2.1.0.10", true)>]
    [<InlineData("2.0.1", "1.2000.1", true)>]
    let LongVersionGreater(version1 : string, version2 : string, expectedResult : bool) =
        let result = CustomCode.LongVersionGreater(version1, version2)
        Assert.Equal(expectedResult, result)

    [<Theory>]
    [<InlineData("", "", true)>]
    [<InlineData("", "2.0", false)>]
    [<InlineData("2", "", true)>]
    [<InlineData("2", "2.0", true)>]
    [<InlineData("2", "2.0.0", true)>]
    [<InlineData("2", "2.0.0.0", true)>]
    [<InlineData("2", "2.0.0.0.0", true)>]
    [<InlineData("2", "2.0.0.0.1", false)>]
    [<InlineData("2", "2.1", false)>]
    [<InlineData("2.1.0", "2.0.1", true)>]
    [<InlineData("2.10.0.1", "2.1.0.10", true)>]
    [<InlineData("2.0.1", "1.2000.1", true)>]
    let LongVersionGreaterEqual(version1 : string, version2 : string, expectedResult : bool) =
        let result = CustomCode.LongVersionGreaterEqual(version1, version2)
        Assert.Equal(expectedResult, result)

    [<Theory>]
    [<InlineData("", "", false)>]
    [<InlineData("", "2.0", false)>]
    [<InlineData("2", "", true)>]
    [<InlineData("2", "2.0", false)>]
    [<InlineData("2", "2.0.0", false)>]
    [<InlineData("2", "2.0.0.0", false)>]
    [<InlineData("2", "2.0.0.0.0", false)>]
    [<InlineData("2", "2.0.0.0.1", false)>]
    [<InlineData("2", "2.1", false)>]
    [<InlineData("2.1.0", "2.0.1", true)>]
    [<InlineData("2.10.0.1", "2.1.0.10", true)>]
    [<InlineData("2.0.1", "1.2000.1", true)>]
    let LongVersionLess(version1 : string, version2 : string, expectedResult : bool) =
        let result = CustomCode.LongVersionLess(version1, version2)
        Assert.Equal(expectedResult, result)

    [<Theory>]
    [<InlineData("", "", true)>]
    [<InlineData("", "2.0", true)>]
    [<InlineData("2", "", false)>]
    [<InlineData("2", "2.0", true)>]
    [<InlineData("2", "2.0.0", true)>]
    [<InlineData("2", "2.0.0.0", true)>]
    [<InlineData("2", "2.0.0.0.0", true)>]
    [<InlineData("2", "2.0.0.0.1", true)>]
    [<InlineData("2", "2.1", true)>]
    [<InlineData("2.1.0", "2.0.1", false)>]
    [<InlineData("2.10.0.1", "2.1.0.10", false)>]
    [<InlineData("2.0.1", "1.2000.1", false)>]
    let LongVersionLessEqual(version1 : string, version2 : string, expectedResult : bool) =
        let result = CustomCode.LongVersionLessEqual(version1, version2)
        Assert.Equal(expectedResult, result)
