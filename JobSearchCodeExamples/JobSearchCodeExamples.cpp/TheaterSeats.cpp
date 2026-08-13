#include "TheaterSeats.h"

/// <summary>
/// Assigns the seats.
/// </summary>
/// <param name="seatAssign">The seat assign.</param>
/// <param name="seatsRequested">The seats requested.</param>
/// <returns></returns>
array<int>^ TheaterSeats::AssignSeats(array<int>^% seatAssign, array<int>^ seatsRequested)
{
	array<int>^ results = gcnew array<int>(seatsRequested->Length);
	List<int>^ usedSeats = gcnew List<int>(seatAssign);
	for (int i = 0; i < seatsRequested->Length; i++)
	{
		int nextAvailableSeat = FindNextAvailableSeat(usedSeats, seatsRequested[i]);
		results[i] = nextAvailableSeat;
		usedSeats->Add(nextAvailableSeat);
	}
	seatAssign = usedSeats->ToArray();
	return results;
}

/// <summary>
/// Finds the next available seat.
/// </summary>
/// <param name="usedSeats">The used seats.</param>
/// <param name="seat">The seat.</param>
/// <returns></returns>
int TheaterSeats::FindNextAvailableSeat(List<int>^ usedSeats, int seat)
{
	if (!usedSeats->Contains(seat)) return seat;

	int diff = 1;
	while (true)
	{
		int lowerSeat = seat - diff;
		int upperSeat = seat + diff;
		if (lowerSeat > 0 && !usedSeats->Contains(lowerSeat)) return lowerSeat;
		if (!usedSeats->Contains(upperSeat)) return upperSeat;
		diff++;
	}
}
