namespace JobSearchCodeExamples.FSharp.Test.TestTaker

open JobSearchCodeExamples.FSharp.TestTaker
open Xunit
open System.Collections.Generic

module ToIntTest =
    type UnitTests() =
        static member TestData 
            with get() : IEnumerable<obj[]>  = 
            let mutable result : List<obj[]> = new List<obj[]>()
            result.Add([| "I"; 1 |])
            result.Add([| "II"; 2 |])
            result.Add([| "III"; 3 |])
            result.Add([| "IV"; 4 |])
            result.Add([| "V"; 5 |])
            result.Add([| "VI"; 6 |])
            result.Add([| "VII"; 7 |])
            result.Add([| "VIII"; 8 |])
            result.Add([| "IX"; 9 |])
            result.Add([| "X"; 10 |])
            result.Add([| "XI"; 11 |])
            result.Add([| "XX"; 20 |])
            result.Add([| "XXI"; 21 |])
            result.Add([| "XXII"; 22 |])
            result.Add([| "XXIII"; 23 |])
            result.Add([| "XXIV"; 24 |])
            result.Add([| "XXV"; 25 |])
            result.Add([| "XLV"; 45 |])
            result.Add([| "LVIII"; 58 |])
            result.Add([| "DCCC"; 800 |])
            result.Add([| "MCMLXIII"; 1963 |])
            result.Add([| "MCMXCIV"; 1994 |])
            result.Add([| "MMC"; 2100 |])
            result.Add([| "MMCD"; 2400 |])
            result.Add([| "MMCM"; 2900 |])
            result.Add([| "MMM"; 3000 |])
            result.Add([| "MMMCMLXIV"; 3964 |])
            result.Add([| "MMMCMLXV"; 3965 |])
            result.Add([| "MMMCMLXVI"; 3966 |])
            result.Add([| "MMMCMLXVII"; 3967 |])
            result.Add([| "MMMCMLXVIII"; 3968 |])
            result.Add([| "MMMCMLXIX"; 3969 |])
            result.Add([| "MMMCMLXX"; 3970 |])
            result.Add([| "MMMCMLXXI"; 3971 |])
            result.Add([| "MMMCMLXXII"; 3972 |])
            result.Add([| "MMMCMLXXIII"; 3973 |])
            result.Add([| "MMMCMLXXIV"; 3974 |])
            result.Add([| "MMMCMLXXV"; 3975 |])
            result.Add([| "MMMCMLXXVI"; 3976 |])
            result.Add([| "MMMCMLXXVII"; 3977 |])
            result.Add([| "MMMCMLXXVIII"; 3978 |])
            result.Add([| "MMMCMLXXIX"; 3979 |])
            result.Add([| "MMMCMLXXX"; 3980 |])
            result.Add([| "MMMCMLXXXI"; 3981 |])
            result.Add([| "MMMCMLXXXII"; 3982 |])
            result.Add([| "MMMCMLXXXIII"; 3983 |])
            result.Add([| "MMMCMLXXXIV"; 3984 |])
            result.Add([| "MMMCMLXXXV"; 3985 |])
            result.Add([| "MMMCMLXXXVI"; 3986 |])
            result.Add([| "MMMCMLXXXVII"; 3987 |])
            result.Add([| "MMMCMLXXXVIII"; 3988 |])
            result.Add([| "MMMCMLXXXIX"; 3989 |])
            result.Add([| "MMMCMXC"; 3990 |])
            result.Add([| "MMMCMXCI"; 3991 |])
            result.Add([| "MMMCMXCII"; 3992 |])
            result.Add([| "MMMCMXCIII"; 3993 |])
            result.Add([| "MMMCMXCIV"; 3994 |])
            result.Add([| "MMMCMXCV"; 3995 |])
            result.Add([| "MMMCMXCVI"; 3996 |])
            result.Add([| "MMMCMXCVII"; 3997 |])
            result.Add([| "MMMCMXCVIII"; 3998 |])
            result.Add([| "MMMCMXCIX"; 3999 |])

            result

        [<Theory>]
        [<MemberData("TestData")>]
        static member RomanToInt1Test(romanNumber : string, expectedResult : int) =
            let result : int = ToInt.RomanToInt(romanNumber)
            Assert.Equal(expectedResult, result)

        [<Theory>]
        [<MemberData("TestData")>]
        static member RomanToInt2Test(romanNumber : string, expectedResult : int) =
            let result : int = ToInt.RomanToInt2(romanNumber)
            Assert.Equal(expectedResult, result)

        [<Theory>]
        [<MemberData("TestData")>]
        static member RomanToInt3Test(romanNumber : string, expectedResult : int) =
            let result : int = ToInt.RomanToInt3(romanNumber)
            Assert.Equal(expectedResult, result)
