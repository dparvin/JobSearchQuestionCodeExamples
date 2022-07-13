namespace JobSearchCodeExamples.FSharp.TestTaker

module EmployeeCoverage =
    let MaxCoverage (employees : string[]) : int =
        let combined : int array = Array.zeroCreate (employees.Length)
        for i = 0 to employees.Length - 1 do
            let years = employees[i].Split("-")
            let startDate = years[0] |> int
            let endDate = years[1] |> int
            for j = i + 1 to employees.Length - 1 do
                let years2 = employees[j].Split("-")
                let start = years2[0] |> int
                let endYear = years2[1] |> int
                if startDate <= start && endDate >= start ||
                   startDate <= endYear && endDate >= endYear ||
                   startDate <= start && endDate >= endYear ||
                   startDate >= start && endDate <= endYear then
                   combined[i] <- combined[i] + if combined[i] = 0 then 2 else 1
                   combined[j] <- combined[j] + if combined[j] = 0 then 2 else 1
        let mutable maxValue = 0
        for i = 0 to employees.Length - 1 do
            if combined[i] > maxValue then maxValue <- combined[i]
        maxValue
                    

