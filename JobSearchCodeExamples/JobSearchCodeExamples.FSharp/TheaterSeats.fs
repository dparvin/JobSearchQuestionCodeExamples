namespace JobSearchCodeExamples.FSharp.TestTaker

open System

module TheaterSeats =

    /// <summary>
    /// Add an item to the end of an array that is passed byref
    /// </summary>
    /// <param name="arrByRef"></param>
    /// <param name="newValue"></param>
    let addEntry (arrByRef: byref<int[]>) (newValue: int) =
        // Handle null or empty array
        let oldArray = if isNull arrByRef then [||] else arrByRef
        // Create a new array with one extra slot
        let newArray = Array.append oldArray [|newValue|]
        // Update the byref to point to the new array
        arrByRef <- newArray
    
    /// <summary>
    /// recursively find an unused seat
    /// </summary>
    /// <param name="usedSeats">array of used seats</param>
    /// <param name="seat">the seat that the customer asked for</param>
    /// <param name="diff">the point away from the seat we are testing</param>
    let rec findSeat (usedSeats: int[]) (seat: int) (diff: int) =
        let lowerSeat = seat - diff
        let higherSeat = seat + diff

        if lowerSeat > 0 && not (Array.contains lowerSeat usedSeats) then
            lowerSeat
        elif not (Array.contains higherSeat usedSeats) then
            higherSeat
        else
            findSeat usedSeats seat (diff + 1)

    /// <summary>
    /// Find the next available seat
    /// </summary>
    /// <param name="usedSeats">the currently assigned seats</param>
    /// <param name="seat">the seat to place</param>
    let findNextAvailableSeat (usedSeats: int[]) (seat: int) : int =
        if not (Array.contains seat usedSeats) then
            seat
        else
            findSeat usedSeats seat 1        
    
    /// <summary>
    /// Assign seats to people giving them seats that are not used already
    /// </summary>
    /// <param name="seatsAssign">seats that already have been assigned</param>
    /// <param name="seatsRequested">seats that users want</param>
    let AssignSeats (seatsAssign: byref<int[]>) (seatsRequested: int[]) : int[] =
        let mutable result = Array.zeroCreate seatsRequested.Length

        for i in 0 .. seatsRequested.Length - 1 do
            let requestedSeat = seatsRequested.[i]
            let assignedSeat = findNextAvailableSeat seatsAssign requestedSeat
            result.[i] <- assignedSeat
            addEntry &seatsAssign assignedSeat

        result
