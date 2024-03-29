﻿namespace JobSearchCodeExamples.FSharp.Test.TestTaker

module EmployeeCoverageTest =
    open Xunit
    open JobSearchCodeExamples.FSharp.TestTaker

    [<Fact>]
    let MaxCoverageTest () =
        let employees : string[] = [| 
            "79-84"; 
            "80-86"; 
            "75-83"; 
            "90-99"; 
            "87-95" |]

        let results = EmployeeCoverage.MaxCoverage(employees)

        Assert.Equal(3, results)

    [<Fact>]
    let MaxCoverageFillBranchTest () =
        let employees : string[] = [| 
            "79-84"; 
            "80-86"; 
            "75-83"; 
            "74-99"; 
            "87-95"; 
            "65-67" |]

        let results = EmployeeCoverage.MaxCoverage(employees)

        Assert.Equal(5, results)
