namespace JobSearchCodeExamples.FSharp.Test.TestTaker

open JobSearchCodeExamples.FSharp.TestTaker
open Xunit

module TheaterSeatsTest =
    
    [<Fact>]
    let AssignSeatsTest() =
        let mutable seatsAssign = [| 1; 3; 5 |]
        let seatsRequested = [| 2; 3; 4 |]
        let expectedResult = [| 2; 4; 6 |]

        let actualResults = TheaterSeats.AssignSeats &seatsAssign seatsRequested

        Assert.Equal<int[]>(expectedResult, actualResults)
